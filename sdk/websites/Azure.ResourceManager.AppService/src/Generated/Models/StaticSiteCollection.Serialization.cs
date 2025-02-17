// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class StaticSiteCollection
    {
        internal static StaticSiteCollection DeserializeStaticSiteCollection(JsonElement element)
        {
            IReadOnlyList<StaticSiteARMData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<StaticSiteARMData> array = new List<StaticSiteARMData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticSiteARMData.DeserializeStaticSiteARMData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new StaticSiteCollection(value, nextLink.Value);
        }
    }
}
