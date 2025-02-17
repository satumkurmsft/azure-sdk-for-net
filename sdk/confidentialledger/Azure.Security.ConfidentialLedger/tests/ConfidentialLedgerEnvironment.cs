﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;

namespace Azure.Security.ConfidentialLedger.Tests
{
    public class ConfidentialLedgerEnvironment : TestEnvironment
    {
        public Uri ConfidentialLedgerUrl => new(GetRecordedVariable("CONFIDENTIALLEDGER_URL"));
        public Uri ConfidentialLedgerIdentityUrl => new(GetRecordedVariable("CONFIDENTIALLEDGER_IDENTITY_URL"));
        public string ConfidentialLedgerAdminOid => GetRecordedVariable("CONFIDENTIALLEDGER_CLIENT_OBJECTID");
        public string ClientPEM => GetRecordedOptionalVariable("CONFIDENTIALLEDGER_CLIENT_PEM");
        public string ClientPEMPk => GetRecordedOptionalVariable("CONFIDENTIALLEDGER_CLIENT_PEM_PK");
    }
}
