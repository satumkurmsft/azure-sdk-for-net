// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A Media Services account update. </summary>
    public partial class MediaservicePatch
    {
        /// <summary> Initializes a new instance of MediaservicePatch. </summary>
        public MediaservicePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            StorageAccounts = new ChangeTrackingList<StorageAccount>();
            PrivateEndpointConnections = new ChangeTrackingList<MediaPrivateEndpointConnectionData>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The Managed Identity for the Media Services account. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The Media Services account ID. </summary>
        public Guid? MediaServiceId { get; }
        /// <summary> The storage accounts for this resource. </summary>
        public IList<StorageAccount> StorageAccounts { get; }
        /// <summary> Gets or sets the storage authentication. </summary>
        public StorageAuthentication? StorageAuthentication { get; set; }
        /// <summary> The account encryption properties. </summary>
        public AccountEncryption Encryption { get; set; }
        /// <summary> The Key Delivery properties for Media Services account. </summary>
        internal KeyDelivery KeyDelivery { get; set; }
        /// <summary> The access control properties for Key Delivery. </summary>
        public AccessControl KeyDeliveryAccessControl
        {
            get => KeyDelivery is null ? default : KeyDelivery.AccessControl;
            set
            {
                if (KeyDelivery is null)
                    KeyDelivery = new KeyDelivery();
                KeyDelivery.AccessControl = value;
            }
        }

        /// <summary> Whether or not public network access is allowed for resources under the Media Services account. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Provisioning state of the Media Services account. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The Private Endpoint Connections created for the Media Service account. </summary>
        public IReadOnlyList<MediaPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
