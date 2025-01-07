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
    /// OrderCreateRequestLinesInnerWarrantyInfoInner
    /// </summary>
    [DataContract(Name = "OrderCreateRequest_lines_inner_warrantyInfo_inner")]
    public partial class OrderCreateRequestLinesInnerWarrantyInfoInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestLinesInnerWarrantyInfoInner" /> class.
        /// </summary>
        /// <param name="directLineLink">Unique value to link hardware and warranty lines. Should be used only when products are purchased from both Ingram and/or vendor but the warranty is purchased through Ingram for them..</param>
        /// <param name="warrantyLineLink">Customer line number of the hardware product in this request for linkage, either hardwareLineLink or warrantyLineLink can be used in a line..</param>
        /// <param name="hardwareLineLink">Customer line number of the warranty product in this request for linkage, either hardwareLineLink or warrantyLineLink can be used in a line .</param>
        /// <param name="serialInfo">Serial information of the hardware to be associated with the warranty, applicable on post sale orders..</param>
        public OrderCreateRequestLinesInnerWarrantyInfoInner(string directLineLink = default(string), string warrantyLineLink = default(string), string hardwareLineLink = default(string), List<OrderCreateRequestLinesInnerWarrantyInfoInnerSerialInfoInner> serialInfo = default(List<OrderCreateRequestLinesInnerWarrantyInfoInnerSerialInfoInner>))
        {
            this.DirectLineLink = directLineLink;
            this.WarrantyLineLink = warrantyLineLink;
            this.HardwareLineLink = hardwareLineLink;
            this.SerialInfo = serialInfo;
        }

        /// <summary>
        /// Unique value to link hardware and warranty lines. Should be used only when products are purchased from both Ingram and/or vendor but the warranty is purchased through Ingram for them.
        /// </summary>
        /// <value>Unique value to link hardware and warranty lines. Should be used only when products are purchased from both Ingram and/or vendor but the warranty is purchased through Ingram for them.</value>
        [DataMember(Name = "directLineLink", EmitDefaultValue = false)]
        public string DirectLineLink { get; set; }

        /// <summary>
        /// Customer line number of the hardware product in this request for linkage, either hardwareLineLink or warrantyLineLink can be used in a line.
        /// </summary>
        /// <value>Customer line number of the hardware product in this request for linkage, either hardwareLineLink or warrantyLineLink can be used in a line.</value>
        [DataMember(Name = "warrantyLineLink", EmitDefaultValue = false)]
        public string WarrantyLineLink { get; set; }

        /// <summary>
        /// Customer line number of the warranty product in this request for linkage, either hardwareLineLink or warrantyLineLink can be used in a line 
        /// </summary>
        /// <value>Customer line number of the warranty product in this request for linkage, either hardwareLineLink or warrantyLineLink can be used in a line </value>
        [DataMember(Name = "hardwareLineLink", EmitDefaultValue = false)]
        public string HardwareLineLink { get; set; }

        /// <summary>
        /// Serial information of the hardware to be associated with the warranty, applicable on post sale orders.
        /// </summary>
        /// <value>Serial information of the hardware to be associated with the warranty, applicable on post sale orders.</value>
        [DataMember(Name = "serialInfo", EmitDefaultValue = false)]
        public List<OrderCreateRequestLinesInnerWarrantyInfoInnerSerialInfoInner> SerialInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequestLinesInnerWarrantyInfoInner {\n");
            sb.Append("  DirectLineLink: ").Append(DirectLineLink).Append("\n");
            sb.Append("  WarrantyLineLink: ").Append(WarrantyLineLink).Append("\n");
            sb.Append("  HardwareLineLink: ").Append(HardwareLineLink).Append("\n");
            sb.Append("  SerialInfo: ").Append(SerialInfo).Append("\n");
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
            // DirectLineLink (string) maxLength
            if (this.DirectLineLink != null && this.DirectLineLink.Length > 25)
            {
                yield return new ValidationResult("Invalid value for DirectLineLink, length must be less than 25.", new [] { "DirectLineLink" });
            }

            yield break;
        }
    }

}
