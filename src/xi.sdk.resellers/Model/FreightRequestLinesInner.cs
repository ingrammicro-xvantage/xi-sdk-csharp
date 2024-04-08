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
    /// FreightRequestLinesInner
    /// </summary>
    [DataContract(Name = "freightRequest_lines_inner")]
    public partial class FreightRequestLinesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FreightRequestLinesInner" /> class.
        /// </summary>
        /// <param name="customerLineNumber">The ID references the reseller&#39;s address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process..</param>
        /// <param name="ingramPartNumber">The unique IngramMicro part number..</param>
        /// <param name="quantity">The requested quantity of the line item..</param>
        /// <param name="warehouseId">The ID of the warehouse the line item will ship from..</param>
        /// <param name="carrierCode">The code for the shipping carrier for the line item..</param>
        public FreightRequestLinesInner(string customerLineNumber = default(string), string ingramPartNumber = default(string), string quantity = default(string), string warehouseId = default(string), string carrierCode = default(string))
        {
            this.CustomerLineNumber = customerLineNumber;
            this.IngramPartNumber = ingramPartNumber;
            this.Quantity = quantity;
            this.WarehouseId = warehouseId;
            this.CarrierCode = carrierCode;
        }

        /// <summary>
        /// The ID references the reseller&#39;s address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process.
        /// </summary>
        /// <value>The ID references the reseller&#39;s address in Ingram Micro&#39;s system for shipping. Provided to resellers during the onboarding process.</value>
        [DataMember(Name = "customerLineNumber", EmitDefaultValue = false)]
        public string CustomerLineNumber { get; set; }

        /// <summary>
        /// The unique IngramMicro part number.
        /// </summary>
        /// <value>The unique IngramMicro part number.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// The requested quantity of the line item.
        /// </summary>
        /// <value>The requested quantity of the line item.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// The ID of the warehouse the line item will ship from.
        /// </summary>
        /// <value>The ID of the warehouse the line item will ship from.</value>
        [DataMember(Name = "warehouseId", EmitDefaultValue = false)]
        public string WarehouseId { get; set; }

        /// <summary>
        /// The code for the shipping carrier for the line item.
        /// </summary>
        /// <value>The code for the shipping carrier for the line item.</value>
        [DataMember(Name = "carrierCode", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FreightRequestLinesInner {\n");
            sb.Append("  CustomerLineNumber: ").Append(CustomerLineNumber).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
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
