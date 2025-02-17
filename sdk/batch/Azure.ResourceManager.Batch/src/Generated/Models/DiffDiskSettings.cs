// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine. </summary>
    internal partial class DiffDiskSettings
    {
        /// <summary> Initializes a new instance of DiffDiskSettings. </summary>
        public DiffDiskSettings()
        {
        }

        /// <summary> Initializes a new instance of DiffDiskSettings. </summary>
        /// <param name="placement"> This property can be used by user in the request to choose which location the operating system should be in. e.g., cache disk space for Ephemeral OS disk provisioning. For more information on Ephemeral OS disk size requirements, please refer to Ephemeral OS disk size requirements for Windows VMs at https://docs.microsoft.com/en-us/azure/virtual-machines/windows/ephemeral-os-disks#size-requirements and Linux VMs at https://docs.microsoft.com/en-us/azure/virtual-machines/linux/ephemeral-os-disks#size-requirements. </param>
        internal DiffDiskSettings(DiffDiskPlacement? placement)
        {
            Placement = placement;
        }

        /// <summary> This property can be used by user in the request to choose which location the operating system should be in. e.g., cache disk space for Ephemeral OS disk provisioning. For more information on Ephemeral OS disk size requirements, please refer to Ephemeral OS disk size requirements for Windows VMs at https://docs.microsoft.com/en-us/azure/virtual-machines/windows/ephemeral-os-disks#size-requirements and Linux VMs at https://docs.microsoft.com/en-us/azure/virtual-machines/linux/ephemeral-os-disks#size-requirements. </summary>
        public DiffDiskPlacement? Placement { get; set; }
    }
}
