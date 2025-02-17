// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
    internal partial class MetricRules
    {
        /// <summary> Initializes a new instance of MetricRules. </summary>
        public MetricRules()
        {
            FilteringTags = new ChangeTrackingList<FilteringTag>();
        }

        /// <summary> Initializes a new instance of MetricRules. </summary>
        /// <param name="filteringTags"> List of filtering tags to be used for capturing metrics. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags. </param>
        internal MetricRules(IList<FilteringTag> filteringTags)
        {
            FilteringTags = filteringTags;
        }

        /// <summary> List of filtering tags to be used for capturing metrics. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags. </summary>
        public IList<FilteringTag> FilteringTags { get; }
    }
}
