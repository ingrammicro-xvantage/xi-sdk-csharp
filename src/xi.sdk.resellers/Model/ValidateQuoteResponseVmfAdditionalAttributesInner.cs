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
    /// ValidateQuoteResponseVmfAdditionalAttributesInner
    /// </summary>
    [DataContract(Name = "ValidateQuoteResponse_vmfAdditionalAttributes_inner")]
    public partial class ValidateQuoteResponseVmfAdditionalAttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateQuoteResponseVmfAdditionalAttributesInner" /> class.
        /// </summary>
        /// <param name="attributeName">The name of the header level field..</param>
        /// <param name="attributeValue">The value of the header level field..</param>
        /// <param name="attributeDescription">The description of the header level field..</param>
        public ValidateQuoteResponseVmfAdditionalAttributesInner(string attributeName = default(string), string attributeValue = default(string), string attributeDescription = default(string))
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
            this.AttributeDescription = attributeDescription;
        }

        /// <summary>
        /// The name of the header level field.
        /// </summary>
        /// <value>The name of the header level field.</value>
        /*
        <example>VEND_AUTH_NBR_FLG</example>
        */
        [DataMember(Name = "attributeName", EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// The value of the header level field.
        /// </summary>
        /// <value>The value of the header level field.</value>
        /*
        <example>ABC1234</example>
        */
        [DataMember(Name = "attributeValue", EmitDefaultValue = false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// The description of the header level field.
        /// </summary>
        /// <value>The description of the header level field.</value>
        /*
        <example>Authorization Number</example>
        */
        [DataMember(Name = "attributeDescription", EmitDefaultValue = false)]
        public string AttributeDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidateQuoteResponseVmfAdditionalAttributesInner {\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  AttributeValue: ").Append(AttributeValue).Append("\n");
            sb.Append("  AttributeDescription: ").Append(AttributeDescription).Append("\n");
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
