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
    /// QuoteDetailsResponseProductsInner
    /// </summary>
    [DataContract(Name = "QuoteDetailsResponse_products_inner")]
    public partial class QuoteDetailsResponseProductsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsResponseProductsInner" /> class.
        /// </summary>
        /// <param name="quoteProductGuid">Quote Product GUID  is the primary quote key in Ingram Micro&#39;s CRM - needed to retrieve quote details..</param>
        /// <param name="lineNumber">Line number which the product will appear in the quote.  Line number is manditory when unique configurations are included in a quote and mainting the item line order is required..</param>
        /// <param name="quantity">Quantity of product line item quoted..</param>
        /// <param name="remainingQuoteQty">remainingQuoteQty.</param>
        /// <param name="minimumOrderAllowedQty">minimumOrderAllowedQty.</param>
        /// <param name="notes">Product line item comments..</param>
        /// <param name="ean">EANUPC.</param>
        /// <param name="coo">Country of Origin..</param>
        /// <param name="ingramPartNumber">Ingram Micro SKU (stock keeping unit). An identification, usually alphanumeric, of a particular product that allows it to be tracked for inventory purposes.</param>
        /// <param name="vendorPartNumber">Vendor Part Number.</param>
        /// <param name="description">Product description.  Note - The quote view api returns only the product short description as maintained in Ingram Micro&#39;s crm system.  For long descriptions, please refer to alternative information sources..</param>
        /// <param name="weight">Weight is provided based on country standard.  For countries following Imperial standards - weight is presented as pounds with decimal.  In countries following metric standards, weight is provided as kilograms with decimal..</param>
        /// <param name="weightUom">Unit of measure.</param>
        /// <param name="isSuggestionProduct">Flag to indicate if a product line item is a suggested product.  The suggested product is provided in addition to the requested quoted products and a suggested option.  Suggested products are grouped together for subtotal and total calculations..</param>
        /// <param name="vpnCategory">Vendor product category specific to Cisco. HWDW (hardware) or service..</param>
        /// <param name="quoteProductsSupplierPartAuxiliaryId">Vendor product configuration ID specific to Cisco..</param>
        /// <param name="vendorName">Vendor name of the product.</param>
        /// <param name="terms">Terms of the quote.</param>
        /// <param name="planDescription">planDescription.</param>
        /// <param name="isSubscription">isSubscription.</param>
        /// <param name="resellerMargin">resellerMargin.</param>
        /// <param name="requestedStartDate">requestedStartDate.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="price">price.</param>
        /// <param name="billDetails">billDetails.</param>
        public QuoteDetailsResponseProductsInner(string quoteProductGuid = default(string), string lineNumber = default(string), int quantity = default(int), int? remainingQuoteQty = default(int?), int? minimumOrderAllowedQty = default(int?), string notes = default(string), string ean = default(string), string coo = default(string), string ingramPartNumber = default(string), string vendorPartNumber = default(string), string description = default(string), decimal weight = default(decimal), string weightUom = default(string), bool isSuggestionProduct = default(bool), string vpnCategory = default(string), string quoteProductsSupplierPartAuxiliaryId = default(string), string vendorName = default(string), string terms = default(string), string planDescription = default(string), bool isSubscription = default(bool), string resellerMargin = default(string), string requestedStartDate = default(string), string startDate = default(string), string endDate = default(string), string serialNumber = default(string), QuoteDetailsResponseProductsInnerPrice price = default(QuoteDetailsResponseProductsInnerPrice), List<QuoteDetailsResponseProductsInnerBillDetailsInner> billDetails = default(List<QuoteDetailsResponseProductsInnerBillDetailsInner>))
        {
            this.QuoteProductGuid = quoteProductGuid;
            this.LineNumber = lineNumber;
            this.Quantity = quantity;
            this.RemainingQuoteQty = remainingQuoteQty;
            this.MinimumOrderAllowedQty = minimumOrderAllowedQty;
            this.Notes = notes;
            this.Ean = ean;
            this.Coo = coo;
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.Description = description;
            this.Weight = weight;
            this.WeightUom = weightUom;
            this.IsSuggestionProduct = isSuggestionProduct;
            this.VpnCategory = vpnCategory;
            this.QuoteProductsSupplierPartAuxiliaryId = quoteProductsSupplierPartAuxiliaryId;
            this.VendorName = vendorName;
            this.Terms = terms;
            this.PlanDescription = planDescription;
            this.IsSubscription = isSubscription;
            this.ResellerMargin = resellerMargin;
            this.RequestedStartDate = requestedStartDate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.BillDetails = billDetails;
        }

        /// <summary>
        /// Quote Product GUID  is the primary quote key in Ingram Micro&#39;s CRM - needed to retrieve quote details.
        /// </summary>
        /// <value>Quote Product GUID  is the primary quote key in Ingram Micro&#39;s CRM - needed to retrieve quote details.</value>
        [DataMember(Name = "quoteProductGuid", EmitDefaultValue = false)]
        public string QuoteProductGuid { get; set; }

        /// <summary>
        /// Line number which the product will appear in the quote.  Line number is manditory when unique configurations are included in a quote and mainting the item line order is required.
        /// </summary>
        /// <value>Line number which the product will appear in the quote.  Line number is manditory when unique configurations are included in a quote and mainting the item line order is required.</value>
        [DataMember(Name = "lineNumber", EmitDefaultValue = false)]
        public string LineNumber { get; set; }

        /// <summary>
        /// Quantity of product line item quoted.
        /// </summary>
        /// <value>Quantity of product line item quoted.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or Sets RemainingQuoteQty
        /// </summary>
        [DataMember(Name = "remainingQuoteQty", EmitDefaultValue = true)]
        public int? RemainingQuoteQty { get; set; }

        /// <summary>
        /// Gets or Sets MinimumOrderAllowedQty
        /// </summary>
        [DataMember(Name = "minimumOrderAllowedQty", EmitDefaultValue = true)]
        public int? MinimumOrderAllowedQty { get; set; }

        /// <summary>
        /// Product line item comments.
        /// </summary>
        /// <value>Product line item comments.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// EANUPC
        /// </summary>
        /// <value>EANUPC</value>
        [DataMember(Name = "ean", EmitDefaultValue = false)]
        public string Ean { get; set; }

        /// <summary>
        /// Country of Origin.
        /// </summary>
        /// <value>Country of Origin.</value>
        [DataMember(Name = "coo", EmitDefaultValue = false)]
        public string Coo { get; set; }

        /// <summary>
        /// Ingram Micro SKU (stock keeping unit). An identification, usually alphanumeric, of a particular product that allows it to be tracked for inventory purposes
        /// </summary>
        /// <value>Ingram Micro SKU (stock keeping unit). An identification, usually alphanumeric, of a particular product that allows it to be tracked for inventory purposes</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// Vendor Part Number
        /// </summary>
        /// <value>Vendor Part Number</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Product description.  Note - The quote view api returns only the product short description as maintained in Ingram Micro&#39;s crm system.  For long descriptions, please refer to alternative information sources.
        /// </summary>
        /// <value>Product description.  Note - The quote view api returns only the product short description as maintained in Ingram Micro&#39;s crm system.  For long descriptions, please refer to alternative information sources.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Weight is provided based on country standard.  For countries following Imperial standards - weight is presented as pounds with decimal.  In countries following metric standards, weight is provided as kilograms with decimal.
        /// </summary>
        /// <value>Weight is provided based on country standard.  For countries following Imperial standards - weight is presented as pounds with decimal.  In countries following metric standards, weight is provided as kilograms with decimal.</value>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Unit of measure
        /// </summary>
        /// <value>Unit of measure</value>
        [DataMember(Name = "weightUom", EmitDefaultValue = false)]
        public string WeightUom { get; set; }

        /// <summary>
        /// Flag to indicate if a product line item is a suggested product.  The suggested product is provided in addition to the requested quoted products and a suggested option.  Suggested products are grouped together for subtotal and total calculations.
        /// </summary>
        /// <value>Flag to indicate if a product line item is a suggested product.  The suggested product is provided in addition to the requested quoted products and a suggested option.  Suggested products are grouped together for subtotal and total calculations.</value>
        [DataMember(Name = "isSuggestionProduct", EmitDefaultValue = true)]
        public bool IsSuggestionProduct { get; set; }

        /// <summary>
        /// Vendor product category specific to Cisco. HWDW (hardware) or service.
        /// </summary>
        /// <value>Vendor product category specific to Cisco. HWDW (hardware) or service.</value>
        [DataMember(Name = "vpnCategory", EmitDefaultValue = false)]
        public string VpnCategory { get; set; }

        /// <summary>
        /// Vendor product configuration ID specific to Cisco.
        /// </summary>
        /// <value>Vendor product configuration ID specific to Cisco.</value>
        [DataMember(Name = "quoteProductsSupplierPartAuxiliaryId", EmitDefaultValue = false)]
        public string QuoteProductsSupplierPartAuxiliaryId { get; set; }

        /// <summary>
        /// Vendor name of the product
        /// </summary>
        /// <value>Vendor name of the product</value>
        [DataMember(Name = "vendorName", EmitDefaultValue = false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Terms of the quote
        /// </summary>
        /// <value>Terms of the quote</value>
        [DataMember(Name = "terms", EmitDefaultValue = false)]
        public string Terms { get; set; }

        /// <summary>
        /// Gets or Sets PlanDescription
        /// </summary>
        [DataMember(Name = "planDescription", EmitDefaultValue = false)]
        public string PlanDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsSubscription
        /// </summary>
        [DataMember(Name = "isSubscription", EmitDefaultValue = true)]
        public bool IsSubscription { get; set; }

        /// <summary>
        /// Gets or Sets ResellerMargin
        /// </summary>
        [DataMember(Name = "resellerMargin", EmitDefaultValue = false)]
        public string ResellerMargin { get; set; }

        /// <summary>
        /// Gets or Sets RequestedStartDate
        /// </summary>
        [DataMember(Name = "requestedStartDate", EmitDefaultValue = false)]
        public string RequestedStartDate { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name = "serialNumber", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public QuoteDetailsResponseProductsInnerPrice Price { get; set; }

        /// <summary>
        /// Gets or Sets BillDetails
        /// </summary>
        [DataMember(Name = "billDetails", EmitDefaultValue = false)]
        public List<QuoteDetailsResponseProductsInnerBillDetailsInner> BillDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsResponseProductsInner {\n");
            sb.Append("  QuoteProductGuid: ").Append(QuoteProductGuid).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RemainingQuoteQty: ").Append(RemainingQuoteQty).Append("\n");
            sb.Append("  MinimumOrderAllowedQty: ").Append(MinimumOrderAllowedQty).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Ean: ").Append(Ean).Append("\n");
            sb.Append("  Coo: ").Append(Coo).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  WeightUom: ").Append(WeightUom).Append("\n");
            sb.Append("  IsSuggestionProduct: ").Append(IsSuggestionProduct).Append("\n");
            sb.Append("  VpnCategory: ").Append(VpnCategory).Append("\n");
            sb.Append("  QuoteProductsSupplierPartAuxiliaryId: ").Append(QuoteProductsSupplierPartAuxiliaryId).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  PlanDescription: ").Append(PlanDescription).Append("\n");
            sb.Append("  IsSubscription: ").Append(IsSubscription).Append("\n");
            sb.Append("  ResellerMargin: ").Append(ResellerMargin).Append("\n");
            sb.Append("  RequestedStartDate: ").Append(RequestedStartDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  BillDetails: ").Append(BillDetails).Append("\n");
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
