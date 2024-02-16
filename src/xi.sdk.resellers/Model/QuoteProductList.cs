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
    /// QuoteProductList
    /// </summary>
    [DataContract(Name = "quoteProductList")]
    public partial class QuoteProductList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteProductList" /> class.
        /// </summary>
        /// <param name="quoteProductGuid">quoteProductGuid.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="comments">comments.</param>
        /// <param name="bidStartDate">bidStartDate.</param>
        /// <param name="bidExpiryDate">bidExpiryDate.</param>
        /// <param name="sku">sku.</param>
        /// <param name="lineNumber">lineNumber.</param>
        /// <param name="description">description.</param>
        /// <param name="vendorPartNumber">vendorPartNumber.</param>
        /// <param name="weight">weight.</param>
        /// <param name="isSuggestionProduct">isSuggestionProduct.</param>
        /// <param name="vpnCategory">vpnCategory.</param>
        /// <param name="quoteProductsSupplierPartAuxiliaryId">quoteProductsSupplierPartAuxiliaryId.</param>
        /// <param name="quoteProductsVendor">quoteProductsVendor.</param>
        /// <param name="price">price.</param>
        public QuoteProductList(string quoteProductGuid = default(string), string quantity = default(string), string comments = default(string), string bidStartDate = default(string), string bidExpiryDate = default(string), string sku = default(string), string lineNumber = default(string), string description = default(string), string vendorPartNumber = default(string), string weight = default(string), string isSuggestionProduct = default(string), string vpnCategory = default(string), string quoteProductsSupplierPartAuxiliaryId = default(string), string quoteProductsVendor = default(string), QuoteProductListPrice price = default(QuoteProductListPrice))
        {
            this.QuoteProductGuid = quoteProductGuid;
            this.Quantity = quantity;
            this.Comments = comments;
            this.BidStartDate = bidStartDate;
            this.BidExpiryDate = bidExpiryDate;
            this.Sku = sku;
            this.LineNumber = lineNumber;
            this.Description = description;
            this.VendorPartNumber = vendorPartNumber;
            this.Weight = weight;
            this.IsSuggestionProduct = isSuggestionProduct;
            this.VpnCategory = vpnCategory;
            this.QuoteProductsSupplierPartAuxiliaryId = quoteProductsSupplierPartAuxiliaryId;
            this.QuoteProductsVendor = quoteProductsVendor;
            this.Price = price;
        }

        /// <summary>
        /// Gets or Sets QuoteProductGuid
        /// </summary>
        [DataMember(Name = "quoteProductGuid", EmitDefaultValue = false)]
        public string QuoteProductGuid { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets BidStartDate
        /// </summary>
        [DataMember(Name = "bidStartDate", EmitDefaultValue = false)]
        public string BidStartDate { get; set; }

        /// <summary>
        /// Gets or Sets BidExpiryDate
        /// </summary>
        [DataMember(Name = "bidExpiryDate", EmitDefaultValue = false)]
        public string BidExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name = "lineNumber", EmitDefaultValue = false)]
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets VendorPartNumber
        /// </summary>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public string Weight { get; set; }

        /// <summary>
        /// Gets or Sets IsSuggestionProduct
        /// </summary>
        [DataMember(Name = "isSuggestionProduct", EmitDefaultValue = false)]
        public string IsSuggestionProduct { get; set; }

        /// <summary>
        /// Gets or Sets VpnCategory
        /// </summary>
        [DataMember(Name = "vpnCategory", EmitDefaultValue = false)]
        public string VpnCategory { get; set; }

        /// <summary>
        /// Gets or Sets QuoteProductsSupplierPartAuxiliaryId
        /// </summary>
        [DataMember(Name = "quoteProductsSupplierPartAuxiliaryId", EmitDefaultValue = false)]
        public string QuoteProductsSupplierPartAuxiliaryId { get; set; }

        /// <summary>
        /// Gets or Sets QuoteProductsVendor
        /// </summary>
        [DataMember(Name = "quoteProductsVendor", EmitDefaultValue = false)]
        public string QuoteProductsVendor { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public QuoteProductListPrice Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteProductList {\n");
            sb.Append("  QuoteProductGuid: ").Append(QuoteProductGuid).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  BidStartDate: ").Append(BidStartDate).Append("\n");
            sb.Append("  BidExpiryDate: ").Append(BidExpiryDate).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  IsSuggestionProduct: ").Append(IsSuggestionProduct).Append("\n");
            sb.Append("  VpnCategory: ").Append(VpnCategory).Append("\n");
            sb.Append("  QuoteProductsSupplierPartAuxiliaryId: ").Append(QuoteProductsSupplierPartAuxiliaryId).Append("\n");
            sb.Append("  QuoteProductsVendor: ").Append(QuoteProductsVendor).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
