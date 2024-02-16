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
    /// OrderModifyResponseLinesInner
    /// </summary>
    [DataContract(Name = "OrderModifyResponse_lines_inner")]
    public partial class OrderModifyResponseLinesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderModifyResponseLinesInner" /> class.
        /// </summary>
        /// <param name="subOrderNumber">The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number..</param>
        /// <param name="ingramLineNumber">The IngramMicro line number..</param>
        /// <param name="customerLineNumber">The reseller&#39;s line number for reference in their system..</param>
        /// <param name="ingramPartNumber">The unique IngramMicro part number for the line item..</param>
        /// <param name="vendorPartNumber">The vendor&#39;s part number for the line item..</param>
        /// <param name="quantityOrdered">The quantity ordered of the line item..</param>
        /// <param name="quantityConfirmed">The quantity confirmed of the line item..</param>
        /// <param name="quantityBackOrdered">The quantity backordered of the line item..</param>
        /// <param name="shipmentDetails">shipmentDetails.</param>
        /// <param name="additionalAttributes">SAP requested and country-specific line level details..</param>
        /// <param name="notes">Line-level notes for the order..</param>
        public OrderModifyResponseLinesInner(string subOrderNumber = default(string), string ingramLineNumber = default(string), string customerLineNumber = default(string), string ingramPartNumber = default(string), string vendorPartNumber = default(string), int quantityOrdered = default(int), int quantityConfirmed = default(int), int quantityBackOrdered = default(int), OrderModifyResponseLinesInnerShipmentDetails shipmentDetails = default(OrderModifyResponseLinesInnerShipmentDetails), List<OrderModifyResponseLinesInnerAdditionalAttributesInner> additionalAttributes = default(List<OrderModifyResponseLinesInnerAdditionalAttributesInner>), string notes = default(string))
        {
            this.SubOrderNumber = subOrderNumber;
            this.IngramLineNumber = ingramLineNumber;
            this.CustomerLineNumber = customerLineNumber;
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.QuantityOrdered = quantityOrdered;
            this.QuantityConfirmed = quantityConfirmed;
            this.QuantityBackOrdered = quantityBackOrdered;
            this.ShipmentDetails = shipmentDetails;
            this.AdditionalAttributes = additionalAttributes;
            this.Notes = notes;
        }

        /// <summary>
        /// The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number.
        /// </summary>
        /// <value>The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number.</value>
        [DataMember(Name = "subOrderNumber", EmitDefaultValue = false)]
        public string SubOrderNumber { get; set; }

        /// <summary>
        /// The IngramMicro line number.
        /// </summary>
        /// <value>The IngramMicro line number.</value>
        [DataMember(Name = "ingramLineNumber", EmitDefaultValue = false)]
        public string IngramLineNumber { get; set; }

        /// <summary>
        /// The reseller&#39;s line number for reference in their system.
        /// </summary>
        /// <value>The reseller&#39;s line number for reference in their system.</value>
        [DataMember(Name = "customerLineNumber", EmitDefaultValue = false)]
        public string CustomerLineNumber { get; set; }

        /// <summary>
        /// The unique IngramMicro part number for the line item.
        /// </summary>
        /// <value>The unique IngramMicro part number for the line item.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// The vendor&#39;s part number for the line item.
        /// </summary>
        /// <value>The vendor&#39;s part number for the line item.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// The quantity ordered of the line item.
        /// </summary>
        /// <value>The quantity ordered of the line item.</value>
        [DataMember(Name = "quantityOrdered", EmitDefaultValue = false)]
        public int QuantityOrdered { get; set; }

        /// <summary>
        /// The quantity confirmed of the line item.
        /// </summary>
        /// <value>The quantity confirmed of the line item.</value>
        [DataMember(Name = "quantityConfirmed", EmitDefaultValue = false)]
        public int QuantityConfirmed { get; set; }

        /// <summary>
        /// The quantity backordered of the line item.
        /// </summary>
        /// <value>The quantity backordered of the line item.</value>
        [DataMember(Name = "quantityBackOrdered", EmitDefaultValue = false)]
        public int QuantityBackOrdered { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentDetails
        /// </summary>
        [DataMember(Name = "shipmentDetails", EmitDefaultValue = false)]
        public OrderModifyResponseLinesInnerShipmentDetails ShipmentDetails { get; set; }

        /// <summary>
        /// SAP requested and country-specific line level details.
        /// </summary>
        /// <value>SAP requested and country-specific line level details.</value>
        [DataMember(Name = "additionalAttributes", EmitDefaultValue = false)]
        public List<OrderModifyResponseLinesInnerAdditionalAttributesInner> AdditionalAttributes { get; set; }

        /// <summary>
        /// Line-level notes for the order.
        /// </summary>
        /// <value>Line-level notes for the order.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderModifyResponseLinesInner {\n");
            sb.Append("  SubOrderNumber: ").Append(SubOrderNumber).Append("\n");
            sb.Append("  IngramLineNumber: ").Append(IngramLineNumber).Append("\n");
            sb.Append("  CustomerLineNumber: ").Append(CustomerLineNumber).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  QuantityOrdered: ").Append(QuantityOrdered).Append("\n");
            sb.Append("  QuantityConfirmed: ").Append(QuantityConfirmed).Append("\n");
            sb.Append("  QuantityBackOrdered: ").Append(QuantityBackOrdered).Append("\n");
            sb.Append("  ShipmentDetails: ").Append(ShipmentDetails).Append("\n");
            sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
