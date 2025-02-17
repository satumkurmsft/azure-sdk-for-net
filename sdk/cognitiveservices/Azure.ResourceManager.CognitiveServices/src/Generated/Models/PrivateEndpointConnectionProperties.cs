// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties of the PrivateEndpointConnectProperties. </summary>
    public partial class PrivateEndpointConnectionProperties
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionProperties. </summary>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionState"/> is null. </exception>
        public PrivateEndpointConnectionProperties(CognitiveServicesPrivateLinkServiceConnectionState connectionState)
        {
            if (connectionState == null)
            {
                throw new ArgumentNullException(nameof(connectionState));
            }

            ConnectionState = connectionState;
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionProperties. </summary>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <param name="groupIds"> The private link resource group ids. </param>
        internal PrivateEndpointConnectionProperties(SubResource privateEndpoint, CognitiveServicesPrivateLinkServiceConnectionState connectionState, CognitiveServicesPrivateEndpointConnectionProvisioningState? provisioningState, IList<string> groupIds)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            GroupIds = groupIds;
        }

        /// <summary> The resource of private end point. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public CognitiveServicesPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public CognitiveServicesPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
        /// <summary> The private link resource group ids. </summary>
        public IList<string> GroupIds { get; }
    }
}
