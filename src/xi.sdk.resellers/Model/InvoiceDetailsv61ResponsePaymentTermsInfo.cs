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
    /// Payment terms is the agreement between Ingram and the customer by what period they should pay the invoice by
    /// </summary>
    [DataContract(Name = "InvoiceDetailsv6_1Response_paymentTermsInfo")]
    public partial class InvoiceDetailsv61ResponsePaymentTermsInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailsv61ResponsePaymentTermsInfo" /> class.
        /// </summary>
        /// <param name="paymentTermsCode">Code of the payment terms..</param>
        /// <param name="paymentTermsDescription">Description of the payment terms..</param>
        /// <param name="paymentTermsDueDate">Due date of the payment terms..</param>
        public InvoiceDetailsv61ResponsePaymentTermsInfo(string paymentTermsCode = default(string), string paymentTermsDescription = default(string), string paymentTermsDueDate = default(string))
        {
            this.PaymentTermsCode = paymentTermsCode;
            this.PaymentTermsDescription = paymentTermsDescription;
            this.PaymentTermsDueDate = paymentTermsDueDate;
        }

        /// <summary>
        /// Code of the payment terms.
        /// </summary>
        /// <value>Code of the payment terms.</value>
        [DataMember(Name = "paymentTermsCode", EmitDefaultValue = false)]
        public string PaymentTermsCode { get; set; }

        /// <summary>
        /// Description of the payment terms.
        /// </summary>
        /// <value>Description of the payment terms.</value>
        [DataMember(Name = "paymentTermsDescription", EmitDefaultValue = false)]
        public string PaymentTermsDescription { get; set; }

        /// <summary>
        /// Due date of the payment terms.
        /// </summary>
        /// <value>Due date of the payment terms.</value>
        [DataMember(Name = "paymentTermsDueDate", EmitDefaultValue = false)]
        public string PaymentTermsDueDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailsv61ResponsePaymentTermsInfo {\n");
            sb.Append("  PaymentTermsCode: ").Append(PaymentTermsCode).Append("\n");
            sb.Append("  PaymentTermsDescription: ").Append(PaymentTermsDescription).Append("\n");
            sb.Append("  PaymentTermsDueDate: ").Append(PaymentTermsDueDate).Append("\n");
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
