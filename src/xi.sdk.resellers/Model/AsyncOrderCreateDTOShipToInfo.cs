/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    /// The shipping information provided by the reseller for order delivery.
    /// </summary>
    [DataContract(Name = "AsyncOrderCreateDTO_shipToInfo")]
    public partial class AsyncOrderCreateDTOShipToInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncOrderCreateDTOShipToInfo" /> class.
        /// </summary>
        /// <param name="addressId">The company contact provided by the reseller..</param>
        /// <param name="contact">The contact name for the order will be shipped to..</param>
        /// <param name="companyName">The name of the company the order will be shipped to..</param>
        /// <param name="addressLine1">The address line 1 the order will be shipped to..</param>
        /// <param name="addressLine2">The address line 2 the order will be shipped to..</param>
        /// <param name="addressLine3">The address line 3 the order will be shipped to..</param>
        /// <param name="addressLine4">The address line 4 the order will be shipped to..</param>
        /// <param name="name1">Need description.</param>
        /// <param name="name2">Need description.</param>
        /// <param name="city">The city the order will be shipped to..</param>
        /// <param name="state">The state the order will be shipped to..</param>
        /// <param name="postalCode">The zip or postal code the order will be shipped to..</param>
        /// <param name="countryCode">The two-character ISO country code the order will be shipped to..</param>
        /// <param name="email">The company contact email address..</param>
        /// <param name="shippingNotes">Shipping Notes.</param>
        /// <param name="phoneNumber">Phone number for shipping.</param>
        public AsyncOrderCreateDTOShipToInfo(string addressId = default(string), string contact = default(string), string companyName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressLine4 = default(string), string name1 = default(string), string name2 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string countryCode = default(string), string email = default(string), string shippingNotes = default(string), string phoneNumber = default(string))
        {
            this.AddressId = addressId;
            this.Contact = contact;
            this.CompanyName = companyName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.AddressLine4 = addressLine4;
            this.Name1 = name1;
            this.Name2 = name2;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
            this.Email = email;
            this.ShippingNotes = shippingNotes;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// The company contact provided by the reseller.
        /// </summary>
        /// <value>The company contact provided by the reseller.</value>
        [DataMember(Name = "addressId", EmitDefaultValue = false)]
        public string AddressId { get; set; }

        /// <summary>
        /// The contact name for the order will be shipped to.
        /// </summary>
        /// <value>The contact name for the order will be shipped to.</value>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public string Contact { get; set; }

        /// <summary>
        /// The name of the company the order will be shipped to.
        /// </summary>
        /// <value>The name of the company the order will be shipped to.</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The address line 1 the order will be shipped to.
        /// </summary>
        /// <value>The address line 1 the order will be shipped to.</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The address line 2 the order will be shipped to.
        /// </summary>
        /// <value>The address line 2 the order will be shipped to.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The address line 3 the order will be shipped to.
        /// </summary>
        /// <value>The address line 3 the order will be shipped to.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = true)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The address line 4 the order will be shipped to.
        /// </summary>
        /// <value>The address line 4 the order will be shipped to.</value>
        [DataMember(Name = "addressLine4", EmitDefaultValue = true)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// Need description
        /// </summary>
        /// <value>Need description</value>
        [DataMember(Name = "name1", EmitDefaultValue = false)]
        public string Name1 { get; set; }

        /// <summary>
        /// Need description
        /// </summary>
        /// <value>Need description</value>
        [DataMember(Name = "name2", EmitDefaultValue = false)]
        public string Name2 { get; set; }

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
        /// The company contact email address.
        /// </summary>
        /// <value>The company contact email address.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Shipping Notes
        /// </summary>
        /// <value>Shipping Notes</value>
        [DataMember(Name = "shippingNotes", EmitDefaultValue = false)]
        public string ShippingNotes { get; set; }

        /// <summary>
        /// Phone number for shipping
        /// </summary>
        /// <value>Phone number for shipping</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AsyncOrderCreateDTOShipToInfo {\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressLine4: ").Append(AddressLine4).Append("\n");
            sb.Append("  Name1: ").Append(Name1).Append("\n");
            sb.Append("  Name2: ").Append(Name2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ShippingNotes: ").Append(ShippingNotes).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            yield break;
        }
    }

}
