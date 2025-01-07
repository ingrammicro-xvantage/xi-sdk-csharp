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
    /// OrderDetailB2BLinesInner
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner")]
    public partial class OrderDetailB2BLinesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInner" /> class.
        /// </summary>
        /// <param name="subOrderNumber">The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number..</param>
        /// <param name="ingramOrderLineNumber">Unique Ingram Micro line number. Starts with 001..</param>
        /// <param name="vendorSalesOrderLineNumber">The vendor&#39;s sales order line number..</param>
        /// <param name="customerLineNumber">The reseller&#39;s line item number for reference in their system..</param>
        /// <param name="lineStatus">The status for the line item in the order. One of- Backordered, In Progress, Shipped, Delivered, Canceled, On Hold..</param>
        /// <param name="ingramPartNumber">Unique IngramMicro part number..</param>
        /// <param name="vendorPartNumber">The vendor&#39;s part number for the line item..</param>
        /// <param name="vendorName">The vendor&#39;s name for the part in their system..</param>
        /// <param name="partDescription">The vendor&#39;s description of the part in their system..</param>
        /// <param name="unitWeight">The unit weight of the line item..</param>
        /// <param name="weightUom">The unit of measure for the line item..</param>
        /// <param name="unitPrice">The unit price of the line item..</param>
        /// <param name="upcCode">The UPC code of a product..</param>
        /// <param name="extendedPrice">Unit price X quantity for the line item..</param>
        /// <param name="taxAmount">The tax amount for the line item..</param>
        /// <param name="currencyCode">The country-specific three character ISO 4217 currency code for the line item..</param>
        /// <param name="quantityOrdered">The quantity ordered of the line item..</param>
        /// <param name="quantityConfirmed">The quantity confirmed for the line item..</param>
        /// <param name="quantityBackOrdered">The quantity backordered for the line item..</param>
        /// <param name="specialBidNumber">The line-level bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number in the case of split orders or where different line items have different bid numbers. Line-level bid numbers take precedence over header-level bid numbers..</param>
        /// <param name="requestedDeliverydate">Reseller-requested delivery date. Delivery date is not guaranteed..</param>
        /// <param name="promisedDeliveryDate">The delivery date promised by IngramMicro..</param>
        /// <param name="backOrderETADate">Backorder ETA date.</param>
        /// <param name="lineNotes">Line-level notes for the order..</param>
        /// <param name="shipmentDetails">Shipping details for the line item..</param>
        /// <param name="serviceContractInfo">serviceContractInfo.</param>
        /// <param name="additionalAttributes">additionalAttributes.</param>
        /// <param name="links">links.</param>
        /// <param name="estimatedDates">estimatedDates.</param>
        /// <param name="scheduleLines">scheduleLines.</param>
        /// <param name="multipleShipments">multipleShipments.</param>
        /// <param name="defaultCarrierName">defaultCarrierName.</param>
        public OrderDetailB2BLinesInner(string subOrderNumber = default(string), string ingramOrderLineNumber = default(string), string vendorSalesOrderLineNumber = default(string), string customerLineNumber = default(string), string lineStatus = default(string), string ingramPartNumber = default(string), string vendorPartNumber = default(string), string vendorName = default(string), string partDescription = default(string), double unitWeight = default(double), string weightUom = default(string), double unitPrice = default(double), string upcCode = default(string), double extendedPrice = default(double), double taxAmount = default(double), string currencyCode = default(string), int quantityOrdered = default(int), int quantityConfirmed = default(int), int quantityBackOrdered = default(int), string specialBidNumber = default(string), string requestedDeliverydate = default(string), string promisedDeliveryDate = default(string), string backOrderETADate = default(string), string lineNotes = default(string), List<OrderDetailB2BLinesInnerShipmentDetailsInner> shipmentDetails = default(List<OrderDetailB2BLinesInnerShipmentDetailsInner>), OrderDetailB2BLinesInnerServiceContractInfo serviceContractInfo = default(OrderDetailB2BLinesInnerServiceContractInfo), List<OrderDetailB2BLinesInnerAdditionalAttributesInner> additionalAttributes = default(List<OrderDetailB2BLinesInnerAdditionalAttributesInner>), List<OrderDetailB2BLinesInnerLinksInner> links = default(List<OrderDetailB2BLinesInnerLinksInner>), List<OrderDetailB2BLinesInnerEstimatedDatesInner> estimatedDates = default(List<OrderDetailB2BLinesInnerEstimatedDatesInner>), List<OrderDetailB2BLinesInnerScheduleLinesInner> scheduleLines = default(List<OrderDetailB2BLinesInnerScheduleLinesInner>), List<OrderDetailB2BLinesInnerMultipleShipmentsInner> multipleShipments = default(List<OrderDetailB2BLinesInnerMultipleShipmentsInner>), string defaultCarrierName = default(string))
        {
            this.SubOrderNumber = subOrderNumber;
            this.IngramOrderLineNumber = ingramOrderLineNumber;
            this.VendorSalesOrderLineNumber = vendorSalesOrderLineNumber;
            this.CustomerLineNumber = customerLineNumber;
            this.LineStatus = lineStatus;
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.VendorName = vendorName;
            this.PartDescription = partDescription;
            this.UnitWeight = unitWeight;
            this.WeightUom = weightUom;
            this.UnitPrice = unitPrice;
            this.UpcCode = upcCode;
            this.ExtendedPrice = extendedPrice;
            this.TaxAmount = taxAmount;
            this.CurrencyCode = currencyCode;
            this.QuantityOrdered = quantityOrdered;
            this.QuantityConfirmed = quantityConfirmed;
            this.QuantityBackOrdered = quantityBackOrdered;
            this.SpecialBidNumber = specialBidNumber;
            this.RequestedDeliverydate = requestedDeliverydate;
            this.PromisedDeliveryDate = promisedDeliveryDate;
            this.BackOrderETADate = backOrderETADate;
            this.LineNotes = lineNotes;
            this.ShipmentDetails = shipmentDetails;
            this.ServiceContractInfo = serviceContractInfo;
            this.AdditionalAttributes = additionalAttributes;
            this.Links = links;
            this.EstimatedDates = estimatedDates;
            this.ScheduleLines = scheduleLines;
            this.MultipleShipments = multipleShipments;
            this.DefaultCarrierName = defaultCarrierName;
        }

        /// <summary>
        /// The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number.
        /// </summary>
        /// <value>The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number.</value>
        [DataMember(Name = "subOrderNumber", EmitDefaultValue = false)]
        public string SubOrderNumber { get; set; }

        /// <summary>
        /// Unique Ingram Micro line number. Starts with 001.
        /// </summary>
        /// <value>Unique Ingram Micro line number. Starts with 001.</value>
        [DataMember(Name = "ingramOrderLineNumber", EmitDefaultValue = false)]
        public string IngramOrderLineNumber { get; set; }

        /// <summary>
        /// The vendor&#39;s sales order line number.
        /// </summary>
        /// <value>The vendor&#39;s sales order line number.</value>
        [DataMember(Name = "vendorSalesOrderLineNumber", EmitDefaultValue = false)]
        public string VendorSalesOrderLineNumber { get; set; }

        /// <summary>
        /// The reseller&#39;s line item number for reference in their system.
        /// </summary>
        /// <value>The reseller&#39;s line item number for reference in their system.</value>
        [DataMember(Name = "customerLineNumber", EmitDefaultValue = false)]
        public string CustomerLineNumber { get; set; }

        /// <summary>
        /// The status for the line item in the order. One of- Backordered, In Progress, Shipped, Delivered, Canceled, On Hold.
        /// </summary>
        /// <value>The status for the line item in the order. One of- Backordered, In Progress, Shipped, Delivered, Canceled, On Hold.</value>
        [DataMember(Name = "lineStatus", EmitDefaultValue = false)]
        public string LineStatus { get; set; }

        /// <summary>
        /// Unique IngramMicro part number.
        /// </summary>
        /// <value>Unique IngramMicro part number.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// The vendor&#39;s part number for the line item.
        /// </summary>
        /// <value>The vendor&#39;s part number for the line item.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// The vendor&#39;s name for the part in their system.
        /// </summary>
        /// <value>The vendor&#39;s name for the part in their system.</value>
        [DataMember(Name = "vendorName", EmitDefaultValue = false)]
        public string VendorName { get; set; }

        /// <summary>
        /// The vendor&#39;s description of the part in their system.
        /// </summary>
        /// <value>The vendor&#39;s description of the part in their system.</value>
        [DataMember(Name = "partDescription", EmitDefaultValue = false)]
        public string PartDescription { get; set; }

        /// <summary>
        /// The unit weight of the line item.
        /// </summary>
        /// <value>The unit weight of the line item.</value>
        [DataMember(Name = "unitWeight", EmitDefaultValue = false)]
        public double UnitWeight { get; set; }

        /// <summary>
        /// The unit of measure for the line item.
        /// </summary>
        /// <value>The unit of measure for the line item.</value>
        [DataMember(Name = "weightUom", EmitDefaultValue = false)]
        public string WeightUom { get; set; }

        /// <summary>
        /// The unit price of the line item.
        /// </summary>
        /// <value>The unit price of the line item.</value>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        public double UnitPrice { get; set; }

        /// <summary>
        /// The UPC code of a product.
        /// </summary>
        /// <value>The UPC code of a product.</value>
        [DataMember(Name = "upcCode", EmitDefaultValue = false)]
        public string UpcCode { get; set; }

        /// <summary>
        /// Unit price X quantity for the line item.
        /// </summary>
        /// <value>Unit price X quantity for the line item.</value>
        [DataMember(Name = "extendedPrice", EmitDefaultValue = false)]
        public double ExtendedPrice { get; set; }

        /// <summary>
        /// The tax amount for the line item.
        /// </summary>
        /// <value>The tax amount for the line item.</value>
        [DataMember(Name = "taxAmount", EmitDefaultValue = false)]
        public double TaxAmount { get; set; }

        /// <summary>
        /// The country-specific three character ISO 4217 currency code for the line item.
        /// </summary>
        /// <value>The country-specific three character ISO 4217 currency code for the line item.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The quantity ordered of the line item.
        /// </summary>
        /// <value>The quantity ordered of the line item.</value>
        [DataMember(Name = "quantityOrdered", EmitDefaultValue = false)]
        public int QuantityOrdered { get; set; }

        /// <summary>
        /// The quantity confirmed for the line item.
        /// </summary>
        /// <value>The quantity confirmed for the line item.</value>
        [DataMember(Name = "quantityConfirmed", EmitDefaultValue = false)]
        public int QuantityConfirmed { get; set; }

        /// <summary>
        /// The quantity backordered for the line item.
        /// </summary>
        /// <value>The quantity backordered for the line item.</value>
        [DataMember(Name = "quantityBackOrdered", EmitDefaultValue = false)]
        public int QuantityBackOrdered { get; set; }

        /// <summary>
        /// The line-level bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number in the case of split orders or where different line items have different bid numbers. Line-level bid numbers take precedence over header-level bid numbers.
        /// </summary>
        /// <value>The line-level bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number in the case of split orders or where different line items have different bid numbers. Line-level bid numbers take precedence over header-level bid numbers.</value>
        [DataMember(Name = "specialBidNumber", EmitDefaultValue = false)]
        public string SpecialBidNumber { get; set; }

        /// <summary>
        /// Reseller-requested delivery date. Delivery date is not guaranteed.
        /// </summary>
        /// <value>Reseller-requested delivery date. Delivery date is not guaranteed.</value>
        [DataMember(Name = "requestedDeliverydate", EmitDefaultValue = false)]
        public string RequestedDeliverydate { get; set; }

        /// <summary>
        /// The delivery date promised by IngramMicro.
        /// </summary>
        /// <value>The delivery date promised by IngramMicro.</value>
        [DataMember(Name = "promisedDeliveryDate", EmitDefaultValue = false)]
        public string PromisedDeliveryDate { get; set; }

        /// <summary>
        /// Backorder ETA date
        /// </summary>
        /// <value>Backorder ETA date</value>
        [DataMember(Name = "backOrderETADate", EmitDefaultValue = false)]
        public string BackOrderETADate { get; set; }

        /// <summary>
        /// Line-level notes for the order.
        /// </summary>
        /// <value>Line-level notes for the order.</value>
        [DataMember(Name = "lineNotes", EmitDefaultValue = false)]
        public string LineNotes { get; set; }

        /// <summary>
        /// Shipping details for the line item.
        /// </summary>
        /// <value>Shipping details for the line item.</value>
        [DataMember(Name = "shipmentDetails", EmitDefaultValue = true)]
        public List<OrderDetailB2BLinesInnerShipmentDetailsInner> ShipmentDetails { get; set; }

        /// <summary>
        /// Gets or Sets ServiceContractInfo
        /// </summary>
        [DataMember(Name = "serviceContractInfo", EmitDefaultValue = false)]
        public OrderDetailB2BLinesInnerServiceContractInfo ServiceContractInfo { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = true)]
        public List<OrderDetailB2BLinesInnerAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<OrderDetailB2BLinesInnerLinksInner> Links { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedDates
        /// </summary>
        [DataMember(Name = "estimatedDates", EmitDefaultValue = false)]
        public List<OrderDetailB2BLinesInnerEstimatedDatesInner> EstimatedDates { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleLines
        /// </summary>
        [DataMember(Name = "scheduleLines", EmitDefaultValue = false)]
        public List<OrderDetailB2BLinesInnerScheduleLinesInner> ScheduleLines { get; set; }

        /// <summary>
        /// Gets or Sets MultipleShipments
        /// </summary>
        [DataMember(Name = "multipleShipments", EmitDefaultValue = false)]
        public List<OrderDetailB2BLinesInnerMultipleShipmentsInner> MultipleShipments { get; set; }

        /// <summary>
        /// Gets or Sets DefaultCarrierName
        /// </summary>
        /*
        <example>FEDEX GROUND</example>
        */
        [DataMember(Name = "defaultCarrierName", EmitDefaultValue = false)]
        public string DefaultCarrierName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInner {\n");
            sb.Append("  SubOrderNumber: ").Append(SubOrderNumber).Append("\n");
            sb.Append("  IngramOrderLineNumber: ").Append(IngramOrderLineNumber).Append("\n");
            sb.Append("  VendorSalesOrderLineNumber: ").Append(VendorSalesOrderLineNumber).Append("\n");
            sb.Append("  CustomerLineNumber: ").Append(CustomerLineNumber).Append("\n");
            sb.Append("  LineStatus: ").Append(LineStatus).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  PartDescription: ").Append(PartDescription).Append("\n");
            sb.Append("  UnitWeight: ").Append(UnitWeight).Append("\n");
            sb.Append("  WeightUom: ").Append(WeightUom).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  UpcCode: ").Append(UpcCode).Append("\n");
            sb.Append("  ExtendedPrice: ").Append(ExtendedPrice).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
            sb.Append("  QuantityConfirmed: ").Append(QuantityConfirmed).Append("\n");
            sb.Append("  QuantityBackOrdered: ").Append(QuantityBackOrdered).Append("\n");
            sb.Append("  SpecialBidNumber: ").Append(SpecialBidNumber).Append("\n");
            sb.Append("  RequestedDeliverydate: ").Append(RequestedDeliverydate).Append("\n");
            sb.Append("  PromisedDeliveryDate: ").Append(PromisedDeliveryDate).Append("\n");
            sb.Append("  BackOrderETADate: ").Append(BackOrderETADate).Append("\n");
            sb.Append("  LineNotes: ").Append(LineNotes).Append("\n");
            sb.Append("  ShipmentDetails: ").Append(ShipmentDetails).Append("\n");
            sb.Append("  ServiceContractInfo: ").Append(ServiceContractInfo).Append("\n");
            sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  EstimatedDates: ").Append(EstimatedDates).Append("\n");
            sb.Append("  ScheduleLines: ").Append(ScheduleLines).Append("\n");
            sb.Append("  MultipleShipments: ").Append(MultipleShipments).Append("\n");
            sb.Append("  DefaultCarrierName: ").Append(DefaultCarrierName).Append("\n");
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
