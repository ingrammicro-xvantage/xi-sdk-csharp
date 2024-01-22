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
    /// InvoiceDetailResponseServiceresponseInvoicedetailresponseExtendedspecsInner
    /// </summary>
    [DataContract(Name = "InvoiceDetailResponse_serviceresponse_invoicedetailresponse_extendedspecs_inner")]
    public partial class InvoiceDetailResponseServiceresponseInvoicedetailresponseExtendedspecsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailResponseServiceresponseInvoicedetailresponseExtendedspecsInner" /> class.
        /// </summary>
        /// <param name="attributename">attributename.</param>
        /// <param name="attributevalue">attributevalue.</param>
        public InvoiceDetailResponseServiceresponseInvoicedetailresponseExtendedspecsInner(string attributename = default(string), string attributevalue = default(string))
        {
            this.Attributename = attributename;
            this.Attributevalue = attributevalue;
        }

        /// <summary>
        /// Gets or Sets Attributename
        /// </summary>
        [DataMember(Name = "attributename", EmitDefaultValue = false)]
        public string Attributename { get; set; }

        /// <summary>
        /// Gets or Sets Attributevalue
        /// </summary>
        [DataMember(Name = "attributevalue", EmitDefaultValue = false)]
        public string Attributevalue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailResponseServiceresponseInvoicedetailresponseExtendedspecsInner {\n");
            sb.Append("  Attributename: ").Append(Attributename).Append("\n");
            sb.Append("  Attributevalue: ").Append(Attributevalue).Append("\n");
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
