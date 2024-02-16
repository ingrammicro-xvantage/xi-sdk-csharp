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
    /// QuoteDetailsResponseQuoteDetailResponseRetrieveQuoteResponse
    /// </summary>
    [DataContract(Name = "quoteDetailsResponse_quoteDetailResponse_retrieveQuoteResponse")]
    public partial class QuoteDetailsResponseQuoteDetailResponseRetrieveQuoteResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsResponseQuoteDetailResponseRetrieveQuoteResponse" /> class.
        /// </summary>
        /// <param name="quoteGuid">quoteGuid.</param>
        /// <param name="quoteName">quoteName.</param>
        /// <param name="quoteNumber">quoteNumber.</param>
        /// <param name="quoteExpiryDate">quoteExpiryDate.</param>
        /// <param name="revisionNumber">revisionNumber.</param>
        /// <param name="introPreamble">introPreamble.</param>
        /// <param name="purchaseInstructions">purchaseInstructions.</param>
        /// <param name="legalTerms">legalTerms.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="priceDeviationId">priceDeviationId.</param>
        /// <param name="priceDeviationStartDate">priceDeviationStartDate.</param>
        /// <param name="priceDeviationExpiryDate">priceDeviationExpiryDate.</param>
        /// <param name="customerNeed">customerNeed.</param>
        /// <param name="solutionProposed">solutionProposed.</param>
        /// <param name="status">status.</param>
        /// <param name="created">created.</param>
        /// <param name="modified">modified.</param>
        /// <param name="leasingCalculations">leasingCalculations.</param>
        /// <param name="leasingInstructions">leasingInstructions.</param>
        /// <param name="accountInfo">accountInfo.</param>
        /// <param name="contactInfo">contactInfo.</param>
        /// <param name="vendorAttributes">vendorAttributes.</param>
        /// <param name="endUser">endUser.</param>
        /// <param name="quoteProductList">quoteProductList.</param>
        /// <param name="totalQuoteProductCount">totalQuoteProductCount.</param>
        /// <param name="totalExtendedMsrp">totalExtendedMsrp.</param>
        /// <param name="totalQuantity">totalQuantity.</param>
        /// <param name="totalExtendedQuotePrice">totalExtendedQuotePrice.</param>
        public QuoteDetailsResponseQuoteDetailResponseRetrieveQuoteResponse(string quoteGuid = default(string), string quoteName = default(string), string quoteNumber = default(string), string quoteExpiryDate = default(string), string revisionNumber = default(string), string introPreamble = default(string), string purchaseInstructions = default(string), string legalTerms = default(string), string currencyCode = default(string), string priceDeviationId = default(string), string priceDeviationStartDate = default(string), string priceDeviationExpiryDate = default(string), string customerNeed = default(string), string solutionProposed = default(string), string status = default(string), string created = default(string), string modified = default(string), string leasingCalculations = default(string), string leasingInstructions = default(string), QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseAccountInfo accountInfo = default(QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseAccountInfo), QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseContactInfo contactInfo = default(QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseContactInfo), QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseVendorAttributes vendorAttributes = default(QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseVendorAttributes), QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseEndUser endUser = default(QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseEndUser), List<QuoteProductList> quoteProductList = default(List<QuoteProductList>), string totalQuoteProductCount = default(string), string totalExtendedMsrp = default(string), string totalQuantity = default(string), string totalExtendedQuotePrice = default(string))
        {
            this.QuoteGuid = quoteGuid;
            this.QuoteName = quoteName;
            this.QuoteNumber = quoteNumber;
            this.QuoteExpiryDate = quoteExpiryDate;
            this.RevisionNumber = revisionNumber;
            this.IntroPreamble = introPreamble;
            this.PurchaseInstructions = purchaseInstructions;
            this.LegalTerms = legalTerms;
            this.CurrencyCode = currencyCode;
            this.PriceDeviationId = priceDeviationId;
            this.PriceDeviationStartDate = priceDeviationStartDate;
            this.PriceDeviationExpiryDate = priceDeviationExpiryDate;
            this.CustomerNeed = customerNeed;
            this.SolutionProposed = solutionProposed;
            this.Status = status;
            this.Created = created;
            this.Modified = modified;
            this.LeasingCalculations = leasingCalculations;
            this.LeasingInstructions = leasingInstructions;
            this.AccountInfo = accountInfo;
            this.ContactInfo = contactInfo;
            this.VendorAttributes = vendorAttributes;
            this.EndUser = endUser;
            this.QuoteProductList = quoteProductList;
            this.TotalQuoteProductCount = totalQuoteProductCount;
            this.TotalExtendedMsrp = totalExtendedMsrp;
            this.TotalQuantity = totalQuantity;
            this.TotalExtendedQuotePrice = totalExtendedQuotePrice;
        }

        /// <summary>
        /// Gets or Sets QuoteGuid
        /// </summary>
        [DataMember(Name = "quoteGuid", EmitDefaultValue = false)]
        public string QuoteGuid { get; set; }

        /// <summary>
        /// Gets or Sets QuoteName
        /// </summary>
        [DataMember(Name = "quoteName", EmitDefaultValue = false)]
        public string QuoteName { get; set; }

        /// <summary>
        /// Gets or Sets QuoteNumber
        /// </summary>
        [DataMember(Name = "quoteNumber", EmitDefaultValue = false)]
        public string QuoteNumber { get; set; }

        /// <summary>
        /// Gets or Sets QuoteExpiryDate
        /// </summary>
        [DataMember(Name = "quoteExpiryDate", EmitDefaultValue = false)]
        public string QuoteExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets RevisionNumber
        /// </summary>
        [DataMember(Name = "revisionNumber", EmitDefaultValue = false)]
        public string RevisionNumber { get; set; }

        /// <summary>
        /// Gets or Sets IntroPreamble
        /// </summary>
        [DataMember(Name = "introPreamble", EmitDefaultValue = false)]
        public string IntroPreamble { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseInstructions
        /// </summary>
        [DataMember(Name = "purchaseInstructions", EmitDefaultValue = false)]
        public string PurchaseInstructions { get; set; }

        /// <summary>
        /// Gets or Sets LegalTerms
        /// </summary>
        [DataMember(Name = "legalTerms", EmitDefaultValue = false)]
        public string LegalTerms { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets PriceDeviationId
        /// </summary>
        [DataMember(Name = "priceDeviationId", EmitDefaultValue = false)]
        public string PriceDeviationId { get; set; }

        /// <summary>
        /// Gets or Sets PriceDeviationStartDate
        /// </summary>
        [DataMember(Name = "priceDeviationStartDate", EmitDefaultValue = false)]
        public string PriceDeviationStartDate { get; set; }

        /// <summary>
        /// Gets or Sets PriceDeviationExpiryDate
        /// </summary>
        [DataMember(Name = "priceDeviationExpiryDate", EmitDefaultValue = false)]
        public string PriceDeviationExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets CustomerNeed
        /// </summary>
        [DataMember(Name = "customerNeed", EmitDefaultValue = false)]
        public string CustomerNeed { get; set; }

        /// <summary>
        /// Gets or Sets SolutionProposed
        /// </summary>
        [DataMember(Name = "solutionProposed", EmitDefaultValue = false)]
        public string SolutionProposed { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public string Modified { get; set; }

        /// <summary>
        /// Gets or Sets LeasingCalculations
        /// </summary>
        [DataMember(Name = "leasingCalculations", EmitDefaultValue = false)]
        public string LeasingCalculations { get; set; }

        /// <summary>
        /// Gets or Sets LeasingInstructions
        /// </summary>
        [DataMember(Name = "leasingInstructions", EmitDefaultValue = false)]
        public string LeasingInstructions { get; set; }

        /// <summary>
        /// Gets or Sets AccountInfo
        /// </summary>
        [DataMember(Name = "accountInfo", EmitDefaultValue = false)]
        public QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseAccountInfo AccountInfo { get; set; }

        /// <summary>
        /// Gets or Sets ContactInfo
        /// </summary>
        [DataMember(Name = "contactInfo", EmitDefaultValue = false)]
        public QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseContactInfo ContactInfo { get; set; }

        /// <summary>
        /// Gets or Sets VendorAttributes
        /// </summary>
        [DataMember(Name = "vendorAttributes", EmitDefaultValue = false)]
        public QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseVendorAttributes VendorAttributes { get; set; }

        /// <summary>
        /// Gets or Sets EndUser
        /// </summary>
        [DataMember(Name = "endUser", EmitDefaultValue = false)]
        public QuoteDetailsQuoteDetailResponseRetrieveQuoteResponseEndUser EndUser { get; set; }

        /// <summary>
        /// Gets or Sets QuoteProductList
        /// </summary>
        [DataMember(Name = "quoteProductList", EmitDefaultValue = false)]
        public List<QuoteProductList> QuoteProductList { get; set; }

        /// <summary>
        /// Gets or Sets TotalQuoteProductCount
        /// </summary>
        [DataMember(Name = "totalQuoteProductCount", EmitDefaultValue = false)]
        public string TotalQuoteProductCount { get; set; }

        /// <summary>
        /// Gets or Sets TotalExtendedMsrp
        /// </summary>
        [DataMember(Name = "totalExtendedMsrp", EmitDefaultValue = false)]
        public string TotalExtendedMsrp { get; set; }

        /// <summary>
        /// Gets or Sets TotalQuantity
        /// </summary>
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        public string TotalQuantity { get; set; }

        /// <summary>
        /// Gets or Sets TotalExtendedQuotePrice
        /// </summary>
        [DataMember(Name = "totalExtendedQuotePrice", EmitDefaultValue = false)]
        public string TotalExtendedQuotePrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsResponseQuoteDetailResponseRetrieveQuoteResponse {\n");
            sb.Append("  QuoteGuid: ").Append(QuoteGuid).Append("\n");
            sb.Append("  QuoteName: ").Append(QuoteName).Append("\n");
            sb.Append("  QuoteNumber: ").Append(QuoteNumber).Append("\n");
            sb.Append("  QuoteExpiryDate: ").Append(QuoteExpiryDate).Append("\n");
            sb.Append("  RevisionNumber: ").Append(RevisionNumber).Append("\n");
            sb.Append("  IntroPreamble: ").Append(IntroPreamble).Append("\n");
            sb.Append("  PurchaseInstructions: ").Append(PurchaseInstructions).Append("\n");
            sb.Append("  LegalTerms: ").Append(LegalTerms).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  PriceDeviationId: ").Append(PriceDeviationId).Append("\n");
            sb.Append("  PriceDeviationStartDate: ").Append(PriceDeviationStartDate).Append("\n");
            sb.Append("  PriceDeviationExpiryDate: ").Append(PriceDeviationExpiryDate).Append("\n");
            sb.Append("  CustomerNeed: ").Append(CustomerNeed).Append("\n");
            sb.Append("  SolutionProposed: ").Append(SolutionProposed).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  LeasingCalculations: ").Append(LeasingCalculations).Append("\n");
            sb.Append("  LeasingInstructions: ").Append(LeasingInstructions).Append("\n");
            sb.Append("  AccountInfo: ").Append(AccountInfo).Append("\n");
            sb.Append("  ContactInfo: ").Append(ContactInfo).Append("\n");
            sb.Append("  VendorAttributes: ").Append(VendorAttributes).Append("\n");
            sb.Append("  EndUser: ").Append(EndUser).Append("\n");
            sb.Append("  QuoteProductList: ").Append(QuoteProductList).Append("\n");
            sb.Append("  TotalQuoteProductCount: ").Append(TotalQuoteProductCount).Append("\n");
            sb.Append("  TotalExtendedMsrp: ").Append(TotalExtendedMsrp).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
            sb.Append("  TotalExtendedQuotePrice: ").Append(TotalExtendedQuotePrice).Append("\n");
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
