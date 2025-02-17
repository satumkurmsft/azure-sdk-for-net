// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base class for specifying a clip time. Use sub classes of this class to specify the time position in the media.
    /// Please note <see cref="ClipTime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AbsoluteClipTime"/> and <see cref="UtcClipTime"/>.
    /// </summary>
    public partial class ClipTime
    {
        /// <summary> Initializes a new instance of ClipTime. </summary>
        public ClipTime()
        {
        }

        /// <summary> Initializes a new instance of ClipTime. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal ClipTime(string odataType)
        {
            OdataType = odataType;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}
