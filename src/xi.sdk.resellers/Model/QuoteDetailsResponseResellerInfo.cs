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
    /// QuoteDetailsResponseResellerInfo
    /// </summary>
    [DataContract(Name = "QuoteDetailsResponse_resellerInfo")]
    public partial class QuoteDetailsResponseResellerInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsResponseResellerInfo" /> class.
        /// </summary>
        /// <param name="contact">Contact Name.</param>
        /// <param name="companyName">Ingram Micro Customer&#39;s Account Name.</param>
        /// <param name="email">Account Contact Email Address.</param>
        /// <param name="phoneNumber">Account Phone Number.</param>
        /// <param name="customerNumber">Reseller account number.</param>
        public QuoteDetailsResponseResellerInfo(string contact = default(string), string companyName = default(string), string email = default(string), string phoneNumber = default(string), string customerNumber = default(string))
        {
            this.Contact = contact;
            this.CompanyName = companyName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.CustomerNumber = customerNumber;
        }

        /// <summary>
        /// Contact Name
        /// </summary>
        /// <value>Contact Name</value>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public string Contact { get; set; }

        /// <summary>
        /// Ingram Micro Customer&#39;s Account Name
        /// </summary>
        /// <value>Ingram Micro Customer&#39;s Account Name</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Account Contact Email Address
        /// </summary>
        /// <value>Account Contact Email Address</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Account Phone Number
        /// </summary>
        /// <value>Account Phone Number</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Reseller account number
        /// </summary>
        /// <value>Reseller account number</value>
        [DataMember(Name = "customerNumber", EmitDefaultValue = false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsResponseResellerInfo {\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
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
