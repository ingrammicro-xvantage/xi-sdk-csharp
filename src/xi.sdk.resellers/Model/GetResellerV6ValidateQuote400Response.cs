/*
 * XI SDK Resellers
 *
 * For Resellers. Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
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
    /// GetResellerV6ValidateQuote400Response
    /// </summary>
    [DataContract(Name = "get_reseller_v6_validateQuote_400_response")]
    public partial class GetResellerV6ValidateQuote400Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetResellerV6ValidateQuote400Response" /> class.
        /// </summary>
        /// <param name="traceid">Unique Id to identify error..</param>
        /// <param name="type">Describes the type of the error..</param>
        /// <param name="message">A detailed error message..</param>
        /// <param name="fields">fields.</param>
        public GetResellerV6ValidateQuote400Response(string traceid = default(string), string type = default(string), string message = default(string), List<GetResellerV6ValidateQuote400ResponseFieldsInner> fields = default(List<GetResellerV6ValidateQuote400ResponseFieldsInner>))
        {
            this.Traceid = traceid;
            this.Type = type;
            this.Message = message;
            this.Fields = fields;
        }

        /// <summary>
        /// Unique Id to identify error.
        /// </summary>
        /// <value>Unique Id to identify error.</value>
        [DataMember(Name = "traceid", EmitDefaultValue = false)]
        public string Traceid { get; set; }

        /// <summary>
        /// Describes the type of the error.
        /// </summary>
        /// <value>Describes the type of the error.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// A detailed error message.
        /// </summary>
        /// <value>A detailed error message.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<GetResellerV6ValidateQuote400ResponseFieldsInner> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetResellerV6ValidateQuote400Response {\n");
            sb.Append("  Traceid: ").Append(Traceid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
