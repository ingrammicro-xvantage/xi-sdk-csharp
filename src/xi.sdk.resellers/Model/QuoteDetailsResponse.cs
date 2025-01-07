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
    /// QuoteDetailsResponse
    /// </summary>
    [DataContract(Name = "QuoteDetailsResponse")]
    public partial class QuoteDetailsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsResponse" /> class.
        /// </summary>
        /// <param name="quoteName">Quote Name given to quote by sales team or system generated.  Generally used as a reference to identify the quote..</param>
        /// <param name="quoteNumber">Unique identifier generated by Ingram Micro&#39;s CRM specific to each quote.  When applying a filter to the quoteNumber and including a partial quote number in the filter, all quotes containing any information included in the filter can be retrieved as a subset of all available customer quotes..</param>
        /// <param name="quoteGuid">quoteGuid.</param>
        /// <param name="revision">When a quote has been revised and updated, the quote number remains the same throughout the lifecycle of the quote, however, a Revision number is updated for each revision of the quote.  The revision numbers is associated with the Unique Quote Number..</param>
        /// <param name="ingramQuoteDate">Date the Quote was initially Created..</param>
        /// <param name="lastModifiedDate">Date the Quote was last updated or modified..</param>
        /// <param name="ingramQuoteExpiryDate">Quote expiration date..</param>
        /// <param name="currencyCode">Three letter currency code..</param>
        /// <param name="specialBidId">Price discount identifyer to specify  a pricing discount that has been applied to the quote. If present - the priceDeviationStartDate and priceDeviationExpiryDate must be presented. Cisco refers to this as a Dart.</param>
        /// <param name="specialBidEffectiveDate">If price discount has been applied to the quote - the starting date the discount begins..</param>
        /// <param name="specialBidExpirationDate">If a price discount has been applied to the quote - The date the discount expires and will no longer be applicable..</param>
        /// <param name="vendorQuoteNumber">vendorQuoteNumber.</param>
        /// <param name="isPartialOrderAllowed">isPartialOrderAllowed.</param>
        /// <param name="status">This refers to the primary status of the quote.  API responses will return.</param>
        /// <param name="statusReason">statusReason.</param>
        /// <param name="closingReason">Closing Reason for quote..</param>
        /// <param name="dateClosed">dateClosed.</param>
        /// <param name="customerNeed">Details related to the customer&#39;s request for the quote entered by the sales representative or system generated..</param>
        /// <param name="proposedSolution">Ingram Micro proposed solution and summary of quote..</param>
        /// <param name="introPreamble">Introductory paragraph included in each quote.  Legally required - must be included when presenting the quote details..</param>
        /// <param name="purchaseInstructions">Purchase instructions.  Legally required - must be included when presenting the quote details..</param>
        /// <param name="legalTerms">Legal terms -  Legally required - must be included when presenting the quote details..</param>
        /// <param name="quoteType">quoteType.</param>
        /// <param name="leaseInfo">Lease information..</param>
        /// <param name="leasingInstructions">Leasing information.</param>
        /// <param name="imWarehouse">Warehouse name and Address.</param>
        /// <param name="imWarehouseGstNumber">Warehouse GST Number.</param>
        /// <param name="paymentTermsName">paymentTermsName.</param>
        /// <param name="resellerInfo">resellerInfo.</param>
        /// <param name="endUserInfo">endUserInfo.</param>
        /// <param name="shippingInfo">shippingInfo.</param>
        /// <param name="products">products.</param>
        /// <param name="productsCount">Total number of products included in the quote.</param>
        /// <param name="extendedMsrpTotal">Total extended MSRP for all products included in the quote.</param>
        /// <param name="quantityTotal">Total quantity of all items in the quote..</param>
        /// <param name="extraFeesTotal">extraFeesTotal.</param>
        /// <param name="extraFeesTotalDetails">extraFeesTotalDetails.</param>
        /// <param name="taxTotal">taxTotal.</param>
        /// <param name="extendedQuotePriceTotal">Total amount of quoted price for all products in the quote including both solution products and suggested products..</param>
        /// <param name="freightAmount">freightAmount.</param>
        /// <param name="totalQuoteAmount">totalQuoteAmount.</param>
        /// <param name="additionalAttributes">additionalAttributes.</param>
        public QuoteDetailsResponse(string quoteName = default(string), string quoteNumber = default(string), string quoteGuid = default(string), string revision = default(string), string ingramQuoteDate = default(string), string lastModifiedDate = default(string), string ingramQuoteExpiryDate = default(string), string currencyCode = default(string), string specialBidId = default(string), string specialBidEffectiveDate = default(string), string specialBidExpirationDate = default(string), string vendorQuoteNumber = default(string), bool? isPartialOrderAllowed = default(bool?), string status = default(string), string statusReason = default(string), string closingReason = default(string), string dateClosed = default(string), string customerNeed = default(string), string proposedSolution = default(string), string introPreamble = default(string), string purchaseInstructions = default(string), string legalTerms = default(string), string quoteType = default(string), string leaseInfo = default(string), string leasingInstructions = default(string), string imWarehouse = default(string), string imWarehouseGstNumber = default(string), string paymentTermsName = default(string), QuoteDetailsResponseResellerInfo resellerInfo = default(QuoteDetailsResponseResellerInfo), QuoteDetailsResponseEndUserInfo endUserInfo = default(QuoteDetailsResponseEndUserInfo), QuoteDetailsResponseShippingInfo shippingInfo = default(QuoteDetailsResponseShippingInfo), List<QuoteDetailsResponseProductsInner> products = default(List<QuoteDetailsResponseProductsInner>), int productsCount = default(int), decimal? extendedMsrpTotal = default(decimal?), int quantityTotal = default(int), decimal extraFeesTotal = default(decimal), List<QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner> extraFeesTotalDetails = default(List<QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner>), decimal? taxTotal = default(decimal?), decimal extendedQuotePriceTotal = default(decimal), decimal? freightAmount = default(decimal?), string totalQuoteAmount = default(string), List<QuoteDetailsResponseAdditionalAttributesInner> additionalAttributes = default(List<QuoteDetailsResponseAdditionalAttributesInner>))
        {
            this.QuoteName = quoteName;
            this.QuoteNumber = quoteNumber;
            this.QuoteGuid = quoteGuid;
            this.Revision = revision;
            this.IngramQuoteDate = ingramQuoteDate;
            this.LastModifiedDate = lastModifiedDate;
            this.IngramQuoteExpiryDate = ingramQuoteExpiryDate;
            this.CurrencyCode = currencyCode;
            this.SpecialBidId = specialBidId;
            this.SpecialBidEffectiveDate = specialBidEffectiveDate;
            this.SpecialBidExpirationDate = specialBidExpirationDate;
            this.VendorQuoteNumber = vendorQuoteNumber;
            this.IsPartialOrderAllowed = isPartialOrderAllowed;
            this.Status = status;
            this.StatusReason = statusReason;
            this.ClosingReason = closingReason;
            this.DateClosed = dateClosed;
            this.CustomerNeed = customerNeed;
            this.ProposedSolution = proposedSolution;
            this.IntroPreamble = introPreamble;
            this.PurchaseInstructions = purchaseInstructions;
            this.LegalTerms = legalTerms;
            this.QuoteType = quoteType;
            this.LeaseInfo = leaseInfo;
            this.LeasingInstructions = leasingInstructions;
            this.ImWarehouse = imWarehouse;
            this.ImWarehouseGstNumber = imWarehouseGstNumber;
            this.PaymentTermsName = paymentTermsName;
            this.ResellerInfo = resellerInfo;
            this.EndUserInfo = endUserInfo;
            this.ShippingInfo = shippingInfo;
            this.Products = products;
            this.ProductsCount = productsCount;
            this.ExtendedMsrpTotal = extendedMsrpTotal;
            this.QuantityTotal = quantityTotal;
            this.ExtraFeesTotal = extraFeesTotal;
            this.ExtraFeesTotalDetails = extraFeesTotalDetails;
            this.TaxTotal = taxTotal;
            this.ExtendedQuotePriceTotal = extendedQuotePriceTotal;
            this.FreightAmount = freightAmount;
            this.TotalQuoteAmount = totalQuoteAmount;
            this.AdditionalAttributes = additionalAttributes;
        }

        /// <summary>
        /// Quote Name given to quote by sales team or system generated.  Generally used as a reference to identify the quote.
        /// </summary>
        /// <value>Quote Name given to quote by sales team or system generated.  Generally used as a reference to identify the quote.</value>
        [DataMember(Name = "quoteName", EmitDefaultValue = false)]
        public string QuoteName { get; set; }

        /// <summary>
        /// Unique identifier generated by Ingram Micro&#39;s CRM specific to each quote.  When applying a filter to the quoteNumber and including a partial quote number in the filter, all quotes containing any information included in the filter can be retrieved as a subset of all available customer quotes.
        /// </summary>
        /// <value>Unique identifier generated by Ingram Micro&#39;s CRM specific to each quote.  When applying a filter to the quoteNumber and including a partial quote number in the filter, all quotes containing any information included in the filter can be retrieved as a subset of all available customer quotes.</value>
        [DataMember(Name = "quoteNumber", EmitDefaultValue = false)]
        public string QuoteNumber { get; set; }

        /// <summary>
        /// Gets or Sets QuoteGuid
        /// </summary>
        [DataMember(Name = "quoteGuid", EmitDefaultValue = false)]
        public string QuoteGuid { get; set; }

        /// <summary>
        /// When a quote has been revised and updated, the quote number remains the same throughout the lifecycle of the quote, however, a Revision number is updated for each revision of the quote.  The revision numbers is associated with the Unique Quote Number.
        /// </summary>
        /// <value>When a quote has been revised and updated, the quote number remains the same throughout the lifecycle of the quote, however, a Revision number is updated for each revision of the quote.  The revision numbers is associated with the Unique Quote Number.</value>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        public string Revision { get; set; }

        /// <summary>
        /// Date the Quote was initially Created.
        /// </summary>
        /// <value>Date the Quote was initially Created.</value>
        [DataMember(Name = "ingramQuoteDate", EmitDefaultValue = false)]
        public string IngramQuoteDate { get; set; }

        /// <summary>
        /// Date the Quote was last updated or modified.
        /// </summary>
        /// <value>Date the Quote was last updated or modified.</value>
        [DataMember(Name = "lastModifiedDate", EmitDefaultValue = false)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Quote expiration date.
        /// </summary>
        /// <value>Quote expiration date.</value>
        [DataMember(Name = "ingramQuoteExpiryDate", EmitDefaultValue = false)]
        public string IngramQuoteExpiryDate { get; set; }

        /// <summary>
        /// Three letter currency code.
        /// </summary>
        /// <value>Three letter currency code.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Price discount identifyer to specify  a pricing discount that has been applied to the quote. If present - the priceDeviationStartDate and priceDeviationExpiryDate must be presented. Cisco refers to this as a Dart
        /// </summary>
        /// <value>Price discount identifyer to specify  a pricing discount that has been applied to the quote. If present - the priceDeviationStartDate and priceDeviationExpiryDate must be presented. Cisco refers to this as a Dart</value>
        [DataMember(Name = "specialBidId", EmitDefaultValue = false)]
        public string SpecialBidId { get; set; }

        /// <summary>
        /// If price discount has been applied to the quote - the starting date the discount begins.
        /// </summary>
        /// <value>If price discount has been applied to the quote - the starting date the discount begins.</value>
        [DataMember(Name = "specialBidEffectiveDate", EmitDefaultValue = false)]
        public string SpecialBidEffectiveDate { get; set; }

        /// <summary>
        /// If a price discount has been applied to the quote - The date the discount expires and will no longer be applicable.
        /// </summary>
        /// <value>If a price discount has been applied to the quote - The date the discount expires and will no longer be applicable.</value>
        [DataMember(Name = "specialBidExpirationDate", EmitDefaultValue = false)]
        public string SpecialBidExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets VendorQuoteNumber
        /// </summary>
        [DataMember(Name = "vendorQuoteNumber", EmitDefaultValue = false)]
        public string VendorQuoteNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsPartialOrderAllowed
        /// </summary>
        [DataMember(Name = "isPartialOrderAllowed", EmitDefaultValue = true)]
        public bool? IsPartialOrderAllowed { get; set; }

        /// <summary>
        /// This refers to the primary status of the quote.  API responses will return
        /// </summary>
        /// <value>This refers to the primary status of the quote.  API responses will return</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusReason
        /// </summary>
        [DataMember(Name = "statusReason", EmitDefaultValue = false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Closing Reason for quote.
        /// </summary>
        /// <value>Closing Reason for quote.</value>
        [DataMember(Name = "closingReason", EmitDefaultValue = false)]
        public string ClosingReason { get; set; }

        /// <summary>
        /// Gets or Sets DateClosed
        /// </summary>
        [DataMember(Name = "dateClosed", EmitDefaultValue = false)]
        public string DateClosed { get; set; }

        /// <summary>
        /// Details related to the customer&#39;s request for the quote entered by the sales representative or system generated.
        /// </summary>
        /// <value>Details related to the customer&#39;s request for the quote entered by the sales representative or system generated.</value>
        [DataMember(Name = "customerNeed", EmitDefaultValue = false)]
        public string CustomerNeed { get; set; }

        /// <summary>
        /// Ingram Micro proposed solution and summary of quote.
        /// </summary>
        /// <value>Ingram Micro proposed solution and summary of quote.</value>
        [DataMember(Name = "proposedSolution", EmitDefaultValue = false)]
        public string ProposedSolution { get; set; }

        /// <summary>
        /// Introductory paragraph included in each quote.  Legally required - must be included when presenting the quote details.
        /// </summary>
        /// <value>Introductory paragraph included in each quote.  Legally required - must be included when presenting the quote details.</value>
        [DataMember(Name = "introPreamble", EmitDefaultValue = false)]
        public string IntroPreamble { get; set; }

        /// <summary>
        /// Purchase instructions.  Legally required - must be included when presenting the quote details.
        /// </summary>
        /// <value>Purchase instructions.  Legally required - must be included when presenting the quote details.</value>
        [DataMember(Name = "purchaseInstructions", EmitDefaultValue = false)]
        public string PurchaseInstructions { get; set; }

        /// <summary>
        /// Legal terms -  Legally required - must be included when presenting the quote details.
        /// </summary>
        /// <value>Legal terms -  Legally required - must be included when presenting the quote details.</value>
        [DataMember(Name = "legalTerms", EmitDefaultValue = false)]
        public string LegalTerms { get; set; }

        /// <summary>
        /// Gets or Sets QuoteType
        /// </summary>
        [DataMember(Name = "quoteType", EmitDefaultValue = false)]
        public string QuoteType { get; set; }

        /// <summary>
        /// Lease information.
        /// </summary>
        /// <value>Lease information.</value>
        [DataMember(Name = "leaseInfo", EmitDefaultValue = false)]
        public string LeaseInfo { get; set; }

        /// <summary>
        /// Leasing information
        /// </summary>
        /// <value>Leasing information</value>
        [DataMember(Name = "leasingInstructions", EmitDefaultValue = false)]
        public string LeasingInstructions { get; set; }

        /// <summary>
        /// Warehouse name and Address
        /// </summary>
        /// <value>Warehouse name and Address</value>
        [DataMember(Name = "imWarehouse", EmitDefaultValue = false)]
        public string ImWarehouse { get; set; }

        /// <summary>
        /// Warehouse GST Number
        /// </summary>
        /// <value>Warehouse GST Number</value>
        [DataMember(Name = "imWarehouseGstNumber", EmitDefaultValue = false)]
        public string ImWarehouseGstNumber { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTermsName
        /// </summary>
        [DataMember(Name = "paymentTermsName", EmitDefaultValue = false)]
        public string PaymentTermsName { get; set; }

        /// <summary>
        /// Gets or Sets ResellerInfo
        /// </summary>
        [DataMember(Name = "resellerInfo", EmitDefaultValue = false)]
        public QuoteDetailsResponseResellerInfo ResellerInfo { get; set; }

        /// <summary>
        /// Gets or Sets EndUserInfo
        /// </summary>
        [DataMember(Name = "endUserInfo", EmitDefaultValue = false)]
        public QuoteDetailsResponseEndUserInfo EndUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets ShippingInfo
        /// </summary>
        [DataMember(Name = "shippingInfo", EmitDefaultValue = false)]
        public QuoteDetailsResponseShippingInfo ShippingInfo { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name = "products", EmitDefaultValue = false)]
        public List<QuoteDetailsResponseProductsInner> Products { get; set; }

        /// <summary>
        /// Total number of products included in the quote
        /// </summary>
        /// <value>Total number of products included in the quote</value>
        [DataMember(Name = "productsCount", EmitDefaultValue = false)]
        public int ProductsCount { get; set; }

        /// <summary>
        /// Total extended MSRP for all products included in the quote
        /// </summary>
        /// <value>Total extended MSRP for all products included in the quote</value>
        [DataMember(Name = "extendedMsrpTotal", EmitDefaultValue = true)]
        public decimal? ExtendedMsrpTotal { get; set; }

        /// <summary>
        /// Total quantity of all items in the quote.
        /// </summary>
        /// <value>Total quantity of all items in the quote.</value>
        [DataMember(Name = "quantityTotal", EmitDefaultValue = false)]
        public int QuantityTotal { get; set; }

        /// <summary>
        /// Gets or Sets ExtraFeesTotal
        /// </summary>
        [DataMember(Name = "extraFeesTotal", EmitDefaultValue = false)]
        public decimal ExtraFeesTotal { get; set; }

        /// <summary>
        /// Gets or Sets ExtraFeesTotalDetails
        /// </summary>
        [DataMember(Name = "extraFeesTotalDetails", EmitDefaultValue = false)]
        public List<QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner> ExtraFeesTotalDetails { get; set; }

        /// <summary>
        /// Gets or Sets TaxTotal
        /// </summary>
        [DataMember(Name = "taxTotal", EmitDefaultValue = true)]
        public decimal? TaxTotal { get; set; }

        /// <summary>
        /// Total amount of quoted price for all products in the quote including both solution products and suggested products.
        /// </summary>
        /// <value>Total amount of quoted price for all products in the quote including both solution products and suggested products.</value>
        [DataMember(Name = "extendedQuotePriceTotal", EmitDefaultValue = false)]
        public decimal ExtendedQuotePriceTotal { get; set; }

        /// <summary>
        /// Gets or Sets FreightAmount
        /// </summary>
        [DataMember(Name = "freightAmount", EmitDefaultValue = true)]
        public decimal? FreightAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalQuoteAmount
        /// </summary>
        [DataMember(Name = "totalQuoteAmount", EmitDefaultValue = false)]
        public string TotalQuoteAmount { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = false)]
        public List<QuoteDetailsResponseAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsResponse {\n");
            sb.Append("  QuoteName: ").Append(QuoteName).Append("\n");
            sb.Append("  QuoteNumber: ").Append(QuoteNumber).Append("\n");
            sb.Append("  QuoteGuid: ").Append(QuoteGuid).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  IngramQuoteDate: ").Append(IngramQuoteDate).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  IngramQuoteExpiryDate: ").Append(IngramQuoteExpiryDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  SpecialBidId: ").Append(SpecialBidId).Append("\n");
            sb.Append("  SpecialBidEffectiveDate: ").Append(SpecialBidEffectiveDate).Append("\n");
            sb.Append("  SpecialBidExpirationDate: ").Append(SpecialBidExpirationDate).Append("\n");
            sb.Append("  VendorQuoteNumber: ").Append(VendorQuoteNumber).Append("\n");
            sb.Append("  IsPartialOrderAllowed: ").Append(IsPartialOrderAllowed).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
            sb.Append("  ClosingReason: ").Append(ClosingReason).Append("\n");
            sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
            sb.Append("  CustomerNeed: ").Append(CustomerNeed).Append("\n");
            sb.Append("  ProposedSolution: ").Append(ProposedSolution).Append("\n");
            sb.Append("  IntroPreamble: ").Append(IntroPreamble).Append("\n");
            sb.Append("  PurchaseInstructions: ").Append(PurchaseInstructions).Append("\n");
            sb.Append("  LegalTerms: ").Append(LegalTerms).Append("\n");
            sb.Append("  QuoteType: ").Append(QuoteType).Append("\n");
            sb.Append("  LeaseInfo: ").Append(LeaseInfo).Append("\n");
            sb.Append("  LeasingInstructions: ").Append(LeasingInstructions).Append("\n");
            sb.Append("  ImWarehouse: ").Append(ImWarehouse).Append("\n");
            sb.Append("  ImWarehouseGstNumber: ").Append(ImWarehouseGstNumber).Append("\n");
            sb.Append("  PaymentTermsName: ").Append(PaymentTermsName).Append("\n");
            sb.Append("  ResellerInfo: ").Append(ResellerInfo).Append("\n");
            sb.Append("  EndUserInfo: ").Append(EndUserInfo).Append("\n");
            sb.Append("  ShippingInfo: ").Append(ShippingInfo).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  ProductsCount: ").Append(ProductsCount).Append("\n");
            sb.Append("  ExtendedMsrpTotal: ").Append(ExtendedMsrpTotal).Append("\n");
            sb.Append("  QuantityTotal: ").Append(QuantityTotal).Append("\n");
            sb.Append("  ExtraFeesTotal: ").Append(ExtraFeesTotal).Append("\n");
            sb.Append("  ExtraFeesTotalDetails: ").Append(ExtraFeesTotalDetails).Append("\n");
            sb.Append("  TaxTotal: ").Append(TaxTotal).Append("\n");
            sb.Append("  ExtendedQuotePriceTotal: ").Append(ExtendedQuotePriceTotal).Append("\n");
            sb.Append("  FreightAmount: ").Append(FreightAmount).Append("\n");
            sb.Append("  TotalQuoteAmount: ").Append(TotalQuoteAmount).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
