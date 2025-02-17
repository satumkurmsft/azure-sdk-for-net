// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class AzureResourceReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceArmResourceId");
            writer.WriteStringValue(SourceArmResourceId);
            writer.WriteEndObject();
        }

        internal static AzureResourceReference DeserializeAzureResourceReference(JsonElement element)
        {
            string sourceArmResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceArmResourceId"))
                {
                    sourceArmResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new AzureResourceReference(sourceArmResourceId);
        }
    }
}
