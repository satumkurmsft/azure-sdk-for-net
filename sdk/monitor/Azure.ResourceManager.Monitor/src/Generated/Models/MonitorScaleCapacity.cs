// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The number of instances that can be used during this profile. </summary>
    public partial class MonitorScaleCapacity
    {
        /// <summary> Initializes a new instance of MonitorScaleCapacity. </summary>
        /// <param name="minimum"> the minimum number of instances for the resource. </param>
        /// <param name="maximum"> the maximum number of instances for the resource. The actual maximum number of instances is limited by the cores that are available in the subscription. </param>
        /// <param name="default"> the number of instances that will be set if metrics are not available for evaluation. The default is only used if the current instance count is lower than the default. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="minimum"/>, <paramref name="maximum"/> or <paramref name="default"/> is null. </exception>
        public MonitorScaleCapacity(string minimum, string maximum, string @default)
        {
            if (minimum == null)
            {
                throw new ArgumentNullException(nameof(minimum));
            }
            if (maximum == null)
            {
                throw new ArgumentNullException(nameof(maximum));
            }
            if (@default == null)
            {
                throw new ArgumentNullException(nameof(@default));
            }

            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
        }

        /// <summary> the minimum number of instances for the resource. </summary>
        public string Minimum { get; set; }
        /// <summary> the maximum number of instances for the resource. The actual maximum number of instances is limited by the cores that are available in the subscription. </summary>
        public string Maximum { get; set; }
        /// <summary> the number of instances that will be set if metrics are not available for evaluation. The default is only used if the current instance count is lower than the default. </summary>
        public string Default { get; set; }
    }
}
