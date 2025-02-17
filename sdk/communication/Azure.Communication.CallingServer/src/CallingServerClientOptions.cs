﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net.Http;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallingServer
{
    /// <summary>
    /// The latest version of the Calling Server.
    /// </summary>
    public class CallingServerClientOptions : ClientOptions
    {
        /// <summary>
        /// The latest version of the CallingServer service.
        /// </summary>
        internal const ServiceVersion LatestVersion = ServiceVersion.V2022_04_07_Preview;

        internal string ApiVersion { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallingServerClientOptions"/>.
        /// </summary>
        public CallingServerClientOptions(ServiceVersion version = LatestVersion)
        {
            ApiVersion = version switch
            {
                ServiceVersion.V2022_04_07_Preview => "2022-04-07-preview",
                _ => throw new ArgumentOutOfRangeException(nameof(version)),
            };
        }

        /// <summary>
        /// The CallingServer service version.
        /// </summary>
        public enum ServiceVersion
        {
            /// <summary>
            /// The Beta of the CallingServer service.
            /// </summary>
#pragma warning disable CA1707 // Identifiers should not contain underscores
            V2022_04_07_Preview = 1
#pragma warning restore CA1707 // Identifiers should not contain underscores
        }
    }
}
