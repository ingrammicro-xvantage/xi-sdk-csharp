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
    /// InvoiceDetailResponseServiceresponseResponsepreamble
    /// </summary>
    [DataContract(Name = "InvoiceDetailResponse_serviceresponse_responsepreamble")]
    public partial class InvoiceDetailResponseServiceresponseResponsepreamble : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailResponseServiceresponseResponsepreamble" /> class.
        /// </summary>
        /// <param name="responsestatus">responsestatus.</param>
        /// <param name="statuscode">statuscode.</param>
        /// <param name="responsemessage">responsemessage.</param>
        public InvoiceDetailResponseServiceresponseResponsepreamble(string responsestatus = default(string), string statuscode = default(string), string responsemessage = default(string))
        {
            this.Responsestatus = responsestatus;
            this.Statuscode = statuscode;
            this.Responsemessage = responsemessage;
        }

        /// <summary>
        /// Gets or Sets Responsestatus
        /// </summary>
        [DataMember(Name = "responsestatus", EmitDefaultValue = false)]
        public string Responsestatus { get; set; }

        /// <summary>
        /// Gets or Sets Statuscode
        /// </summary>
        [DataMember(Name = "statuscode", EmitDefaultValue = false)]
        public string Statuscode { get; set; }

        /// <summary>
        /// Gets or Sets Responsemessage
        /// </summary>
        [DataMember(Name = "responsemessage", EmitDefaultValue = false)]
        public string Responsemessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailResponseServiceresponseResponsepreamble {\n");
            sb.Append("  Responsestatus: ").Append(Responsestatus).Append("\n");
            sb.Append("  Statuscode: ").Append(Statuscode).Append("\n");
            sb.Append("  Responsemessage: ").Append(Responsemessage).Append("\n");
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
