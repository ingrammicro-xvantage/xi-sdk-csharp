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
    /// OrderDetailB2BLinesInnerMultipleShipmentsInner
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner_multipleShipments_inner")]
    public partial class OrderDetailB2BLinesInnerMultipleShipmentsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInnerMultipleShipmentsInner" /> class.
        /// </summary>
        /// <param name="lineNumber">Line number..</param>
        /// <param name="requestedQuantity">Requested quantity..</param>
        /// <param name="confirmedQuantity">Confirmed quantity..</param>
        /// <param name="dataType">Date type. Example Single or multiple dates..</param>
        /// <param name="dateRange">dateRange.</param>
        /// <param name="source">Source..</param>
        /// <param name="description">Description..</param>
        /// <param name="date">Date..</param>
        /// <param name="deliveryDate">Delivery date..</param>
        public OrderDetailB2BLinesInnerMultipleShipmentsInner(string lineNumber = default(string), string requestedQuantity = default(string), string confirmedQuantity = default(string), string dataType = default(string), OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange dateRange = default(OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange), string source = default(string), string description = default(string), string date = default(string), string deliveryDate = default(string))
        {
            this.LineNumber = lineNumber;
            this.RequestedQuantity = requestedQuantity;
            this.ConfirmedQuantity = confirmedQuantity;
            this.DataType = dataType;
            this.DateRange = dateRange;
            this.Source = source;
            this.Description = description;
            this.Date = date;
            this.DeliveryDate = deliveryDate;
        }

        /// <summary>
        /// Line number.
        /// </summary>
        /// <value>Line number.</value>
        [DataMember(Name = "lineNumber", EmitDefaultValue = false)]
        public string LineNumber { get; set; }

        /// <summary>
        /// Requested quantity.
        /// </summary>
        /// <value>Requested quantity.</value>
        [DataMember(Name = "requestedQuantity", EmitDefaultValue = false)]
        public string RequestedQuantity { get; set; }

        /// <summary>
        /// Confirmed quantity.
        /// </summary>
        /// <value>Confirmed quantity.</value>
        [DataMember(Name = "confirmedQuantity", EmitDefaultValue = false)]
        public string ConfirmedQuantity { get; set; }

        /// <summary>
        /// Date type. Example Single or multiple dates.
        /// </summary>
        /// <value>Date type. Example Single or multiple dates.</value>
        [DataMember(Name = "dataType", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets DateRange
        /// </summary>
        [DataMember(Name = "dateRange", EmitDefaultValue = false)]
        public OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange DateRange { get; set; }

        /// <summary>
        /// Source.
        /// </summary>
        /// <value>Source.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        /// <value>Description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Date.
        /// </summary>
        /// <value>Date.</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// Delivery date.
        /// </summary>
        /// <value>Delivery date.</value>
        [DataMember(Name = "deliveryDate", EmitDefaultValue = false)]
        public string DeliveryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInnerMultipleShipmentsInner {\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  RequestedQuantity: ").Append(RequestedQuantity).Append("\n");
            sb.Append("  ConfirmedQuantity: ").Append(ConfirmedQuantity).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  DateRange: ").Append(DateRange).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
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
