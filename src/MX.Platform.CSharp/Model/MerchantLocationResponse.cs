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
    /// MerchantLocationResponse
    /// </summary>
    [DataContract(Name = "MerchantLocationResponse")]
    public partial class MerchantLocationResponse : IEquatable<MerchantLocationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantLocationResponse" /> class.
        /// </summary>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="guid">guid.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="merchantGuid">merchantGuid.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="state">state.</param>
        /// <param name="streetAddress">streetAddress.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public MerchantLocationResponse(string city = default(string), string country = default(string), string createdAt = default(string), string guid = default(string), decimal? latitude = default(decimal?), decimal? longitude = default(decimal?), string merchantGuid = default(string), string phoneNumber = default(string), string postalCode = default(string), string state = default(string), string streetAddress = default(string), string updatedAt = default(string))
        {
            this.City = city;
            this.Country = country;
            this.CreatedAt = createdAt;
            this.Guid = guid;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.MerchantGuid = merchantGuid;
            this.PhoneNumber = phoneNumber;
            this.PostalCode = postalCode;
            this.State = state;
            this.StreetAddress = streetAddress;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        /// <example>Greenwood Village</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        /// <example>US</example>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2020-04-13 21:05:09.000000000 Z</example>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        /// <example>MCL-00024e59-18b5-4d79-b879-2a7896726fea</example>
        [DataMember(Name = "guid", EmitDefaultValue = true)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        /// <example>39.5963005</example>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        /// <example>-104.89158799999998</example>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets MerchantGuid
        /// </summary>
        /// <example>MCH-09466f0a-fb58-9d1a-bae2-2af0afbea621</example>
        [DataMember(Name = "merchant_guid", EmitDefaultValue = true)]
        public string MerchantGuid { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        /// <example>(303) 689-0728</example>
        [DataMember(Name = "phone_number", EmitDefaultValue = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        /// <example>801121436</example>
        [DataMember(Name = "postal_code", EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        /// <example>CO</example>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        /// <example>8547 E Arapahoe Rd, Ste 1</example>
        [DataMember(Name = "street_address", EmitDefaultValue = true)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// <example>2020-04-13 21:05:09.000000000 Z</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantLocationResponse {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  MerchantGuid: ").Append(MerchantGuid).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as MerchantLocationResponse);
        }

        /// <summary>
        /// Returns true if MerchantLocationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantLocationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantLocationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.MerchantGuid == input.MerchantGuid ||
                    (this.MerchantGuid != null &&
                    this.MerchantGuid.Equals(input.MerchantGuid))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.MerchantGuid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantGuid.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.StreetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StreetAddress.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
