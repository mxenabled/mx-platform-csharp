/*
 * MX Platform API
 *
 * The MX Platform API is a powerful, fully-featured API designed to make aggregating and enhancing financial data easy and reliable. It can seamlessly connect your app or website to tens of thousands of financial institutions.
 *
 * The version of the OpenAPI document: 0.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = MX.Platform.CSharp.Client.OpenAPIDateConverter;

namespace MX.Platform.CSharp.Model
{
    /// <summary>
    /// ImageOptionResponse
    /// </summary>
    [DataContract(Name = "ImageOptionResponse")]
    public partial class ImageOptionResponse : IEquatable<ImageOptionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageOptionResponse" /> class.
        /// </summary>
        /// <param name="dataUri">dataUri.</param>
        /// <param name="guid">guid.</param>
        /// <param name="label">label.</param>
        /// <param name="value">value.</param>
        public ImageOptionResponse(string dataUri = default(string), string guid = default(string), string label = default(string), string value = default(string))
        {
            this.DataUri = dataUri;
            this.Guid = guid;
            this.Label = label;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets DataUri
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgoAAAANSUh ... more image data ...</example>
        [DataMember(Name = "data_uri", EmitDefaultValue = true)]
        public string DataUri { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        /// <example>CRO-e7ecc864-61fd-47a6-a122-3cbc9016660d</example>
        [DataMember(Name = "guid", EmitDefaultValue = true)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        /// <example>IMAGE_1</example>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        /// <example>image_data</example>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImageOptionResponse {\n");
            sb.Append("  DataUri: ").Append(DataUri).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageOptionResponse);
        }

        /// <summary>
        /// Returns true if ImageOptionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageOptionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageOptionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataUri == input.DataUri ||
                    (this.DataUri != null &&
                    this.DataUri.Equals(input.DataUri))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DataUri != null)
                {
                    hashCode = (hashCode * 59) + this.DataUri.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
