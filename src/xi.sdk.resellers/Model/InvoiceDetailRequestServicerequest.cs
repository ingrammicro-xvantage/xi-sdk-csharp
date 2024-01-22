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
    /// InvoiceDetailRequestServicerequest
    /// </summary>
    [DataContract(Name = "invoiceDetailRequest_servicerequest")]
    public partial class InvoiceDetailRequestServicerequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailRequestServicerequest" /> class.
        /// </summary>
        /// <param name="requestpreamble">requestpreamble.</param>
        /// <param name="invoicedetailrequest">invoicedetailrequest.</param>
        public InvoiceDetailRequestServicerequest(InvoiceDetailRequestServicerequestRequestpreamble requestpreamble = default(InvoiceDetailRequestServicerequestRequestpreamble), InvoiceDetailRequestServicerequestInvoicedetailrequest invoicedetailrequest = default(InvoiceDetailRequestServicerequestInvoicedetailrequest))
        {
            this.Requestpreamble = requestpreamble;
            this.Invoicedetailrequest = invoicedetailrequest;
        }

        /// <summary>
        /// Gets or Sets Requestpreamble
        /// </summary>
        [DataMember(Name = "requestpreamble", EmitDefaultValue = false)]
        public InvoiceDetailRequestServicerequestRequestpreamble Requestpreamble { get; set; }

        /// <summary>
        /// Gets or Sets Invoicedetailrequest
        /// </summary>
        [DataMember(Name = "invoicedetailrequest", EmitDefaultValue = false)]
        public InvoiceDetailRequestServicerequestInvoicedetailrequest Invoicedetailrequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailRequestServicerequest {\n");
            sb.Append("  Requestpreamble: ").Append(Requestpreamble).Append("\n");
            sb.Append("  Invoicedetailrequest: ").Append(Invoicedetailrequest).Append("\n");
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
