// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx. </summary>
    public enum CertificateFormat
    {
        /// <summary> The certificate is a PFX (PKCS#12) formatted certificate or certificate chain. </summary>
        Pfx,
        /// <summary> The certificate is a base64-encoded X.509 certificate. </summary>
        Cer
    }
}
