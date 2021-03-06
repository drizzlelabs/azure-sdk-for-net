// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class for EnvelopeEncryption encryption scheme
    /// </summary>
    public partial class EnvelopeEncryption
    {
        /// <summary>
        /// Initializes a new instance of the EnvelopeEncryption class.
        /// </summary>
        public EnvelopeEncryption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnvelopeEncryption class.
        /// </summary>
        /// <param name="enabledProtocols">Representing supported
        /// protocols</param>
        /// <param name="clearTracks">Representing which tracks should not be
        /// encrypted</param>
        /// <param name="contentKeys">Representing default content key for each
        /// encryption scheme and separate content keys for specific
        /// tracks</param>
        /// <param
        /// name="customLicenseAcquisitionUrlTemplate">LicenseAcquistionUrlTemplate
        /// is used to point to user speicified service to delivery content
        /// keys</param>
        public EnvelopeEncryption(EnabledProtocols enabledProtocols = default(EnabledProtocols), IList<TrackSelection> clearTracks = default(IList<TrackSelection>), StreamingPolicyContentKeys contentKeys = default(StreamingPolicyContentKeys), string customLicenseAcquisitionUrlTemplate = default(string))
        {
            EnabledProtocols = enabledProtocols;
            ClearTracks = clearTracks;
            ContentKeys = contentKeys;
            CustomLicenseAcquisitionUrlTemplate = customLicenseAcquisitionUrlTemplate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets representing supported protocols
        /// </summary>
        [JsonProperty(PropertyName = "enabledProtocols")]
        public EnabledProtocols EnabledProtocols { get; set; }

        /// <summary>
        /// Gets or sets representing which tracks should not be encrypted
        /// </summary>
        [JsonProperty(PropertyName = "clearTracks")]
        public IList<TrackSelection> ClearTracks { get; set; }

        /// <summary>
        /// Gets or sets representing default content key for each encryption
        /// scheme and separate content keys for specific tracks
        /// </summary>
        [JsonProperty(PropertyName = "contentKeys")]
        public StreamingPolicyContentKeys ContentKeys { get; set; }

        /// <summary>
        /// Gets or sets licenseAcquistionUrlTemplate is used to point to user
        /// speicified service to delivery content keys
        /// </summary>
        [JsonProperty(PropertyName = "customLicenseAcquisitionUrlTemplate")]
        public string CustomLicenseAcquisitionUrlTemplate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EnabledProtocols != null)
            {
                EnabledProtocols.Validate();
            }
        }
    }
}
