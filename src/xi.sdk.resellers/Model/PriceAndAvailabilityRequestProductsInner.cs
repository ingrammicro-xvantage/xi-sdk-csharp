/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of APIs and webhooks to craft a seamless journey for your customers.
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
    /// PriceAndAvailabilityRequestProductsInner
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityRequest_products_inner")]
    public partial class PriceAndAvailabilityRequestProductsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityRequestProductsInner" /> class.
        /// </summary>
        /// <param name="ingramPartNumber">Ingram Micro unique part number for the product..</param>
        /// <param name="vendorPartNumber">Vendor’s part number for the product..</param>
        /// <param name="customerPartNumber">Reseller/end-user’s part number for the product..</param>
        /// <param name="upc">The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item..</param>
        /// <param name="quantityRequested">Number of quantity of the Product..</param>
        /// <param name="additionalAttributes">additionalAttributes.</param>
        public PriceAndAvailabilityRequestProductsInner(string ingramPartNumber = default(string), string vendorPartNumber = default(string), string customerPartNumber = default(string), string upc = default(string), string quantityRequested = default(string), List<PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner> additionalAttributes = default(List<PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner>))
        {
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.CustomerPartNumber = customerPartNumber;
            this.Upc = upc;
            this.QuantityRequested = quantityRequested;
            this.AdditionalAttributes = additionalAttributes;
        }

        /// <summary>
        /// Ingram Micro unique part number for the product.
        /// </summary>
        /// <value>Ingram Micro unique part number for the product.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// Vendor’s part number for the product.
        /// </summary>
        /// <value>Vendor’s part number for the product.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Reseller/end-user’s part number for the product.
        /// </summary>
        /// <value>Reseller/end-user’s part number for the product.</value>
        [DataMember(Name = "customerPartNumber", EmitDefaultValue = false)]
        public string CustomerPartNumber { get; set; }

        /// <summary>
        /// The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item.
        /// </summary>
        /// <value>The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item.</value>
        [DataMember(Name = "upc", EmitDefaultValue = false)]
        public string Upc { get; set; }

        /// <summary>
        /// Number of quantity of the Product.
        /// </summary>
        /// <value>Number of quantity of the Product.</value>
        [DataMember(Name = "quantityRequested", EmitDefaultValue = false)]
        public string QuantityRequested { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = false)]
        public List<PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityRequestProductsInner {\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  CustomerPartNumber: ").Append(CustomerPartNumber).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  QuantityRequested: ").Append(QuantityRequested).Append("\n");
            sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
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
