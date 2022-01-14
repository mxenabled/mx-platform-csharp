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
    /// InstitutionResponseBody
    /// </summary>
    [DataContract(Name = "InstitutionResponseBody")]
    public partial class InstitutionResponseBody : IEquatable<InstitutionResponseBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionResponseBody" /> class.
        /// </summary>
        /// <param name="institution">institution.</param>
        public InstitutionResponseBody(InstitutionResponse institution = default(InstitutionResponse))
        {
            this.Institution = institution;
        }

        /// <summary>
        /// Gets or Sets Institution
        /// </summary>
        [DataMember(Name = "institution", EmitDefaultValue = false)]
        public InstitutionResponse Institution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstitutionResponseBody {\n");
            sb.Append("  Institution: ").Append(Institution).Append("\n");
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
            return this.Equals(input as InstitutionResponseBody);
        }

        /// <summary>
        /// Returns true if InstitutionResponseBody instances are equal
        /// </summary>
        /// <param name="input">Instance of InstitutionResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstitutionResponseBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Institution == input.Institution ||
                    (this.Institution != null &&
                    this.Institution.Equals(input.Institution))
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
                if (this.Institution != null)
                {
                    hashCode = (hashCode * 59) + this.Institution.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
