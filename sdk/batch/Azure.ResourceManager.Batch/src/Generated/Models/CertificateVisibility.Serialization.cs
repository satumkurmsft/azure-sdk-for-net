// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class CertificateVisibilityExtensions
    {
        public static string ToSerialString(this CertificateVisibility value) => value switch
        {
            CertificateVisibility.StartTask => "StartTask",
            CertificateVisibility.Task => "Task",
            CertificateVisibility.RemoteUser => "RemoteUser",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CertificateVisibility value.")
        };

        public static CertificateVisibility ToCertificateVisibility(this string value)
        {
            if (string.Equals(value, "StartTask", StringComparison.InvariantCultureIgnoreCase)) return CertificateVisibility.StartTask;
            if (string.Equals(value, "Task", StringComparison.InvariantCultureIgnoreCase)) return CertificateVisibility.Task;
            if (string.Equals(value, "RemoteUser", StringComparison.InvariantCultureIgnoreCase)) return CertificateVisibility.RemoteUser;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CertificateVisibility value.");
        }
    }
}
