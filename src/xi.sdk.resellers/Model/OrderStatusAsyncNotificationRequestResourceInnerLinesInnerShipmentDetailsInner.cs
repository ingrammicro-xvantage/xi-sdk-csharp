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
    /// OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner
    /// </summary>
    [DataContract(Name = "OrderStatusAsyncNotificationRequest_resource_inner_lines_inner_shipmentDetails_inner")]
    public partial class OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner" /> class.
        /// </summary>
        /// <param name="shipmentDate">The date the line item was shipped..</param>
        /// <param name="shipFromWarehouseId">The ID of the warehouse the product will ship from..</param>
        /// <param name="warehouseName">\&quot;\&quot;.</param>
        /// <param name="carrierCode">The carrier code for the shipment containing the  line item..</param>
        /// <param name="carrierName">The name of the carrier of the shipment containing   the line item..</param>
        /// <param name="packageDetails">packageDetails.</param>
        public OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner(string shipmentDate = default(string), string shipFromWarehouseId = default(string), string warehouseName = default(string), string carrierCode = default(string), string carrierName = default(string), List<OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInnerPackageDetailsInner> packageDetails = default(List<OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInnerPackageDetailsInner>))
        {
            this.ShipmentDate = shipmentDate;
            this.ShipFromWarehouseId = shipFromWarehouseId;
            this.WarehouseName = warehouseName;
            this.CarrierCode = carrierCode;
            this.CarrierName = carrierName;
            this.PackageDetails = packageDetails;
        }

        /// <summary>
        /// The date the line item was shipped.
        /// </summary>
        /// <value>The date the line item was shipped.</value>
        [DataMember(Name = "shipmentDate", EmitDefaultValue = false)]
        public string ShipmentDate { get; set; }

        /// <summary>
        /// The ID of the warehouse the product will ship from.
        /// </summary>
        /// <value>The ID of the warehouse the product will ship from.</value>
        [DataMember(Name = "shipFromWarehouseId", EmitDefaultValue = false)]
        public string ShipFromWarehouseId { get; set; }

        /// <summary>
        /// \&quot;\&quot;
        /// </summary>
        /// <value>\&quot;\&quot;</value>
        [DataMember(Name = "warehouseName", EmitDefaultValue = false)]
        public string WarehouseName { get; set; }

        /// <summary>
        /// The carrier code for the shipment containing the  line item.
        /// </summary>
        /// <value>The carrier code for the shipment containing the  line item.</value>
        [DataMember(Name = "carrierCode", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// The name of the carrier of the shipment containing   the line item.
        /// </summary>
        /// <value>The name of the carrier of the shipment containing   the line item.</value>
        [DataMember(Name = "carrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or Sets PackageDetails
        /// </summary>
        [DataMember(Name = "packageDetails", EmitDefaultValue = false)]
        public List<OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInnerPackageDetailsInner> PackageDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner {\n");
            sb.Append("  ShipmentDate: ").Append(ShipmentDate).Append("\n");
            sb.Append("  ShipFromWarehouseId: ").Append(ShipFromWarehouseId).Append("\n");
            sb.Append("  WarehouseName: ").Append(WarehouseName).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  PackageDetails: ").Append(PackageDetails).Append("\n");
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
