/*
 * XI Sdk Resellers
 *
 * For Ingram Micro Resellers. Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
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
    /// OrderModifyRequestLinesInner
    /// </summary>
    [DataContract(Name = "OrderModifyRequest_lines_inner")]
    public partial class OrderModifyRequestLinesInner : IValidatableObject
    {
        /// <summary>
        /// The line number that was added, updated, or deleted.
        /// </summary>
        /// <value>The line number that was added, updated, or deleted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AddUpdateDeleteLineEnum
        {
            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            [EnumMember(Value = "UPDATE")]
            UPDATE = 1,

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            [EnumMember(Value = "DELETE")]
            DELETE = 2,

            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            [EnumMember(Value = "ADD")]
            ADD = 3
        }


        /// <summary>
        /// The line number that was added, updated, or deleted.
        /// </summary>
        /// <value>The line number that was added, updated, or deleted.</value>
        [DataMember(Name = "addUpdateDeleteLine", EmitDefaultValue = false)]
        public AddUpdateDeleteLineEnum? AddUpdateDeleteLine { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderModifyRequestLinesInner" /> class.
        /// </summary>
        /// <param name="ingramPartNumber">The unique IngramMicro part number..</param>
        /// <param name="ingramLineNumber">The IngramMicro line number..</param>
        /// <param name="customerLineNumber">The reseller&#39;s line number for reference in their system..</param>
        /// <param name="addUpdateDeleteLine">The line number that was added, updated, or deleted..</param>
        /// <param name="quantity">The quantity of the line item..</param>
        /// <param name="notes">The line-level notes..</param>
        public OrderModifyRequestLinesInner(string ingramPartNumber = default(string), string ingramLineNumber = default(string), string customerLineNumber = default(string), AddUpdateDeleteLineEnum? addUpdateDeleteLine = default(AddUpdateDeleteLineEnum?), int quantity = default(int), string notes = default(string))
        {
            this.IngramPartNumber = ingramPartNumber;
            this.IngramLineNumber = ingramLineNumber;
            this.CustomerLineNumber = customerLineNumber;
            this.AddUpdateDeleteLine = addUpdateDeleteLine;
            this.Quantity = quantity;
            this.Notes = notes;
        }

        /// <summary>
        /// The unique IngramMicro part number.
        /// </summary>
        /// <value>The unique IngramMicro part number.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

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
        /// The quantity of the line item.
        /// </summary>
        /// <value>The quantity of the line item.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The line-level notes.
        /// </summary>
        /// <value>The line-level notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderModifyRequestLinesInner {\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  IngramLineNumber: ").Append(IngramLineNumber).Append("\n");
            sb.Append("  CustomerLineNumber: ").Append(CustomerLineNumber).Append("\n");
            sb.Append("  AddUpdateDeleteLine: ").Append(AddUpdateDeleteLine).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            // IngramPartNumber (string) maxLength
            if (this.IngramPartNumber != null && this.IngramPartNumber.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IngramPartNumber, length must be less than 18.", new [] { "IngramPartNumber" });
            }

            // IngramLineNumber (string) maxLength
            if (this.IngramLineNumber != null && this.IngramLineNumber.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IngramLineNumber, length must be less than 6.", new [] { "IngramLineNumber" });
            }

            // CustomerLineNumber (string) maxLength
            if (this.CustomerLineNumber != null && this.CustomerLineNumber.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerLineNumber, length must be less than 6.", new [] { "CustomerLineNumber" });
            }

            // Notes (string) maxLength
            if (this.Notes != null && this.Notes.Length > 132)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Notes, length must be less than 132.", new [] { "Notes" });
            }

            yield break;
        }
    }

}
