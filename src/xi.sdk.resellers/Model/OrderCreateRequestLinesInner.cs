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
    /// OrderCreateRequestLinesInner
    /// </summary>
    [DataContract(Name = "OrderCreateRequest_lines_inner")]
    public partial class OrderCreateRequestLinesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestLinesInner" /> class.
        /// </summary>
        /// <param name="customerLineNumber">The reseller&#39;s line item number for reference in their system. The customer line number needs to be a unique numeric value between 1 and 884. In the event we receive duplicate values or alphanumeric values in the customer line number, we will re-sequence the customer line number. To prevent re-sequencing, please use a unique numeric value between 1 and 884 in the customer line number..</param>
        /// <param name="ingramPartNumber">The unique IngramMicro part number..</param>
        /// <param name="quantity">The requested quantity of the line item..</param>
        /// <param name="specialBidNumber">The line-level bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number in the case of split orders or where different line items have different bid numbers. Line-level bid number take precedence over header-level bid numbers..</param>
        /// <param name="notes">Line-level notes..</param>
        /// <param name="unitPrice">The reseller-requested unit price for the line item. The unit price is not guaranteed..</param>
        /// <param name="endUserPrice">The end user price..</param>
        /// <param name="additionalAttributes">additionalAttributes.</param>
        /// <param name="warrantyInfo">Warranty details for the line. This is required in case of warranty orders..</param>
        /// <param name="endUserInfo">endUserInfo.</param>
        public OrderCreateRequestLinesInner(string customerLineNumber = default(string), string ingramPartNumber = default(string), int quantity = default(int), string specialBidNumber = default(string), string notes = default(string), decimal unitPrice = default(decimal), decimal endUserPrice = default(decimal), List<OrderCreateRequestLinesInnerAdditionalAttributesInner> additionalAttributes = default(List<OrderCreateRequestLinesInnerAdditionalAttributesInner>), List<OrderCreateRequestLinesInnerWarrantyInfoInner> warrantyInfo = default(List<OrderCreateRequestLinesInnerWarrantyInfoInner>), List<OrderCreateRequestLinesInnerEndUserInfoInner> endUserInfo = default(List<OrderCreateRequestLinesInnerEndUserInfoInner>))
        {
            this.CustomerLineNumber = customerLineNumber;
            this.IngramPartNumber = ingramPartNumber;
            this.Quantity = quantity;
            this.SpecialBidNumber = specialBidNumber;
            this.Notes = notes;
            this.UnitPrice = unitPrice;
            this.EndUserPrice = endUserPrice;
            this.AdditionalAttributes = additionalAttributes;
            this.WarrantyInfo = warrantyInfo;
            this.EndUserInfo = endUserInfo;
        }

        /// <summary>
        /// The reseller&#39;s line item number for reference in their system. The customer line number needs to be a unique numeric value between 1 and 884. In the event we receive duplicate values or alphanumeric values in the customer line number, we will re-sequence the customer line number. To prevent re-sequencing, please use a unique numeric value between 1 and 884 in the customer line number.
        /// </summary>
        /// <value>The reseller&#39;s line item number for reference in their system. The customer line number needs to be a unique numeric value between 1 and 884. In the event we receive duplicate values or alphanumeric values in the customer line number, we will re-sequence the customer line number. To prevent re-sequencing, please use a unique numeric value between 1 and 884 in the customer line number.</value>
        [DataMember(Name = "customerLineNumber", EmitDefaultValue = false)]
        public string CustomerLineNumber { get; set; }

        /// <summary>
        /// The unique IngramMicro part number.
        /// </summary>
        /// <value>The unique IngramMicro part number.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// The requested quantity of the line item.
        /// </summary>
        /// <value>The requested quantity of the line item.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The line-level bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number in the case of split orders or where different line items have different bid numbers. Line-level bid number take precedence over header-level bid numbers.
        /// </summary>
        /// <value>The line-level bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number in the case of split orders or where different line items have different bid numbers. Line-level bid number take precedence over header-level bid numbers.</value>
        [DataMember(Name = "specialBidNumber", EmitDefaultValue = false)]
        public string SpecialBidNumber { get; set; }

        /// <summary>
        /// Line-level notes.
        /// </summary>
        /// <value>Line-level notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// The reseller-requested unit price for the line item. The unit price is not guaranteed.
        /// </summary>
        /// <value>The reseller-requested unit price for the line item. The unit price is not guaranteed.</value>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The end user price.
        /// </summary>
        /// <value>The end user price.</value>
        [DataMember(Name = "endUserPrice", EmitDefaultValue = false)]
        public decimal EndUserPrice { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = false)]
        public List<OrderCreateRequestLinesInnerAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Warranty details for the line. This is required in case of warranty orders.
        /// </summary>
        /// <value>Warranty details for the line. This is required in case of warranty orders.</value>
        [DataMember(Name = "warrantyInfo", EmitDefaultValue = false)]
        public List<OrderCreateRequestLinesInnerWarrantyInfoInner> WarrantyInfo { get; set; }

        /// <summary>
        /// Gets or Sets EndUserInfo
        /// </summary>
        [DataMember(Name = "endUserInfo", EmitDefaultValue = false)]
        public List<OrderCreateRequestLinesInnerEndUserInfoInner> EndUserInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequestLinesInner {\n");
            sb.Append("  CustomerLineNumber: ").Append(CustomerLineNumber).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SpecialBidNumber: ").Append(SpecialBidNumber).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  EndUserPrice: ").Append(EndUserPrice).Append("\n");
            sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
            sb.Append("  WarrantyInfo: ").Append(WarrantyInfo).Append("\n");
            sb.Append("  EndUserInfo: ").Append(EndUserInfo).Append("\n");
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
            // CustomerLineNumber (string) maxLength
            if (this.CustomerLineNumber != null && this.CustomerLineNumber.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerLineNumber, length must be less than 3.", new [] { "CustomerLineNumber" });
            }

            // IngramPartNumber (string) maxLength
            if (this.IngramPartNumber != null && this.IngramPartNumber.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IngramPartNumber, length must be less than 18.", new [] { "IngramPartNumber" });
            }

            // SpecialBidNumber (string) maxLength
            if (this.SpecialBidNumber != null && this.SpecialBidNumber.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SpecialBidNumber, length must be less than 36.", new [] { "SpecialBidNumber" });
            }

            yield break;
        }
    }

}
