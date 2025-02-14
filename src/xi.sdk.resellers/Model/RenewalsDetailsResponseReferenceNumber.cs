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
    /// RenewalsDetailsResponseReferenceNumber
    /// </summary>
    [DataContract(Name = "renewalsDetailsResponse_referenceNumber")]
    public partial class RenewalsDetailsResponseReferenceNumber : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalsDetailsResponseReferenceNumber" /> class.
        /// </summary>
        /// <param name="notificationId">Notification id of the communication sent from Ingram..</param>
        /// <param name="quoteNumber">Quote number for the renewal..</param>
        public RenewalsDetailsResponseReferenceNumber(string notificationId = default(string), string quoteNumber = default(string))
        {
            this.NotificationId = notificationId;
            this.QuoteNumber = quoteNumber;
        }

        /// <summary>
        /// Notification id of the communication sent from Ingram.
        /// </summary>
        /// <value>Notification id of the communication sent from Ingram.</value>
        [DataMember(Name = "notificationId", EmitDefaultValue = false)]
        public string NotificationId { get; set; }

        /// <summary>
        /// Quote number for the renewal.
        /// </summary>
        /// <value>Quote number for the renewal.</value>
        [DataMember(Name = "quoteNumber", EmitDefaultValue = false)]
        public string QuoteNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewalsDetailsResponseReferenceNumber {\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  QuoteNumber: ").Append(QuoteNumber).Append("\n");
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
