/*
 * Reseller API
 *
 * For Resellers. <br> Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 6.0
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
    /// QuoteDetailsRequestQuoteProductsRequestRequestpreamble
    /// </summary>
    [DataContract(Name = "quoteDetailsRequest_quoteProductsRequest_requestpreamble")]
    public partial class QuoteDetailsRequestQuoteProductsRequestRequestpreamble : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsRequestQuoteProductsRequestRequestpreamble" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteDetailsRequestQuoteProductsRequestRequestpreamble() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsRequestQuoteProductsRequestRequestpreamble" /> class.
        /// </summary>
        /// <param name="customerNumber">Reseller Number (referred to as the account BCN) is the unique identifier for an Ingram Micro customer account. (required).</param>
        /// <param name="isoCountryCode">The ISO country codes are internationally recognized codes designated for each country represented by a two-letter combination (alpha-2). (required).</param>
        public QuoteDetailsRequestQuoteProductsRequestRequestpreamble(string customerNumber = default(string), string isoCountryCode = default(string))
        {
            // to ensure "customerNumber" is required (not null)
            if (customerNumber == null)
            {
                throw new ArgumentNullException("customerNumber is a required property for QuoteDetailsRequestQuoteProductsRequestRequestpreamble and cannot be null");
            }
            this.CustomerNumber = customerNumber;
            // to ensure "isoCountryCode" is required (not null)
            if (isoCountryCode == null)
            {
                throw new ArgumentNullException("isoCountryCode is a required property for QuoteDetailsRequestQuoteProductsRequestRequestpreamble and cannot be null");
            }
            this.IsoCountryCode = isoCountryCode;
        }

        /// <summary>
        /// Reseller Number (referred to as the account BCN) is the unique identifier for an Ingram Micro customer account.
        /// </summary>
        /// <value>Reseller Number (referred to as the account BCN) is the unique identifier for an Ingram Micro customer account.</value>
        [DataMember(Name = "customerNumber", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// The ISO country codes are internationally recognized codes designated for each country represented by a two-letter combination (alpha-2).
        /// </summary>
        /// <value>The ISO country codes are internationally recognized codes designated for each country represented by a two-letter combination (alpha-2).</value>
        [DataMember(Name = "isoCountryCode", IsRequired = true, EmitDefaultValue = true)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsRequestQuoteProductsRequestRequestpreamble {\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
            sb.Append("  IsoCountryCode: ").Append(IsoCountryCode).Append("\n");
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
