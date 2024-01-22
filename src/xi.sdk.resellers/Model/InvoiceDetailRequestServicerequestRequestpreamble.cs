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
    /// InvoiceDetailRequestServicerequestRequestpreamble
    /// </summary>
    [DataContract(Name = "invoiceDetailRequest_servicerequest_requestpreamble")]
    public partial class InvoiceDetailRequestServicerequestRequestpreamble : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailRequestServicerequestRequestpreamble" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceDetailRequestServicerequestRequestpreamble() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailRequestServicerequestRequestpreamble" /> class.
        /// </summary>
        /// <param name="isocountrycode">isocountrycode (required).</param>
        /// <param name="customernumber">customernumber (required).</param>
        public InvoiceDetailRequestServicerequestRequestpreamble(string isocountrycode = default(string), string customernumber = default(string))
        {
            // to ensure "isocountrycode" is required (not null)
            if (isocountrycode == null)
            {
                throw new ArgumentNullException("isocountrycode is a required property for InvoiceDetailRequestServicerequestRequestpreamble and cannot be null");
            }
            this.Isocountrycode = isocountrycode;
            // to ensure "customernumber" is required (not null)
            if (customernumber == null)
            {
                throw new ArgumentNullException("customernumber is a required property for InvoiceDetailRequestServicerequestRequestpreamble and cannot be null");
            }
            this.Customernumber = customernumber;
        }

        /// <summary>
        /// Gets or Sets Isocountrycode
        /// </summary>
        [DataMember(Name = "isocountrycode", IsRequired = true, EmitDefaultValue = true)]
        public string Isocountrycode { get; set; }

        /// <summary>
        /// Gets or Sets Customernumber
        /// </summary>
        [DataMember(Name = "customernumber", IsRequired = true, EmitDefaultValue = true)]
        public string Customernumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceDetailRequestServicerequestRequestpreamble {\n");
            sb.Append("  Isocountrycode: ").Append(Isocountrycode).Append("\n");
            sb.Append("  Customernumber: ").Append(Customernumber).Append("\n");
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
