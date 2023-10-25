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
    /// TagResponse
    /// </summary>
    [DataContract(Name = "TagResponse")]
    public partial class TagResponse : IEquatable<TagResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagResponse" /> class.
        /// </summary>
        /// <param name="guid">guid.</param>
        /// <param name="name">name.</param>
        /// <param name="userGuid">userGuid.</param>
        public TagResponse(string guid = default(string), string name = default(string), string userGuid = default(string))
        {
            this.Guid = guid;
            this.Name = name;
            this.UserGuid = userGuid;
        }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        /// <example>TAG-aef36e72-6294-4c38-844d-e573e80aed52</example>
        [DataMember(Name = "guid", EmitDefaultValue = true)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>MY TAG</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets UserGuid
        /// </summary>
        /// <example>USR-11141024-90b3-1bce-cac9-c06ced52ab4c</example>
        [DataMember(Name = "user_guid", EmitDefaultValue = true)]
        public string UserGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TagResponse {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserGuid: ").Append(UserGuid).Append("\n");
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
            return this.Equals(input as TagResponse);
        }

        /// <summary>
        /// Returns true if TagResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TagResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UserGuid == input.UserGuid ||
                    (this.UserGuid != null &&
                    this.UserGuid.Equals(input.UserGuid))
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
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.UserGuid != null)
                {
                    hashCode = (hashCode * 59) + this.UserGuid.GetHashCode();
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
