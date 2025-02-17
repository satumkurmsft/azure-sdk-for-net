// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Parameters allowed to update for a server. </summary>
    public partial class MySqlFlexibleServerPatch
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerPatch. </summary>
        public MySqlFlexibleServerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The cmk identity for the server. </summary>
        public Identity Identity { get; set; }
        /// <summary> The SKU (pricing tier) of the server. </summary>
        public MySqlFlexibleServerSku Sku { get; set; }
        /// <summary> Application-specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The password of the administrator login. </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> Storage related properties of a server. </summary>
        public MySqlFlexibleServerStorage Storage { get; set; }
        /// <summary> Backup related properties of a server. </summary>
        public MySqlFlexibleServerBackupProperties Backup { get; set; }
        /// <summary> High availability related properties of a server. </summary>
        public MySqlFlexibleServerHighAvailability HighAvailability { get; set; }
        /// <summary> Maintenance window of a server. </summary>
        public MySqlFlexibleServerMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary> The replication role of the server. </summary>
        public MySqlFlexibleServerReplicationRole? ReplicationRole { get; set; }
        /// <summary> The Data Encryption for CMK. </summary>
        public MySqlFlexibleServerDataEncryption DataEncryption { get; set; }
    }
}
