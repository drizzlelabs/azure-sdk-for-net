// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resource.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// List of subscription tags.
    /// </summary>
    public partial class TagsListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the TagsListResultInner class.
        /// </summary>
        public TagsListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the TagsListResultInner class.
        /// </summary>
        /// <param name="nextLink">The URL to get the next set of
        /// results.</param>
        /// <param name="value">The list of tags.</param>
        public TagsListResultInner(string nextLink, System.Collections.Generic.IList<TagDetailsInner> value = default(System.Collections.Generic.IList<TagDetailsInner>))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets the list of tags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<TagDetailsInner> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NextLink == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "NextLink");
            }
        }
    }
}