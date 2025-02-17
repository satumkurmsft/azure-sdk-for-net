// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class H265Video : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SceneChangeDetection))
            {
                writer.WritePropertyName("sceneChangeDetection");
                writer.WriteBooleanValue(SceneChangeDetection.Value);
            }
            if (Optional.IsDefined(Complexity))
            {
                writer.WritePropertyName("complexity");
                writer.WriteStringValue(Complexity.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers");
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(KeyFrameInterval))
            {
                writer.WritePropertyName("keyFrameInterval");
                writer.WriteStringValue(KeyFrameInterval.Value, "P");
            }
            if (Optional.IsDefined(StretchMode))
            {
                writer.WritePropertyName("stretchMode");
                writer.WriteStringValue(StretchMode.Value.ToString());
            }
            if (Optional.IsDefined(SyncMode))
            {
                writer.WritePropertyName("syncMode");
                writer.WriteStringValue(SyncMode.Value.ToString());
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            writer.WriteEndObject();
        }

        internal static H265Video DeserializeH265Video(JsonElement element)
        {
            Optional<bool> sceneChangeDetection = default;
            Optional<H265Complexity> complexity = default;
            Optional<IList<H265Layer>> layers = default;
            Optional<TimeSpan> keyFrameInterval = default;
            Optional<StretchMode> stretchMode = default;
            Optional<VideoSyncMode> syncMode = default;
            string odataType = default;
            Optional<string> label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sceneChangeDetection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sceneChangeDetection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("complexity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    complexity = new H265Complexity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("layers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<H265Layer> array = new List<H265Layer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(H265Layer.DeserializeH265Layer(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("keyFrameInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stretchMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stretchMode = new StretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("syncMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    syncMode = new VideoSyncMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new H265Video(odataType, label.Value, Optional.ToNullable(keyFrameInterval), Optional.ToNullable(stretchMode), Optional.ToNullable(syncMode), Optional.ToNullable(sceneChangeDetection), Optional.ToNullable(complexity), Optional.ToList(layers));
        }
    }
}
