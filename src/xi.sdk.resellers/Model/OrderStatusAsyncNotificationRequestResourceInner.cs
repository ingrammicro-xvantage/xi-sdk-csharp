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
    /// OrderStatusAsyncNotificationRequestResourceInner
    /// </summary>
    [DataContract(Name = "OrderStatusAsyncNotificationRequest_resource_inner")]
    public partial class OrderStatusAsyncNotificationRequestResourceInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderStatusAsyncNotificationRequestResourceInner" /> class.
        /// </summary>
        /// <param name="eventType">The event name sent in the event request..</param>
        /// <param name="orderNumber">The Ingram Micro order number..</param>
        /// <param name="customerOrderNumber">The reseller&#39;s unique PO/Order number..</param>
        /// <param name="orderEntryTimeStamp">The timestamp at which the order was created..</param>
        /// <param name="lines">The line-level details for the order..</param>
        /// <param name="links">Link to Order Details for the order(s)..</param>
        public OrderStatusAsyncNotificationRequestResourceInner(string eventType = default(string), string orderNumber = default(string), string customerOrderNumber = default(string), string orderEntryTimeStamp = default(string), List<OrderStatusAsyncNotificationRequestResourceInnerLinesInner> lines = default(List<OrderStatusAsyncNotificationRequestResourceInnerLinesInner>), List<OrderStatusAsyncNotificationRequestResourceInnerLinksInner> links = default(List<OrderStatusAsyncNotificationRequestResourceInnerLinksInner>))
        {
            this.EventType = eventType;
            this.OrderNumber = orderNumber;
            this.CustomerOrderNumber = customerOrderNumber;
            this.OrderEntryTimeStamp = orderEntryTimeStamp;
            this.Lines = lines;
            this.Links = links;
        }

        /// <summary>
        /// The event name sent in the event request.
        /// </summary>
        /// <value>The event name sent in the event request.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// The Ingram Micro order number.
        /// </summary>
        /// <value>The Ingram Micro order number.</value>
        [DataMember(Name = "orderNumber", EmitDefaultValue = false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The reseller&#39;s unique PO/Order number.
        /// </summary>
        /// <value>The reseller&#39;s unique PO/Order number.</value>
        [DataMember(Name = "customerOrderNumber", EmitDefaultValue = false)]
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// The timestamp at which the order was created.
        /// </summary>
        /// <value>The timestamp at which the order was created.</value>
        [DataMember(Name = "orderEntryTimeStamp", EmitDefaultValue = false)]
        public string OrderEntryTimeStamp { get; set; }

        /// <summary>
        /// The line-level details for the order.
        /// </summary>
        /// <value>The line-level details for the order.</value>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        public List<OrderStatusAsyncNotificationRequestResourceInnerLinesInner> Lines { get; set; }

        /// <summary>
        /// Link to Order Details for the order(s).
        /// </summary>
        /// <value>Link to Order Details for the order(s).</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<OrderStatusAsyncNotificationRequestResourceInnerLinksInner> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderStatusAsyncNotificationRequestResourceInner {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
            sb.Append("  OrderEntryTimeStamp: ").Append(OrderEntryTimeStamp).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
