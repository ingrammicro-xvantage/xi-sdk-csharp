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
    /// PriceAndAvailabilityResponseInnerPricing
    /// </summary>
    [DataContract(Name = "PriceAndAvailabilityResponse_inner_pricing")]
    public partial class PriceAndAvailabilityResponseInnerPricing : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceAndAvailabilityResponseInnerPricing" /> class.
        /// </summary>
        /// <param name="currencyCode">The 3-digit ISO currency code..</param>
        /// <param name="retailPrice">The retail price of the product..</param>
        /// <param name="mapPrice">Minimum Advertised Price (MAP). If required by the vendor, resellers can not sell below MAP price..</param>
        /// <param name="customerPrice">The price customer pays after all special pricing and discounts have been applied..</param>
        /// <param name="specialBidPricingAvailable">Boolean values specifies whether special Bid discounts are available for the product..</param>
        /// <param name="webDiscountsAvailable">Boolean values specifies whether web Discounts are available for the product..</param>
        public PriceAndAvailabilityResponseInnerPricing(string currencyCode = default(string), decimal? retailPrice = default(decimal?), decimal? mapPrice = default(decimal?), decimal? customerPrice = default(decimal?), bool? specialBidPricingAvailable = default(bool?), bool? webDiscountsAvailable = default(bool?))
        {
            this.CurrencyCode = currencyCode;
            this.RetailPrice = retailPrice;
            this.MapPrice = mapPrice;
            this.CustomerPrice = customerPrice;
            this.SpecialBidPricingAvailable = specialBidPricingAvailable;
            this.WebDiscountsAvailable = webDiscountsAvailable;
        }

        /// <summary>
        /// The 3-digit ISO currency code.
        /// </summary>
        /// <value>The 3-digit ISO currency code.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The retail price of the product.
        /// </summary>
        /// <value>The retail price of the product.</value>
        [DataMember(Name = "retailPrice", EmitDefaultValue = true)]
        public decimal? RetailPrice { get; set; }

        /// <summary>
        /// Minimum Advertised Price (MAP). If required by the vendor, resellers can not sell below MAP price.
        /// </summary>
        /// <value>Minimum Advertised Price (MAP). If required by the vendor, resellers can not sell below MAP price.</value>
        [DataMember(Name = "mapPrice", EmitDefaultValue = true)]
        public decimal? MapPrice { get; set; }

        /// <summary>
        /// The price customer pays after all special pricing and discounts have been applied.
        /// </summary>
        /// <value>The price customer pays after all special pricing and discounts have been applied.</value>
        [DataMember(Name = "customerPrice", EmitDefaultValue = true)]
        public decimal? CustomerPrice { get; set; }

        /// <summary>
        /// Boolean values specifies whether special Bid discounts are available for the product.
        /// </summary>
        /// <value>Boolean values specifies whether special Bid discounts are available for the product.</value>
        [DataMember(Name = "specialBidPricingAvailable", EmitDefaultValue = true)]
        public bool? SpecialBidPricingAvailable { get; set; }

        /// <summary>
        /// Boolean values specifies whether web Discounts are available for the product.
        /// </summary>
        /// <value>Boolean values specifies whether web Discounts are available for the product.</value>
        [DataMember(Name = "webDiscountsAvailable", EmitDefaultValue = true)]
        public bool? WebDiscountsAvailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PriceAndAvailabilityResponseInnerPricing {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
            sb.Append("  MapPrice: ").Append(MapPrice).Append("\n");
            sb.Append("  CustomerPrice: ").Append(CustomerPrice).Append("\n");
            sb.Append("  SpecialBidPricingAvailable: ").Append(SpecialBidPricingAvailable).Append("\n");
            sb.Append("  WebDiscountsAvailable: ").Append(WebDiscountsAvailable).Append("\n");
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
