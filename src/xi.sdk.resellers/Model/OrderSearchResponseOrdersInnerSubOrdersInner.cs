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
    /// OrderSearchResponseOrdersInnerSubOrdersInner
    /// </summary>
    [DataContract(Name = "OrderSearch_Response_orders_inner_subOrders_inner")]
    public partial class OrderSearchResponseOrdersInnerSubOrdersInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSearchResponseOrdersInnerSubOrdersInner" /> class.
        /// </summary>
        /// <param name="subOrderNumber">The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest to the reseller. The middle number is the order number. The two-digit suffix is the sub order number..</param>
        /// <param name="subOrderTotal">The total for the suborder..</param>
        /// <param name="subOrderStatus">The status of the suborder. One of:- Shipped, Canceled, Backordered, Processing, On Hold, Delivered.</param>
        /// <param name="links">Link to Order Details for the sub order(s)..</param>
        public OrderSearchResponseOrdersInnerSubOrdersInner(string subOrderNumber = default(string), decimal subOrderTotal = default(decimal), string subOrderStatus = default(string), List<OrderSearchResponseOrdersInnerSubOrdersInnerLinksInner> links = default(List<OrderSearchResponseOrdersInnerSubOrdersInnerLinksInner>))
        {
            this.SubOrderNumber = subOrderNumber;
            this.SubOrderTotal = subOrderTotal;
            this.SubOrderStatus = subOrderStatus;
            this.Links = links;
        }

        /// <summary>
        /// The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest to the reseller. The middle number is the order number. The two-digit suffix is the sub order number.
        /// </summary>
        /// <value>The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest to the reseller. The middle number is the order number. The two-digit suffix is the sub order number.</value>
        [DataMember(Name = "subOrderNumber", EmitDefaultValue = false)]
        public string SubOrderNumber { get; set; }

        /// <summary>
        /// The total for the suborder.
        /// </summary>
        /// <value>The total for the suborder.</value>
        [DataMember(Name = "subOrderTotal", EmitDefaultValue = false)]
        public decimal SubOrderTotal { get; set; }

        /// <summary>
        /// The status of the suborder. One of:- Shipped, Canceled, Backordered, Processing, On Hold, Delivered
        /// </summary>
        /// <value>The status of the suborder. One of:- Shipped, Canceled, Backordered, Processing, On Hold, Delivered</value>
        [DataMember(Name = "subOrderStatus", EmitDefaultValue = false)]
        public string SubOrderStatus { get; set; }

        /// <summary>
        /// Link to Order Details for the sub order(s).
        /// </summary>
        /// <value>Link to Order Details for the sub order(s).</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<OrderSearchResponseOrdersInnerSubOrdersInnerLinksInner> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderSearchResponseOrdersInnerSubOrdersInner {\n");
            sb.Append("  SubOrderNumber: ").Append(SubOrderNumber).Append("\n");
            sb.Append("  SubOrderTotal: ").Append(SubOrderTotal).Append("\n");
            sb.Append("  SubOrderStatus: ").Append(SubOrderStatus).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
