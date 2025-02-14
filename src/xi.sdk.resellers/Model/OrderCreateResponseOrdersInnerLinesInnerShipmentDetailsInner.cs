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
    /// OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner
    /// </summary>
    [DataContract(Name = "OrderCreateResponse_orders_inner_lines_inner_shipmentDetails_inner")]
    public partial class OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner" /> class.
        /// </summary>
        /// <param name="carrierCode">The code for the shipping carrier for the line item..</param>
        /// <param name="carrierName">The name of the shipping carrier for the line item..</param>
        /// <param name="shipFromWarehouseId">The ID of the warehouse the line item will ship from..</param>
        /// <param name="shipFromLocation">Location from which order is shipped..</param>
        /// <param name="freightAccountNumber">The reseller&#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier..</param>
        /// <param name="signatureRequired">Specifies whether a signature is required for delivery. Default is False..</param>
        /// <param name="shippingInstructions">The shipping instructions for the order..</param>
        public OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner(string carrierCode = default(string), string carrierName = default(string), string shipFromWarehouseId = default(string), string shipFromLocation = default(string), string freightAccountNumber = default(string), string signatureRequired = default(string), string shippingInstructions = default(string))
        {
            this.CarrierCode = carrierCode;
            this.CarrierName = carrierName;
            this.ShipFromWarehouseId = shipFromWarehouseId;
            this.ShipFromLocation = shipFromLocation;
            this.FreightAccountNumber = freightAccountNumber;
            this.SignatureRequired = signatureRequired;
            this.ShippingInstructions = shippingInstructions;
        }

        /// <summary>
        /// The code for the shipping carrier for the line item.
        /// </summary>
        /// <value>The code for the shipping carrier for the line item.</value>
        [DataMember(Name = "carrierCode", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// The name of the shipping carrier for the line item.
        /// </summary>
        /// <value>The name of the shipping carrier for the line item.</value>
        [DataMember(Name = "carrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// The ID of the warehouse the line item will ship from.
        /// </summary>
        /// <value>The ID of the warehouse the line item will ship from.</value>
        [DataMember(Name = "shipFromWarehouseId", EmitDefaultValue = false)]
        public string ShipFromWarehouseId { get; set; }

        /// <summary>
        /// Location from which order is shipped.
        /// </summary>
        /// <value>Location from which order is shipped.</value>
        [DataMember(Name = "shipFromLocation", EmitDefaultValue = false)]
        public string ShipFromLocation { get; set; }

        /// <summary>
        /// The reseller&#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier.
        /// </summary>
        /// <value>The reseller&#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier.</value>
        [DataMember(Name = "freightAccountNumber", EmitDefaultValue = false)]
        public string FreightAccountNumber { get; set; }

        /// <summary>
        /// Specifies whether a signature is required for delivery. Default is False.
        /// </summary>
        /// <value>Specifies whether a signature is required for delivery. Default is False.</value>
        [DataMember(Name = "signatureRequired", EmitDefaultValue = false)]
        public string SignatureRequired { get; set; }

        /// <summary>
        /// The shipping instructions for the order.
        /// </summary>
        /// <value>The shipping instructions for the order.</value>
        [DataMember(Name = "shippingInstructions", EmitDefaultValue = false)]
        public string ShippingInstructions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner {\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  ShipFromWarehouseId: ").Append(ShipFromWarehouseId).Append("\n");
            sb.Append("  ShipFromLocation: ").Append(ShipFromLocation).Append("\n");
            sb.Append("  FreightAccountNumber: ").Append(FreightAccountNumber).Append("\n");
            sb.Append("  SignatureRequired: ").Append(SignatureRequired).Append("\n");
            sb.Append("  ShippingInstructions: ").Append(ShippingInstructions).Append("\n");
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
