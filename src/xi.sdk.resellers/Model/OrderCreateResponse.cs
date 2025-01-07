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
    /// OrderCreateResponse
    /// </summary>
    [DataContract(Name = "OrderCreateResponse")]
    public partial class OrderCreateResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateResponse" /> class.
        /// </summary>
        /// <param name="customerOrderNumber">The reseller&#39;s unique PO/Order number..</param>
        /// <param name="endCustomerOrderNumber">The end user/customer&#39;s Purchase Order number..</param>
        /// <param name="billToAddressId">Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit.</param>
        /// <param name="specialBidNumber">The bid number provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers..</param>
        /// <param name="orderSplit">true for multiple orders.</param>
        /// <param name="processedPartially">true for partial order succesfully placed.</param>
        /// <param name="purchaseOrderTotal">Total of all the orders including taxes and fees..</param>
        /// <param name="shipToInfo">shipToInfo.</param>
        /// <param name="endUserInfo">endUserInfo.</param>
        /// <param name="orders">Order-level details..</param>
        public OrderCreateResponse(string customerOrderNumber = default(string), string endCustomerOrderNumber = default(string), string billToAddressId = default(string), string specialBidNumber = default(string), bool orderSplit = default(bool), bool processedPartially = default(bool), decimal purchaseOrderTotal = default(decimal), OrderCreateResponseShipToInfo shipToInfo = default(OrderCreateResponseShipToInfo), OrderCreateResponseEndUserInfo endUserInfo = default(OrderCreateResponseEndUserInfo), List<OrderCreateResponseOrdersInner> orders = default(List<OrderCreateResponseOrdersInner>))
        {
            this.CustomerOrderNumber = customerOrderNumber;
            this.EndCustomerOrderNumber = endCustomerOrderNumber;
            this.BillToAddressId = billToAddressId;
            this.SpecialBidNumber = specialBidNumber;
            this.OrderSplit = orderSplit;
            this.ProcessedPartially = processedPartially;
            this.PurchaseOrderTotal = purchaseOrderTotal;
            this.ShipToInfo = shipToInfo;
            this.EndUserInfo = endUserInfo;
            this.Orders = orders;
        }

        /// <summary>
        /// The reseller&#39;s unique PO/Order number.
        /// </summary>
        /// <value>The reseller&#39;s unique PO/Order number.</value>
        [DataMember(Name = "customerOrderNumber", EmitDefaultValue = false)]
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// The end user/customer&#39;s Purchase Order number.
        /// </summary>
        /// <value>The end user/customer&#39;s Purchase Order number.</value>
        [DataMember(Name = "endCustomerOrderNumber", EmitDefaultValue = false)]
        public string EndCustomerOrderNumber { get; set; }

        /// <summary>
        /// Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit
        /// </summary>
        /// <value>Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit</value>
        [DataMember(Name = "billToAddressId", EmitDefaultValue = false)]
        public string BillToAddressId { get; set; }

        /// <summary>
        /// The bid number provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers.
        /// </summary>
        /// <value>The bid number provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers.</value>
        [DataMember(Name = "specialBidNumber", EmitDefaultValue = false)]
        public string SpecialBidNumber { get; set; }

        /// <summary>
        /// true for multiple orders
        /// </summary>
        /// <value>true for multiple orders</value>
        [DataMember(Name = "orderSplit", EmitDefaultValue = true)]
        public bool OrderSplit { get; set; }

        /// <summary>
        /// true for partial order succesfully placed
        /// </summary>
        /// <value>true for partial order succesfully placed</value>
        [DataMember(Name = "processedPartially", EmitDefaultValue = true)]
        public bool ProcessedPartially { get; set; }

        /// <summary>
        /// Total of all the orders including taxes and fees.
        /// </summary>
        /// <value>Total of all the orders including taxes and fees.</value>
        [DataMember(Name = "purchaseOrderTotal", EmitDefaultValue = false)]
        public decimal PurchaseOrderTotal { get; set; }

        /// <summary>
        /// Gets or Sets ShipToInfo
        /// </summary>
        [DataMember(Name = "shipToInfo", EmitDefaultValue = false)]
        public OrderCreateResponseShipToInfo ShipToInfo { get; set; }

        /// <summary>
        /// Gets or Sets EndUserInfo
        /// </summary>
        [DataMember(Name = "endUserInfo", EmitDefaultValue = false)]
        public OrderCreateResponseEndUserInfo EndUserInfo { get; set; }

        /// <summary>
        /// Order-level details.
        /// </summary>
        /// <value>Order-level details.</value>
        [DataMember(Name = "orders", EmitDefaultValue = false)]
        public List<OrderCreateResponseOrdersInner> Orders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateResponse {\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
            sb.Append("  EndCustomerOrderNumber: ").Append(EndCustomerOrderNumber).Append("\n");
            sb.Append("  BillToAddressId: ").Append(BillToAddressId).Append("\n");
            sb.Append("  SpecialBidNumber: ").Append(SpecialBidNumber).Append("\n");
            sb.Append("  OrderSplit: ").Append(OrderSplit).Append("\n");
            sb.Append("  ProcessedPartially: ").Append(ProcessedPartially).Append("\n");
            sb.Append("  PurchaseOrderTotal: ").Append(PurchaseOrderTotal).Append("\n");
            sb.Append("  ShipToInfo: ").Append(ShipToInfo).Append("\n");
            sb.Append("  EndUserInfo: ").Append(EndUserInfo).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
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
