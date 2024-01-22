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
    /// OrderCreateResponseServiceresponse
    /// </summary>
    [DataContract(Name = "orderCreateResponse_serviceresponse")]
    public partial class OrderCreateResponseServiceresponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateResponseServiceresponse" /> class.
        /// </summary>
        /// <param name="responsepreamble">responsepreamble.</param>
        /// <param name="ordersummary">ordersummary.</param>
        /// <param name="ordercreateresponse">Collection of orders.</param>
        public OrderCreateResponseServiceresponse(InvoiceDetailResponseServiceresponseResponsepreamble responsepreamble = default(InvoiceDetailResponseServiceresponseResponsepreamble), OrderCreateResponseServiceresponseOrdersummary ordersummary = default(OrderCreateResponseServiceresponseOrdersummary), List<OrderCreateResponseServiceresponseOrdercreateresponseInner> ordercreateresponse = default(List<OrderCreateResponseServiceresponseOrdercreateresponseInner>))
        {
            this.Responsepreamble = responsepreamble;
            this.Ordersummary = ordersummary;
            this.Ordercreateresponse = ordercreateresponse;
        }

        /// <summary>
        /// Gets or Sets Responsepreamble
        /// </summary>
        [DataMember(Name = "responsepreamble", EmitDefaultValue = false)]
        public InvoiceDetailResponseServiceresponseResponsepreamble Responsepreamble { get; set; }

        /// <summary>
        /// Gets or Sets Ordersummary
        /// </summary>
        [DataMember(Name = "ordersummary", EmitDefaultValue = false)]
        public OrderCreateResponseServiceresponseOrdersummary Ordersummary { get; set; }

        /// <summary>
        /// Collection of orders
        /// </summary>
        /// <value>Collection of orders</value>
        [DataMember(Name = "ordercreateresponse", EmitDefaultValue = false)]
        public List<OrderCreateResponseServiceresponseOrdercreateresponseInner> Ordercreateresponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateResponseServiceresponse {\n");
            sb.Append("  Responsepreamble: ").Append(Responsepreamble).Append("\n");
            sb.Append("  Ordersummary: ").Append(Ordersummary).Append("\n");
            sb.Append("  Ordercreateresponse: ").Append(Ordercreateresponse).Append("\n");
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
