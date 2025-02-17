﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage.Test;
using NUnit.Framework;

namespace Azure.Storage.Blobs.Tests
{
    public class AppendBlobClientTransferValidationTests : BlobBaseClientTransferValidationTests<AppendBlobClient>
    {
        public AppendBlobClientTransferValidationTests(bool async, BlobClientOptions.ServiceVersion serviceVersion)
            : base(async, serviceVersion, null /* RecordedTestMode.Record /* to re-record */)
        {
        }

        protected override async Task<AppendBlobClient> GetResourceClientAsync(
            BlobContainerClient container,
            int resourceLength = default,
            bool createResource = default,
            string resourceName = null,
            UploadTransferValidationOptions uploadTransferValidationOptions = default,
            DownloadTransferValidationOptions downloadTransferValidationOptions = default,
            BlobClientOptions options = null)
        {
            options ??= ClientBuilder.GetOptions();
            options.UploadTransferValidationOptions = uploadTransferValidationOptions;
            options.DownloadTransferValidationOptions = downloadTransferValidationOptions;

            container = InstrumentClient(new BlobContainerClient(container.Uri, Tenants.GetNewSharedKeyCredentials(), options));
            var appendBlob = InstrumentClient(container.GetAppendBlobClient(resourceName ?? GetNewResourceName()));
            if (createResource)
            {
                await appendBlob.CreateAsync();
            }

            return appendBlob;
        }

        protected override async Task<Stream> OpenWriteAsync(
            AppendBlobClient client,
            UploadTransferValidationOptions hashingOptions,
            int internalBufferSize)
        {
            return await client.OpenWriteAsync(true, new AppendBlobOpenWriteOptions
            {
                TransferValidationOptions = hashingOptions,
                BufferSize = internalBufferSize
            });
        }

        protected override Task ParallelUploadAsync(
            AppendBlobClient client,
            Stream source,
            UploadTransferValidationOptions hashingOptions,
            StorageTransferOptions transferOptions)
        {
            TestHelper.AssertInconclusiveRecordingFriendly(Recording.Mode, "AppendBlobClient contains no definition for parallel upload.");
            return Task.CompletedTask;
        }

        protected override async Task<Response> UploadPartitionAsync(
            AppendBlobClient client,
            Stream source,
            UploadTransferValidationOptions hashingOptions)
        {
            return (await client.AppendBlockAsync(source, new AppendBlobAppendBlockOptions
            {
                TransferValidationOptions = hashingOptions
            })).GetRawResponse();
        }

        protected override async Task SetupDataAsync(AppendBlobClient client, Stream data)
        {
            using Stream writestream = await client.OpenWriteAsync(false);
            await data.CopyToAsync(writestream);
            await writestream.FlushAsync();
        }

        protected override bool ParallelUploadIsChecksumExpected(Request request)
        {
            return true;
        }
    }
}
