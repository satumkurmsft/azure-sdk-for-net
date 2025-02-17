// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ManagedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId");
                writer.WriteStringValue(PrincipalId);
            }
            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(IdentityType);
            }
            if (Optional.IsDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UserAssignedIdentities);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(UserAssignedIdentities.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ManagedIdentity DeserializeManagedIdentity(JsonElement element)
        {
            Optional<Guid> tenantId = default;
            Optional<string> principalId = default;
            Optional<string> type = default;
            Optional<BinaryData> userAssignedIdentities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalId"))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    userAssignedIdentities = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new ManagedIdentity(Optional.ToNullable(tenantId), principalId.Value, type.Value, userAssignedIdentities.Value);
        }
    }
}
