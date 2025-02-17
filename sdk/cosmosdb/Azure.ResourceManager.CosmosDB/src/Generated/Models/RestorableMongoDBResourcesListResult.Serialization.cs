// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class RestorableMongoDBResourcesListResult
    {
        internal static RestorableMongoDBResourcesListResult DeserializeRestorableMongoDBResourcesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DatabaseRestoreResourceInfo>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DatabaseRestoreResourceInfo> array = new List<DatabaseRestoreResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatabaseRestoreResourceInfo.DeserializeDatabaseRestoreResourceInfo(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RestorableMongoDBResourcesListResult(Optional.ToList(value));
        }
    }
}
