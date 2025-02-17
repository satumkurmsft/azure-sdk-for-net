﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Messaging.ServiceBus.Core;
using Moq;
using NUnit.Framework;

namespace Azure.Messaging.ServiceBus.Tests.Receiver
{
    public class ReceiverTests
    {
        [Test]
        public void ClientProperties()
        {
            var account = Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(12));
            var fullyQualifiedNamespace = new UriBuilder($"{account}.servicebus.windows.net/").Host;
            var connString = $"Endpoint=sb://{fullyQualifiedNamespace};SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey={Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(64))}";
            var queueName = Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(12));
            var options = new ServiceBusReceiverOptions()
            {
                ReceiveMode = ServiceBusReceiveMode.ReceiveAndDelete
            };
            var receiver = new ServiceBusClient(connString).CreateReceiver(queueName, options);
            Assert.AreEqual(queueName, receiver.EntityPath);
            Assert.AreEqual(fullyQualifiedNamespace, receiver.FullyQualifiedNamespace);
            Assert.IsNotNull(receiver.Identifier);
            Assert.IsFalse(receiver.IsSessionReceiver);
            Assert.AreEqual(ServiceBusReceiveMode.ReceiveAndDelete, receiver.ReceiveMode);
        }

        [Test]
        public void EntityPathConstructedCorrectly()
        {
            var account = Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(12));
            var fullyQualifiedNamespace = new UriBuilder($"{account}.servicebus.windows.net/").Host;
            var connString = $"Endpoint=sb://{fullyQualifiedNamespace};SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey={Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(64))}";
            var queueName = "queueName";
            var client = new ServiceBusClient(connString);
            var receiver = client.CreateReceiver(queueName, new ServiceBusReceiverOptions
            {
                SubQueue = SubQueue.None
            });
            Assert.AreEqual("queueName", receiver.EntityPath);

            receiver = client.CreateReceiver(queueName, new ServiceBusReceiverOptions
            {
                SubQueue = SubQueue.DeadLetter
            });
            Assert.AreEqual("queueName/$DeadLetterQueue", receiver.EntityPath);

            receiver = client.CreateReceiver(queueName, new ServiceBusReceiverOptions
            {
                SubQueue = SubQueue.TransferDeadLetter
            });
            Assert.AreEqual("queueName/$Transfer/$DeadLetterQueue", receiver.EntityPath);
        }

        [Test]
        public void PeekValidatesMaxMessageCount()
        {
            var account = Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(12));
            var fullyQualifiedNamespace = new UriBuilder($"{account}.servicebus.windows.net/").Host;
            var connString = $"Endpoint=sb://{fullyQualifiedNamespace};SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey={Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(64))}";
            var client = new ServiceBusClient(connString);
            var receiver = client.CreateReceiver("queueName");
            Assert.That(
                async () => await receiver.PeekMessagesAsync(0),
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(
                async () => await receiver.PeekMessagesAsync(-1),
                Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ReceiveValidatesMaxMessageCount()
        {
            var account = Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(12));
            var fullyQualifiedNamespace = new UriBuilder($"{account}.servicebus.windows.net/").Host;
            var connString = $"Endpoint=sb://{fullyQualifiedNamespace};SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey={Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(64))}";
            var client = new ServiceBusClient(connString);
            var receiver = client.CreateReceiver("queueName");
            Assert.That(
                async () => await receiver.ReceiveMessagesAsync(0),
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(
                async () => await receiver.ReceiveMessagesAsync(-1),
                Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ReceiverOptionsValidation()
        {
            var options = new ServiceBusReceiverOptions();
            Assert.That(
                () => options.PrefetchCount = -1,
                Throws.InstanceOf<ArgumentOutOfRangeException>());

            // should not throw
            options.PrefetchCount = 0;
        }

        [Test]
        public void ReceiveValidatesMaxWaitTime()
        {
            var account = Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(12));
            var fullyQualifiedNamespace = new UriBuilder($"{account}.servicebus.windows.net/").Host;
            var connString = $"Endpoint=sb://{fullyQualifiedNamespace};SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey={Encoding.Default.GetString(ServiceBusTestUtilities.GetRandomBuffer(64))}";
            var client = new ServiceBusClient(connString);
            var receiver = client.CreateReceiver("queue");
            Assert.That(
                async () => await receiver.ReceiveMessageAsync(TimeSpan.FromSeconds(0)),
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(
                async () => await receiver.ReceiveMessageAsync(TimeSpan.FromSeconds(-1)),
                Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public async Task ReceiveValidatesMaxWaitTimePrefetchMode()
        {
            var mockTransportReceiver = new Mock<TransportReceiver>();
            var mockConnection = ServiceBusTestUtilities.CreateMockConnection();
            mockConnection.Setup(
                    connection => connection.CreateTransportReceiver(
                        It.IsAny<string>(),
                        It.IsAny<ServiceBusRetryPolicy>(),
                        It.IsAny<ServiceBusReceiveMode>(),
                        It.IsAny<uint>(),
                        It.IsAny<string>(),
                        It.IsAny<string>(),
                        It.IsAny<bool>(),
                        It.IsAny<bool>(),
                        It.IsAny<CancellationToken>()))
                .Returns(mockTransportReceiver.Object);
            IReadOnlyList<ServiceBusReceivedMessage> receivedMessages = new[]
            {
                ServiceBusModelFactory.ServiceBusReceivedMessage(messageId: Guid.NewGuid().ToString())
            };
            mockTransportReceiver.Setup(transportReceiver =>
                    transportReceiver.ReceiveMessagesAsync(It.IsAny<int>(), It.IsAny<TimeSpan?>(),
                        It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(receivedMessages));

            var receiver = new ServiceBusReceiver(mockConnection.Object, "queue", default,
                new ServiceBusReceiverOptions {PrefetchCount = 10});

            Assert.That(
                async () => await receiver.ReceiveMessagesAsync(10, TimeSpan.FromSeconds(-1)),
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(
                async () => await receiver.ReceiveMessageAsync(TimeSpan.FromSeconds(-1)),
                Throws.InstanceOf<ArgumentOutOfRangeException>());

            var actuallyReceivedMessages =
                await receiver.ReceiveMessagesAsync(10, TimeSpan.FromSeconds(0)).ConfigureAwait(false);
            Assert.AreEqual(receivedMessages.Count, actuallyReceivedMessages.Count);
            Assert.AreEqual(receivedMessages[0].MessageId, actuallyReceivedMessages[0].MessageId);
        }

        [Test]
        public async Task ReceiveMessageValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.ReceiveMessageAsync(),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task ReceiveMessagesValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.ReceiveMessagesAsync().GetAsyncEnumerator().MoveNextAsync(),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task PeekMessageValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.PeekMessageAsync(),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task PeekMessagesValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.PeekMessagesAsync(10),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task CompleteMessageValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.CompleteMessageAsync(new ServiceBusReceivedMessage()),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task AbandonMessageValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.AbandonMessageAsync(new ServiceBusReceivedMessage()),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task DeadLetterMessageValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.DeadLetterMessageAsync(new ServiceBusReceivedMessage()),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task DeferValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.DeferMessageAsync(new ServiceBusReceivedMessage()),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task ReceiveDeferredMessageValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.ReceiveDeferredMessageAsync(12345),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task ReceiveDeferredMessagesValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.ReceiveDeferredMessagesAsync(new[] { 12345L, 678910L }),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task RenewMessageLockValidatesClientIsNotDisposed()
        {
            await using var client = new ServiceBusClient("not.real.com", Mock.Of<TokenCredential>());
            await using var receiver = client.CreateReceiver("fake");

            await client.DisposeAsync();
            Assert.That(async () => await receiver.RenewMessageLockAsync(new ServiceBusReceivedMessage()),
                Throws.InstanceOf<ObjectDisposedException>().And.Property(nameof(ObjectDisposedException.ObjectName)).EqualTo(nameof(ServiceBusConnection)));
        }

        [Test]
        public async Task CloseRespectsCancellationToken()
        {
            var mockTransportReceiver = new Mock<TransportReceiver>();
            var cts = new CancellationTokenSource();

            // mutate the cancellation token to distinguish it from CancellationToken.None
            cts.CancelAfter(100);

            var mockConnection = ServiceBusTestUtilities.CreateMockConnection();
            mockConnection.Setup(
                connection => connection.CreateTransportReceiver(
                    It.IsAny<string>(),
                    It.IsAny<ServiceBusRetryPolicy>(),
                    It.IsAny<ServiceBusReceiveMode>(),
                    It.IsAny<uint>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<bool>(),
                    It.IsAny<bool>(),
                    It.IsAny<CancellationToken>()))
                .Returns(mockTransportReceiver.Object);

            var receiver = new ServiceBusReceiver(mockConnection.Object, "fake", default, new ServiceBusReceiverOptions());
            await receiver.CloseAsync(cts.Token);
            mockTransportReceiver.Verify(transportReceiver => transportReceiver.CloseAsync(It.Is<CancellationToken>(ct => ct == cts.Token)));
        }

        [Test]
        public async Task CallingCloseAsyncUpdatesIsClosed()
        {
            var mockConnection = ServiceBusTestUtilities.GetMockedReceiverConnection();
            var receiver = new ServiceBusReceiver(mockConnection, "fake", default, new ServiceBusReceiverOptions());
            await receiver.CloseAsync();
            Assert.IsTrue(receiver.IsClosed);
        }
    }
}
