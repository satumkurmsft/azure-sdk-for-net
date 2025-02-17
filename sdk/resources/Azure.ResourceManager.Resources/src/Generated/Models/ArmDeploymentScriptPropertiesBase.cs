// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Common properties for the deployment script. </summary>
    internal partial class ArmDeploymentScriptPropertiesBase
    {
        /// <summary> Initializes a new instance of ArmDeploymentScriptPropertiesBase. </summary>
        internal ArmDeploymentScriptPropertiesBase()
        {
        }

        /// <summary> Container settings. </summary>
        internal ContainerConfiguration ContainerSettings { get; }

        /// <summary> Storage Account settings. </summary>
        public ScriptStorageConfiguration StorageAccountSettings { get; }
        /// <summary> The clean up preference when the script execution gets in a terminal state. Default setting is &apos;Always&apos;. </summary>
        public ScriptCleanupOptions? CleanupPreference { get; }
        /// <summary> State of the script execution. This only appears in the response. </summary>
        public ScriptProvisioningState? ProvisioningState { get; }
        /// <summary> Contains the results of script execution. </summary>
        public ScriptStatus Status { get; }
        /// <summary> List of script outputs. </summary>
        public BinaryData Outputs { get; }
    }
}
