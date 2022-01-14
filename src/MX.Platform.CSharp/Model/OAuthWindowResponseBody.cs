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
    /// OAuthWindowResponseBody
    /// </summary>
    [DataContract(Name = "OAuthWindowResponseBody")]
    public partial class OAuthWindowResponseBody : IEquatable<OAuthWindowResponseBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthWindowResponseBody" /> class.
        /// </summary>
        /// <param name="member">member.</param>
        public OAuthWindowResponseBody(OAuthWindowResponse member = default(OAuthWindowResponse))
        {
            this.Member = member;
        }

        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name = "member", EmitDefaultValue = false)]
        public OAuthWindowResponse Member { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthWindowResponseBody {\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
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
            return this.Equals(input as OAuthWindowResponseBody);
        }

        /// <summary>
        /// Returns true if OAuthWindowResponseBody instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthWindowResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthWindowResponseBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Member == input.Member ||
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
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
                if (this.Member != null)
                {
                    hashCode = (hashCode * 59) + this.Member.GetHashCode();
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
