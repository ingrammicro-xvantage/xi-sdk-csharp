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
    /// QuoteDetailsResponseAdditionalAttributesInner
    /// </summary>
    [DataContract(Name = "QuoteDetailsResponse_additionalAttributes_inner")]
    public partial class QuoteDetailsResponseAdditionalAttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsResponseAdditionalAttributesInner" /> class.
        /// </summary>
        /// <param name="attributeName">estimateId - is the identification number for an estimate provided by Cisco for a quote.  dealId - is the identification number for the specific deal pricing related to a Cisco quote  vendorName - Name of Vendor associated with the quote.  vendorMessage - Vendor Message is associated with primary vendor in the quote.  In cases where a vendor requires a message be presented in the quote, the vendor name and message will be retreived and must be included in the quote vendor message fields..</param>
        /// <param name="attributeValue">The attribute field data..</param>
        public QuoteDetailsResponseAdditionalAttributesInner(string attributeName = default(string), string attributeValue = default(string))
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
        }

        /// <summary>
        /// estimateId - is the identification number for an estimate provided by Cisco for a quote.  dealId - is the identification number for the specific deal pricing related to a Cisco quote  vendorName - Name of Vendor associated with the quote.  vendorMessage - Vendor Message is associated with primary vendor in the quote.  In cases where a vendor requires a message be presented in the quote, the vendor name and message will be retreived and must be included in the quote vendor message fields.
        /// </summary>
        /// <value>estimateId - is the identification number for an estimate provided by Cisco for a quote.  dealId - is the identification number for the specific deal pricing related to a Cisco quote  vendorName - Name of Vendor associated with the quote.  vendorMessage - Vendor Message is associated with primary vendor in the quote.  In cases where a vendor requires a message be presented in the quote, the vendor name and message will be retreived and must be included in the quote vendor message fields.</value>
        [DataMember(Name = "attributeName", EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// The attribute field data.
        /// </summary>
        /// <value>The attribute field data.</value>
        [DataMember(Name = "attributeValue", EmitDefaultValue = false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsResponseAdditionalAttributesInner {\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
