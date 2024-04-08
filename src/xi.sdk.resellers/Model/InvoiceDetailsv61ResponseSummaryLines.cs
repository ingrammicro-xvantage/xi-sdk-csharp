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
    /// InvoiceDetailsv61ResponseSummaryLines
    /// </summary>
    [DataContract(Name = "InvoiceDetailsv6_1Response_summary_lines")]
    public partial class InvoiceDetailsv61ResponseSummaryLines : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailsv61ResponseSummaryLines" /> class.
        /// </summary>
        /// <param name="productLineCount">Number of lines in the order..</param>
        /// <param name="productLineTotalQuantity">Total quantity of the order..</param>
        public InvoiceDetailsv61ResponseSummaryLines(int productLineCount = default(int), int productLineTotalQuantity = default(int))
        {
            this.ProductLineCount = productLineCount;
            this.ProductLineTotalQuantity = productLineTotalQuantity;
        }

        /// <summary>
        /// Number of lines in the order.
        /// </summary>
        /// <value>Number of lines in the order.</value>
        [DataMember(Name = "productLineCount", EmitDefaultValue = false)]
        public int ProductLineCount { get; set; }

        /// <summary>
        /// Total quantity of the order.
        /// </summary>
        /// <value>Total quantity of the order.</value>
        [DataMember(Name = "productLineTotalQuantity", EmitDefaultValue = false)]
        public int ProductLineTotalQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailsv61ResponseSummaryLines {\n");
            sb.Append("  ProductLineCount: ").Append(ProductLineCount).Append("\n");
            sb.Append("  ProductLineTotalQuantity: ").Append(ProductLineTotalQuantity).Append("\n");
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
