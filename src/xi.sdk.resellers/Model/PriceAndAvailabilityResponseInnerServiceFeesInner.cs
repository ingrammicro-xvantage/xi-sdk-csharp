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
    /// PriceAndAvailabilityResponseInnerServiceFeesInner
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityResponse_inner_serviceFees_inner")]
    public partial class PriceAndAvailabilityResponseInnerServiceFeesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityResponseInnerServiceFeesInner" /> class.
        /// </summary>
        /// <param name="conditionType">Condition Type of the service fees..</param>
        /// <param name="description">Description of the service fees..</param>
        /// <param name="amount">Amount of the service fees..</param>
        /// <param name="endDate">End Date of the service fees..</param>
        /// <param name="currencyCode">Currency Code of the service fees..</param>
        public PriceAndAvailabilityResponseInnerServiceFeesInner(string conditionType = default(string), string description = default(string), decimal amount = default(decimal), string endDate = default(string), string currencyCode = default(string))
        {
            this.ConditionType = conditionType;
            this.Description = description;
            this.Amount = amount;
            this.EndDate = endDate;
            this.CurrencyCode = currencyCode;
        }

        /// <summary>
        /// Condition Type of the service fees.
        /// </summary>
        /// <value>Condition Type of the service fees.</value>
        [DataMember(Name = "conditionType", EmitDefaultValue = false)]
        public string ConditionType { get; set; }

        /// <summary>
        /// Description of the service fees.
        /// </summary>
        /// <value>Description of the service fees.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Amount of the service fees.
        /// </summary>
        /// <value>Amount of the service fees.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// End Date of the service fees.
        /// </summary>
        /// <value>End Date of the service fees.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Currency Code of the service fees.
        /// </summary>
        /// <value>Currency Code of the service fees.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityResponseInnerServiceFeesInner {\n");
            sb.Append("  ConditionType: ").Append(ConditionType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
