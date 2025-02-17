// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ConfigServerProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error");
                writer.WriteObjectValue(Error);
            }
            if (Optional.IsDefined(ConfigServer))
            {
                writer.WritePropertyName("configServer");
                writer.WriteObjectValue(ConfigServer);
            }
            writer.WriteEndObject();
        }

        internal static ConfigServerProperties DeserializeConfigServerProperties(JsonElement element)
        {
            Optional<ConfigServerState> provisioningState = default;
            Optional<AppPlatformErrorInfo> error = default;
            Optional<ConfigServerSettings> configServer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ConfigServerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = AppPlatformErrorInfo.DeserializeAppPlatformErrorInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("configServer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    configServer = ConfigServerSettings.DeserializeConfigServerSettings(property.Value);
                    continue;
                }
            }
            return new ConfigServerProperties(Optional.ToNullable(provisioningState), error.Value, configServer.Value);
        }
    }
}
