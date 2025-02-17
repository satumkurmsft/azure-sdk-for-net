// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClientCertificateThumbprint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("isAdmin");
            writer.WriteBooleanValue(IsAdmin);
            writer.WritePropertyName("certificateThumbprint");
            writer.WriteStringValue(CertificateThumbprint);
            writer.WriteEndObject();
        }

        internal static ClientCertificateThumbprint DeserializeClientCertificateThumbprint(JsonElement element)
        {
            bool isAdmin = default;
            string certificateThumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAdmin"))
                {
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificateThumbprint"))
                {
                    certificateThumbprint = property.Value.GetString();
                    continue;
                }
            }
            return new ClientCertificateThumbprint(isAdmin, certificateThumbprint);
        }
    }
}
