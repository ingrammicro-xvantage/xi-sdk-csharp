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
    /// ProductDetailResponseAdditionalInformationProductWeightInner
    /// </summary>
    [DataContract(Name = "ProductDetailResponse_additionalInformation_productWeight_inner")]
    public partial class ProductDetailResponseAdditionalInformationProductWeightInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailResponseAdditionalInformationProductWeightInner" /> class.
        /// </summary>
        /// <param name="plantId">ID of the plant.  Example : &#39;US01&#39;.</param>
        /// <param name="weight">Weight of the product.   Example : 2.</param>
        /// <param name="weightUnit">Weight unit of the product.   Example : &#39;LB&#39;.</param>
        public ProductDetailResponseAdditionalInformationProductWeightInner(string plantId = default(string), decimal weight = default(decimal), string weightUnit = default(string))
        {
            this.PlantId = plantId;
            this.Weight = weight;
            this.WeightUnit = weightUnit;
        }

        /// <summary>
        /// ID of the plant.  Example : &#39;US01&#39;
        /// </summary>
        /// <value>ID of the plant.  Example : &#39;US01&#39;</value>
        [DataMember(Name = "plantId", EmitDefaultValue = false)]
        public string PlantId { get; set; }

        /// <summary>
        /// Weight of the product.   Example : 2
        /// </summary>
        /// <value>Weight of the product.   Example : 2</value>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Weight unit of the product.   Example : &#39;LB&#39;
        /// </summary>
        /// <value>Weight unit of the product.   Example : &#39;LB&#39;</value>
        [DataMember(Name = "weightUnit", EmitDefaultValue = false)]
        public string WeightUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductDetailResponseAdditionalInformationProductWeightInner {\n");
            sb.Append("  PlantId: ").Append(PlantId).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
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
