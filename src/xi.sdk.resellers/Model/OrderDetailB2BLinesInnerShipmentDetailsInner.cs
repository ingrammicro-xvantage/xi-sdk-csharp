/*
 * Reseller API
 *
 * For Resellers. <br> Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 6.0
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
    /// OrderDetailB2BLinesInnerShipmentDetailsInner
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner_shipmentDetails_inner")]
    public partial class OrderDetailB2BLinesInnerShipmentDetailsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInnerShipmentDetailsInner" /> class.
        /// </summary>
        /// <param name="quantity">The quantity shipped of the line item..</param>
        /// <param name="deliveryNumber">The actual date of delivery of the line item..</param>
        /// <param name="estimatedShipDate">The date the line item is expected to be shipped..</param>
        /// <param name="shipFromWarehouseId">The ID of the warehouse the product will ship from..</param>
        /// <param name="shipFromLocation">The city and state the line item ships from..</param>
        /// <param name="invoiceNumber">The Ingram Micro invoice number for the line item..</param>
        /// <param name="invoiceDate">The date the IngramMicro invoice was created for the line item..</param>
        /// <param name="carrierDetails">The shipment carrier details for the line item..</param>
        public OrderDetailB2BLinesInnerShipmentDetailsInner(int quantity = default(int), string deliveryNumber = default(string), string estimatedShipDate = default(string), string shipFromWarehouseId = default(string), string shipFromLocation = default(string), string invoiceNumber = default(string), string invoiceDate = default(string), List<OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInner> carrierDetails = default(List<OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInner>))
        {
            this.Quantity = quantity;
            this.DeliveryNumber = deliveryNumber;
            this.EstimatedShipDate = estimatedShipDate;
            this.ShipFromWarehouseId = shipFromWarehouseId;
            this.ShipFromLocation = shipFromLocation;
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceDate = invoiceDate;
            this.CarrierDetails = carrierDetails;
        }

        /// <summary>
        /// The quantity shipped of the line item.
        /// </summary>
        /// <value>The quantity shipped of the line item.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The actual date of delivery of the line item.
        /// </summary>
        /// <value>The actual date of delivery of the line item.</value>
        [DataMember(Name = "deliveryNumber", EmitDefaultValue = false)]
        public string DeliveryNumber { get; set; }

        /// <summary>
        /// The date the line item is expected to be shipped.
        /// </summary>
        /// <value>The date the line item is expected to be shipped.</value>
        [DataMember(Name = "estimatedShipDate", EmitDefaultValue = false)]
        public string EstimatedShipDate { get; set; }

        /// <summary>
        /// The ID of the warehouse the product will ship from.
        /// </summary>
        /// <value>The ID of the warehouse the product will ship from.</value>
        [DataMember(Name = "shipFromWarehouseId", EmitDefaultValue = false)]
        public string ShipFromWarehouseId { get; set; }

        /// <summary>
        /// The city and state the line item ships from.
        /// </summary>
        /// <value>The city and state the line item ships from.</value>
        [DataMember(Name = "shipFromLocation", EmitDefaultValue = false)]
        public string ShipFromLocation { get; set; }

        /// <summary>
        /// The Ingram Micro invoice number for the line item.
        /// </summary>
        /// <value>The Ingram Micro invoice number for the line item.</value>
        [DataMember(Name = "invoiceNumber", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// The date the IngramMicro invoice was created for the line item.
        /// </summary>
        /// <value>The date the IngramMicro invoice was created for the line item.</value>
        [DataMember(Name = "invoiceDate", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// The shipment carrier details for the line item.
        /// </summary>
        /// <value>The shipment carrier details for the line item.</value>
        [DataMember(Name = "carrierDetails", EmitDefaultValue = true)]
        public List<OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInner> CarrierDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInnerShipmentDetailsInner {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  DeliveryNumber: ").Append(DeliveryNumber).Append("\n");
            sb.Append("  EstimatedShipDate: ").Append(EstimatedShipDate).Append("\n");
            sb.Append("  ShipFromWarehouseId: ").Append(ShipFromWarehouseId).Append("\n");
            sb.Append("  ShipFromLocation: ").Append(ShipFromLocation).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  CarrierDetails: ").Append(CarrierDetails).Append("\n");
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
