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
    /// PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityResponse_inner_discounts_inner_specialPricing_inner")]
    public partial class PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner" /> class.
        /// </summary>
        /// <param name="discountType">The type of discount being given to the customer..</param>
        /// <param name="specialBidNumer">Pre-approved special pricing/bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number where different line items have different bid numbers. Line-level bid numbers take precedence over header-level bid numbers..</param>
        /// <param name="specialPricingDiscount">Special pricing discount amount given to the customer..</param>
        /// <param name="specialPricingEffectiveDate">The effective date of the special pricing available to the customer..</param>
        /// <param name="specialPricingExpirationDate">The expiration date of the special pricing available to the customer..</param>
        /// <param name="specialPricingAvailableQuantity">The available quantity of products with discounts..</param>
        /// <param name="specialPricingMinQuantity">The minimum quantity of products that have to be purchased to ensure the discount is applied..</param>
        /// <param name="governmentDiscountType">Type of Government Discount. *Currently, this discount is only available in the USA..</param>
        /// <param name="governmentDiscountedCustomerPrice">Government Discounted Customer Price. *Currently, this discount is only available in the USA..</param>
        public PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner(string discountType = default(string), string specialBidNumer = default(string), decimal? specialPricingDiscount = default(decimal?), DateOnly? specialPricingEffectiveDate = default(DateOnly?), DateOnly? specialPricingExpirationDate = default(DateOnly?), int? specialPricingAvailableQuantity = default(int?), int? specialPricingMinQuantity = default(int?), string governmentDiscountType = default(string), decimal? governmentDiscountedCustomerPrice = default(decimal?))
        {
            this.DiscountType = discountType;
            this.SpecialBidNumer = specialBidNumer;
            this.SpecialPricingDiscount = specialPricingDiscount;
            this.SpecialPricingEffectiveDate = specialPricingEffectiveDate;
            this.SpecialPricingExpirationDate = specialPricingExpirationDate;
            this.SpecialPricingAvailableQuantity = specialPricingAvailableQuantity;
            this.SpecialPricingMinQuantity = specialPricingMinQuantity;
            this.GovernmentDiscountType = governmentDiscountType;
            this.GovernmentDiscountedCustomerPrice = governmentDiscountedCustomerPrice;
        }

        /// <summary>
        /// The type of discount being given to the customer.
        /// </summary>
        /// <value>The type of discount being given to the customer.</value>
        /*
        <example>Special Bid, Promo Discount</example>
        */
        [DataMember(Name = "discountType", EmitDefaultValue = true)]
        public string DiscountType { get; set; }

        /// <summary>
        /// Pre-approved special pricing/bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number where different line items have different bid numbers. Line-level bid numbers take precedence over header-level bid numbers.
        /// </summary>
        /// <value>Pre-approved special pricing/bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number where different line items have different bid numbers. Line-level bid numbers take precedence over header-level bid numbers.</value>
        [DataMember(Name = "specialBidNumer", EmitDefaultValue = true)]
        public string SpecialBidNumer { get; set; }

        /// <summary>
        /// Special pricing discount amount given to the customer.
        /// </summary>
        /// <value>Special pricing discount amount given to the customer.</value>
        [DataMember(Name = "specialPricingDiscount", EmitDefaultValue = true)]
        public decimal? SpecialPricingDiscount { get; set; }

        /// <summary>
        /// The effective date of the special pricing available to the customer.
        /// </summary>
        /// <value>The effective date of the special pricing available to the customer.</value>
        [DataMember(Name = "specialPricingEffectiveDate", EmitDefaultValue = true)]
        public DateOnly? SpecialPricingEffectiveDate { get; set; }

        /// <summary>
        /// The expiration date of the special pricing available to the customer.
        /// </summary>
        /// <value>The expiration date of the special pricing available to the customer.</value>
        [DataMember(Name = "specialPricingExpirationDate", EmitDefaultValue = true)]
        public DateOnly? SpecialPricingExpirationDate { get; set; }

        /// <summary>
        /// The available quantity of products with discounts.
        /// </summary>
        /// <value>The available quantity of products with discounts.</value>
        [DataMember(Name = "specialPricingAvailableQuantity", EmitDefaultValue = true)]
        public int? SpecialPricingAvailableQuantity { get; set; }

        /// <summary>
        /// The minimum quantity of products that have to be purchased to ensure the discount is applied.
        /// </summary>
        /// <value>The minimum quantity of products that have to be purchased to ensure the discount is applied.</value>
        [DataMember(Name = "specialPricingMinQuantity", EmitDefaultValue = true)]
        public int? SpecialPricingMinQuantity { get; set; }

        /// <summary>
        /// Type of Government Discount. *Currently, this discount is only available in the USA.
        /// </summary>
        /// <value>Type of Government Discount. *Currently, this discount is only available in the USA.</value>
        [DataMember(Name = "governmentDiscountType", EmitDefaultValue = true)]
        public string GovernmentDiscountType { get; set; }

        /// <summary>
        /// Government Discounted Customer Price. *Currently, this discount is only available in the USA.
        /// </summary>
        /// <value>Government Discounted Customer Price. *Currently, this discount is only available in the USA.</value>
        [DataMember(Name = "governmentDiscountedCustomerPrice", EmitDefaultValue = true)]
        public decimal? GovernmentDiscountedCustomerPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner {\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  SpecialBidNumer: ").Append(SpecialBidNumer).Append("\n");
            sb.Append("  SpecialPricingDiscount: ").Append(SpecialPricingDiscount).Append("\n");
            sb.Append("  SpecialPricingEffectiveDate: ").Append(SpecialPricingEffectiveDate).Append("\n");
            sb.Append("  SpecialPricingExpirationDate: ").Append(SpecialPricingExpirationDate).Append("\n");
            sb.Append("  SpecialPricingAvailableQuantity: ").Append(SpecialPricingAvailableQuantity).Append("\n");
            sb.Append("  SpecialPricingMinQuantity: ").Append(SpecialPricingMinQuantity).Append("\n");
            sb.Append("  GovernmentDiscountType: ").Append(GovernmentDiscountType).Append("\n");
            sb.Append("  GovernmentDiscountedCustomerPrice: ").Append(GovernmentDiscountedCustomerPrice).Append("\n");
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
