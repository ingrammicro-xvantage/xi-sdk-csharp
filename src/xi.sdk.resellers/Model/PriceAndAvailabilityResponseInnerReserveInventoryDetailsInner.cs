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
    /// PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityResponse_inner_reserveInventoryDetails_inner")]
    public partial class PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner" /> class.
        /// </summary>
        /// <param name="quantityReserved">The quantity of the product reserved for the customer..</param>
        /// <param name="quantityAvailable">The availability of the product reserved..</param>
        /// <param name="effectivedate">The reservation date for the product in UTC format..</param>
        /// <param name="expirydate">The expiration date for the reservation of the product in UTC format..</param>
        public PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner(int? quantityReserved = default(int?), int? quantityAvailable = default(int?), string effectivedate = default(string), string expirydate = default(string))
        {
            this.QuantityReserved = quantityReserved;
            this.QuantityAvailable = quantityAvailable;
            this.Effectivedate = effectivedate;
            this.Expirydate = expirydate;
        }

        /// <summary>
        /// The quantity of the product reserved for the customer.
        /// </summary>
        /// <value>The quantity of the product reserved for the customer.</value>
        [DataMember(Name = "quantityReserved", EmitDefaultValue = true)]
        public int? QuantityReserved { get; set; }

        /// <summary>
        /// The availability of the product reserved.
        /// </summary>
        /// <value>The availability of the product reserved.</value>
        [DataMember(Name = "quantityAvailable", EmitDefaultValue = true)]
        public int? QuantityAvailable { get; set; }

        /// <summary>
        /// The reservation date for the product in UTC format.
        /// </summary>
        /// <value>The reservation date for the product in UTC format.</value>
        [DataMember(Name = "effectivedate", EmitDefaultValue = true)]
        public string Effectivedate { get; set; }

        /// <summary>
        /// The expiration date for the reservation of the product in UTC format.
        /// </summary>
        /// <value>The expiration date for the reservation of the product in UTC format.</value>
        [DataMember(Name = "expirydate", EmitDefaultValue = true)]
        public string Expirydate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner {\n");
            sb.Append("  QuantityReserved: ").Append(QuantityReserved).Append("\n");
            sb.Append("  QuantityAvailable: ").Append(QuantityAvailable).Append("\n");
            sb.Append("  Effectivedate: ").Append(Effectivedate).Append("\n");
            sb.Append("  Expirydate: ").Append(Expirydate).Append("\n");
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
