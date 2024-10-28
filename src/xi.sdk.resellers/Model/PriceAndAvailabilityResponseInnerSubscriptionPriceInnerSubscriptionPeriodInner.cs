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
    /// PriceAndAvailabilityResponseInnerSubscriptionPriceInnerSubscriptionPeriodInner
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityResponse_inner_subscriptionPrice_inner_subscriptionPeriod_inner")]
    public partial class PriceAndAvailabilityResponseInnerSubscriptionPriceInnerSubscriptionPeriodInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityResponseInnerSubscriptionPriceInnerSubscriptionPeriodInner" /> class.
        /// </summary>
        /// <param name="subscriptionPeriodUnit">The unit of the subscription period..</param>
        /// <param name="subscriptionPeriod">The subscription period value..</param>
        public PriceAndAvailabilityResponseInnerSubscriptionPriceInnerSubscriptionPeriodInner(string subscriptionPeriodUnit = default(string), string subscriptionPeriod = default(string))
        {
            this.SubscriptionPeriodUnit = subscriptionPeriodUnit;
            this.SubscriptionPeriod = subscriptionPeriod;
        }

        /// <summary>
        /// The unit of the subscription period.
        /// </summary>
        /// <value>The unit of the subscription period.</value>
        [DataMember(Name = "subscriptionPeriodUnit", EmitDefaultValue = false)]
        public string SubscriptionPeriodUnit { get; set; }

        /// <summary>
        /// The subscription period value.
        /// </summary>
        /// <value>The subscription period value.</value>
        [DataMember(Name = "subscriptionPeriod", EmitDefaultValue = false)]
        public string SubscriptionPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityResponseInnerSubscriptionPriceInnerSubscriptionPeriodInner {\n");
            sb.Append("  SubscriptionPeriodUnit: ").Append(SubscriptionPeriodUnit).Append("\n");
            sb.Append("  SubscriptionPeriod: ").Append(SubscriptionPeriod).Append("\n");
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
