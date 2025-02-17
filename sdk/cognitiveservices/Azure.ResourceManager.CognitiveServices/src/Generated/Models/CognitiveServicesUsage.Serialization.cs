// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesUsage
    {
        internal static CognitiveServicesUsage DeserializeCognitiveServicesUsage(JsonElement element)
        {
            Optional<UnitType> unit = default;
            Optional<MetricName> name = default;
            Optional<string> quotaPeriod = default;
            Optional<double> limit = default;
            Optional<double> currentValue = default;
            Optional<string> nextResetTime = default;
            Optional<QuotaUsageStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unit = new UnitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = MetricName.DeserializeMetricName(property.Value);
                    continue;
                }
                if (property.NameEquals("quotaPeriod"))
                {
                    quotaPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    limit = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("nextResetTime"))
                {
                    nextResetTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new QuotaUsageStatus(property.Value.GetString());
                    continue;
                }
            }
            return new CognitiveServicesUsage(Optional.ToNullable(unit), name.Value, quotaPeriod.Value, Optional.ToNullable(limit), Optional.ToNullable(currentValue), nextResetTime.Value, Optional.ToNullable(status));
        }
    }
}
