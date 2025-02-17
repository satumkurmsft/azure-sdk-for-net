// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The public IP Address configuration of the networking configuration of a Pool. </summary>
    public partial class PublicIPAddressConfiguration
    {
        /// <summary> Initializes a new instance of PublicIPAddressConfiguration. </summary>
        public PublicIPAddressConfiguration()
        {
            IPAddressIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PublicIPAddressConfiguration. </summary>
        /// <param name="provision"> The default value is BatchManaged. </param>
        /// <param name="ipAddressIds"> The number of IPs specified here limits the maximum size of the Pool - 100 dedicated nodes or 100 Spot/low-priority nodes can be allocated for each public IP. For example, a pool needing 250 dedicated VMs would need at least 3 public IPs specified. Each element of this collection is of the form: /subscriptions/{subscription}/resourceGroups/{group}/providers/Microsoft.Network/publicIPAddresses/{ip}. </param>
        internal PublicIPAddressConfiguration(IPAddressProvisioningType? provision, IList<string> ipAddressIds)
        {
            Provision = provision;
            IPAddressIds = ipAddressIds;
        }

        /// <summary> The default value is BatchManaged. </summary>
        public IPAddressProvisioningType? Provision { get; set; }
        /// <summary> The number of IPs specified here limits the maximum size of the Pool - 100 dedicated nodes or 100 Spot/low-priority nodes can be allocated for each public IP. For example, a pool needing 250 dedicated VMs would need at least 3 public IPs specified. Each element of this collection is of the form: /subscriptions/{subscription}/resourceGroups/{group}/providers/Microsoft.Network/publicIPAddresses/{ip}. </summary>
        public IList<string> IPAddressIds { get; }
    }
}
