/*
 * XI Sdk Resellers
 *
 * For Resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    [DataContract(Name = "OrderCreateV7Response_resource_shipToInfo")]
    public partial class OrderCreateV7ResponseResourceShipToInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateV7ResponseResourceShipToInfo" /> class.
        /// </summary>
        /// <param name="addressId">The ID references the resellers address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process..</param>
        /// <param name="companyName">The reseller&#39;s company name or the End-User&#39;s Name.</param>
        /// <param name="addressLine1">The street address and building or house number the order will be shipped to..</param>
        /// <param name="addressLine2">The apartment number the order will be shipped to..</param>
        /// <param name="city">The city the order will be shipped to..</param>
        /// <param name="state">The state the order will be shipped to..</param>
        /// <param name="postalCode">The zip or postal code the order will be shipped to..</param>
        /// <param name="countryCode">The two-character ISO country code the order will be shipped to..</param>
        public OrderCreateV7ResponseResourceShipToInfo(string addressId = default(string), string companyName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string countryCode = default(string))
        {
            this.AddressId = addressId;
            this.CompanyName = companyName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// The ID references the resellers address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process.
        /// </summary>
        /// <value>The ID references the resellers address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process.</value>
        [DataMember(Name = "addressId", EmitDefaultValue = false)]
        public string AddressId { get; set; }

        /// <summary>
        /// The reseller&#39;s company name or the End-User&#39;s Name
        /// </summary>
        /// <value>The reseller&#39;s company name or the End-User&#39;s Name</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateV7ResponseResourceShipToInfo {\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
