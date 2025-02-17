// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DiskRestorePointReplicationStatus
    {
        internal static DiskRestorePointReplicationStatus DeserializeDiskRestorePointReplicationStatus(JsonElement element)
        {
            Optional<InstanceViewStatus> status = default;
            Optional<int> completionPercent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("completionPercent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    completionPercent = property.Value.GetInt32();
                    continue;
                }
            }
            return new DiskRestorePointReplicationStatus(status.Value, Optional.ToNullable(completionPercent));
        }
    }
}
