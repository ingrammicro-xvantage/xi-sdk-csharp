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
    /// RenewalsDetailsResponseAdditionalAttributesInner
    /// </summary>
    [DataContract(Name = "renewalsDetailsResponse_additionalAttributes_inner")]
    public partial class RenewalsDetailsResponseAdditionalAttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalsDetailsResponseAdditionalAttributesInner" /> class.
        /// </summary>
        /// <param name="attributeDescription">The description of the additional attribute..</param>
        /// <param name="attributeValue">The value of the additional attribute..</param>
        /// <param name="startDate">The attribute start date..</param>
        /// <param name="expirationDate">The attribute expiration date..</param>
        /// <param name="isConsolidated">Is the line item consolidated? Yes or No..</param>
        public RenewalsDetailsResponseAdditionalAttributesInner(string attributeDescription = default(string), string attributeValue = default(string), string startDate = default(string), string expirationDate = default(string), string isConsolidated = default(string))
        {
            this.AttributeDescription = attributeDescription;
            this.AttributeValue = attributeValue;
            this.StartDate = startDate;
            this.ExpirationDate = expirationDate;
            this.IsConsolidated = isConsolidated;
        }

        /// <summary>
        /// The description of the additional attribute.
        /// </summary>
        /// <value>The description of the additional attribute.</value>
        [DataMember(Name = "attributeDescription", EmitDefaultValue = false)]
        public string AttributeDescription { get; set; }

        /// <summary>
        /// The value of the additional attribute.
        /// </summary>
        /// <value>The value of the additional attribute.</value>
        [DataMember(Name = "attributeValue", EmitDefaultValue = false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// The attribute start date.
        /// </summary>
        /// <value>The attribute start date.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The attribute expiration date.
        /// </summary>
        /// <value>The attribute expiration date.</value>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Is the line item consolidated? Yes or No.
        /// </summary>
        /// <value>Is the line item consolidated? Yes or No.</value>
        [DataMember(Name = "isConsolidated", EmitDefaultValue = false)]
        public string IsConsolidated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewalsDetailsResponseAdditionalAttributesInner {\n");
            sb.Append("  AttributeDescription: ").Append(AttributeDescription).Append("\n");
            sb.Append("  AttributeValue: ").Append(AttributeValue).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IsConsolidated: ").Append(IsConsolidated).Append("\n");
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
