/*
 * XI SDK Resellers
 *
 * For Resellers. Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 1.0.0
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
using FileParameter = xi.sdk.resellers.Client.FileParameter;
using OpenAPIDateConverter = xi.sdk.resellers.Client.OpenAPIDateConverter;

namespace xi.sdk.resellers.Model
{
    /// <summary>
    /// The shipping information provided by the reseller.
    /// </summary>
    [DataContract(Name = "OrderCreateRequest_shipToInfo")]
    public partial class OrderCreateRequestShipToInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestShipToInfo" /> class.
        /// </summary>
        /// <param name="addressId">The ID references the resellers address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process..</param>
        /// <param name="contact">The company contact provided by the reseller..</param>
        /// <param name="companyName">The name of the company the order will be shipped to..</param>
        /// <param name="name1">name1.</param>
        /// <param name="name2">name2.</param>
        /// <param name="addressLine1">The street address and building or house number the order will be shipped to..</param>
        /// <param name="addressLine2">The apartment number the order will be shipped to..</param>
        /// <param name="addressLine3">Line 3 of the address the order will be shipped to..</param>
        /// <param name="addressLine4">Street address4.</param>
        /// <param name="city">The city the order will be shipped to..</param>
        /// <param name="state">The state the order will be shipped to..</param>
        /// <param name="postalCode">The zip or postal code the order will be shipped to..</param>
        /// <param name="countryCode">The two-character ISO country code the order will be shipped to..</param>
        /// <param name="phoneNumber">The company contact phone number..</param>
        /// <param name="email">The company contact email address..</param>
        public OrderCreateRequestShipToInfo(string addressId = default(string), string contact = default(string), string companyName = default(string), string name1 = default(string), string name2 = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressLine4 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string countryCode = default(string), string phoneNumber = default(string), string email = default(string))
        {
            this.AddressId = addressId;
            this.Contact = contact;
            this.CompanyName = companyName;
            this.Name1 = name1;
            this.Name2 = name2;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.AddressLine4 = addressLine4;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        /// <summary>
        /// The ID references the resellers address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process.
        /// </summary>
        /// <value>The ID references the resellers address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process.</value>
        [DataMember(Name = "addressId", EmitDefaultValue = false)]
        public string AddressId { get; set; }

        /// <summary>
        /// The company contact provided by the reseller.
        /// </summary>
        /// <value>The company contact provided by the reseller.</value>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public string Contact { get; set; }

        /// <summary>
        /// The name of the company the order will be shipped to.
        /// </summary>
        /// <value>The name of the company the order will be shipped to.</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// name1
        /// </summary>
        /// <value>name1</value>
        [DataMember(Name = "name1", EmitDefaultValue = false)]
        public string Name1 { get; set; }

        /// <summary>
        /// name2
        /// </summary>
        /// <value>name2</value>
        [DataMember(Name = "name2", EmitDefaultValue = false)]
        public string Name2 { get; set; }

        /// <summary>
        /// The street address and building or house number the order will be shipped to.
        /// </summary>
        /// <value>The street address and building or house number the order will be shipped to.</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The apartment number the order will be shipped to.
        /// </summary>
        /// <value>The apartment number the order will be shipped to.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Line 3 of the address the order will be shipped to.
        /// </summary>
        /// <value>Line 3 of the address the order will be shipped to.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Street address4
        /// </summary>
        /// <value>Street address4</value>
        [DataMember(Name = "addressLine4", EmitDefaultValue = false)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// The city the order will be shipped to.
        /// </summary>
        /// <value>The city the order will be shipped to.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The state the order will be shipped to.
        /// </summary>
        /// <value>The state the order will be shipped to.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The zip or postal code the order will be shipped to.
        /// </summary>
        /// <value>The zip or postal code the order will be shipped to.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two-character ISO country code the order will be shipped to.
        /// </summary>
        /// <value>The two-character ISO country code the order will be shipped to.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The company contact phone number.
        /// </summary>
        /// <value>The company contact phone number.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The company contact email address.
        /// </summary>
        /// <value>The company contact email address.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequestShipToInfo {\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Name1: ").Append(Name1).Append("\n");
            sb.Append("  Name2: ").Append(Name2).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressLine4: ").Append(AddressLine4).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // AddressId (string) maxLength
            if (this.AddressId != null && this.AddressId.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressId, length must be less than 10.", new [] { "AddressId" });
            }

            // Contact (string) maxLength
            if (this.Contact != null && this.Contact.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contact, length must be less than 70.", new [] { "Contact" });
            }

            // CompanyName (string) maxLength
            if (this.CompanyName != null && this.CompanyName.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be less than 40.", new [] { "CompanyName" });
            }

            // AddressLine1 (string) maxLength
            if (this.AddressLine1 != null && this.AddressLine1.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine1, length must be less than 70.", new [] { "AddressLine1" });
            }

            // AddressLine2 (string) maxLength
            if (this.AddressLine2 != null && this.AddressLine2.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine2, length must be less than 70.", new [] { "AddressLine2" });
            }

            // AddressLine3 (string) maxLength
            if (this.AddressLine3 != null && this.AddressLine3.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine3, length must be less than 70.", new [] { "AddressLine3" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 25.", new [] { "City" });
            }

            // State (string) maxLength
            if (this.State != null && this.State.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be less than 3.", new [] { "State" });
            }

            // PostalCode (string) maxLength
            if (this.PostalCode != null && this.PostalCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 10.", new [] { "PostalCode" });
            }

            // CountryCode (string) maxLength
            if (this.CountryCode != null && this.CountryCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 10.", new [] { "CountryCode" });
            }

            yield break;
        }
    }

}
