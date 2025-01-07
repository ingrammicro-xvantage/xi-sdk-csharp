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
    /// ProductDetailResponseSubscriptionDetailsInnerOptionsInner
    /// </summary>
    [DataContract(Name = "ProductDetailResponse_subscriptionDetails_inner_options_inner")]
    public partial class ProductDetailResponseSubscriptionDetailsInnerOptionsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailResponseSubscriptionDetailsInnerOptionsInner" /> class.
        /// </summary>
        /// <param name="resourceId">ID of the subscription resource.</param>
        /// <param name="resourceName">Name of the subscription resource.</param>
        /// <param name="vendorPartNumber">Vendor’s part number for the product..</param>
        /// <param name="minUnits">Minimum units must be purchased..</param>
        /// <param name="maxUnits">Maximum units are available for purchase..</param>
        /// <param name="dependsOn">The name of the product must be purchased to purchase this product..</param>
        public ProductDetailResponseSubscriptionDetailsInnerOptionsInner(string resourceId = default(string), string resourceName = default(string), string vendorPartNumber = default(string), int minUnits = default(int), int maxUnits = default(int), string dependsOn = default(string))
        {
            this.ResourceId = resourceId;
            this.ResourceName = resourceName;
            this.VendorPartNumber = vendorPartNumber;
            this.MinUnits = minUnits;
            this.MaxUnits = maxUnits;
            this.DependsOn = dependsOn;
        }

        /// <summary>
        /// ID of the subscription resource
        /// </summary>
        /// <value>ID of the subscription resource</value>
        [DataMember(Name = "resourceId", EmitDefaultValue = false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Name of the subscription resource
        /// </summary>
        /// <value>Name of the subscription resource</value>
        [DataMember(Name = "resourceName", EmitDefaultValue = false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Vendor’s part number for the product.
        /// </summary>
        /// <value>Vendor’s part number for the product.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Minimum units must be purchased.
        /// </summary>
        /// <value>Minimum units must be purchased.</value>
        [DataMember(Name = "minUnits", EmitDefaultValue = false)]
        public int MinUnits { get; set; }

        /// <summary>
        /// Maximum units are available for purchase.
        /// </summary>
        /// <value>Maximum units are available for purchase.</value>
        [DataMember(Name = "maxUnits", EmitDefaultValue = false)]
        public int MaxUnits { get; set; }

        /// <summary>
        /// The name of the product must be purchased to purchase this product.
        /// </summary>
        /// <value>The name of the product must be purchased to purchase this product.</value>
        [DataMember(Name = "dependsOn", EmitDefaultValue = false)]
        public string DependsOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductDetailResponseSubscriptionDetailsInnerOptionsInner {\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  MinUnits: ").Append(MinUnits).Append("\n");
            sb.Append("  MaxUnits: ").Append(MaxUnits).Append("\n");
            sb.Append("  DependsOn: ").Append(DependsOn).Append("\n");
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
