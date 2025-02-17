// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The result of a name availability check. </summary>
    public partial class SqlNameAvailabilityResponse
    {
        /// <summary> Initializes a new instance of SqlNameAvailabilityResponse. </summary>
        internal SqlNameAvailabilityResponse()
        {
        }

        /// <summary> Initializes a new instance of SqlNameAvailabilityResponse. </summary>
        /// <param name="name"> The name whose availability was checked. </param>
        /// <param name="isAvailable"> True if the name is available, otherwise false. </param>
        /// <param name="reason"> The reason code explaining why the name is unavailable. Will be undefined if the name is available. </param>
        /// <param name="message"> A message explaining why the name is unavailable. Will be undefined if the name is available. </param>
        internal SqlNameAvailabilityResponse(string name, bool? isAvailable, SqlNameUnavailableReason? reason, string message)
        {
            Name = name;
            IsAvailable = isAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> The name whose availability was checked. </summary>
        public string Name { get; }
        /// <summary> True if the name is available, otherwise false. </summary>
        public bool? IsAvailable { get; }
        /// <summary> The reason code explaining why the name is unavailable. Will be undefined if the name is available. </summary>
        public SqlNameUnavailableReason? Reason { get; }
        /// <summary> A message explaining why the name is unavailable. Will be undefined if the name is available. </summary>
        public string Message { get; }
    }
}
