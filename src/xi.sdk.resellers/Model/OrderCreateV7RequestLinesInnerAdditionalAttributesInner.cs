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
    /// OrderCreateV7RequestLinesInnerAdditionalAttributesInner
    /// </summary>
    [DataContract(Name = "order_create_v7_request_lines_inner_additionalAttributes_inner")]
    public partial class OrderCreateV7RequestLinesInnerAdditionalAttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateV7RequestLinesInnerAdditionalAttributesInner" /> class.
        /// </summary>
        /// <param name="attributeName">SAP requested and country-specific line level details..</param>
        /// <param name="attributeValue">TLine-level additional attributes..</param>
        public OrderCreateV7RequestLinesInnerAdditionalAttributesInner(string attributeName = default(string), string attributeValue = default(string))
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
        }

        /// <summary>
        /// SAP requested and country-specific line level details.
        /// </summary>
        /// <value>SAP requested and country-specific line level details.</value>
        [DataMember(Name = "attributeName", EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// TLine-level additional attributes.
        /// </summary>
        /// <value>TLine-level additional attributes.</value>
        [DataMember(Name = "attributeValue", EmitDefaultValue = false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateV7RequestLinesInnerAdditionalAttributesInner {\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  AttributeValue: ").Append(AttributeValue).Append("\n");
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
