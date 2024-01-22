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
    /// OrderModifyRequestServicerequestOrdermodifyrequestLinedataInner
    /// </summary>
    [DataContract(Name = "orderModifyRequest_servicerequest_ordermodifyrequest_linedata_inner")]
    public partial class OrderModifyRequestServicerequestOrdermodifyrequestLinedataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderModifyRequestServicerequestOrdermodifyrequestLinedataInner" /> class.
        /// </summary>
        /// <param name="addlineorupdateline">addlineorupdateline.</param>
        /// <param name="linenumber">linenumber.</param>
        /// <param name="customerlinenumber">customerlinenumber.</param>
        /// <param name="ingrampartnumber">ingrampartnumber.</param>
        /// <param name="quantityordered">quantityordered.</param>
        /// <param name="customerpartnumber">customerpartnumber.</param>
        /// <param name="linetype">linetype.</param>
        public OrderModifyRequestServicerequestOrdermodifyrequestLinedataInner(string addlineorupdateline = default(string), string linenumber = default(string), string customerlinenumber = default(string), string ingrampartnumber = default(string), int quantityordered = default(int), string customerpartnumber = default(string), string linetype = default(string))
        {
            this.Addlineorupdateline = addlineorupdateline;
            this.Linenumber = linenumber;
            this.Customerlinenumber = customerlinenumber;
            this.Ingrampartnumber = ingrampartnumber;
            this.Quantityordered = quantityordered;
            this.Customerpartnumber = customerpartnumber;
            this.Linetype = linetype;
        }

        /// <summary>
        /// Gets or Sets Addlineorupdateline
        /// </summary>
        [DataMember(Name = "addlineorupdateline", EmitDefaultValue = false)]
        public string Addlineorupdateline { get; set; }

        /// <summary>
        /// Gets or Sets Linenumber
        /// </summary>
        [DataMember(Name = "linenumber", EmitDefaultValue = false)]
        public string Linenumber { get; set; }

        /// <summary>
        /// Gets or Sets Customerlinenumber
        /// </summary>
        [DataMember(Name = "customerlinenumber", EmitDefaultValue = false)]
        public string Customerlinenumber { get; set; }

        /// <summary>
        /// Gets or Sets Ingrampartnumber
        /// </summary>
        [DataMember(Name = "ingrampartnumber", EmitDefaultValue = false)]
        public string Ingrampartnumber { get; set; }

        /// <summary>
        /// Gets or Sets Quantityordered
        /// </summary>
        [DataMember(Name = "quantityordered", EmitDefaultValue = false)]
        public int Quantityordered { get; set; }

        /// <summary>
        /// Gets or Sets Customerpartnumber
        /// </summary>
        [DataMember(Name = "customerpartnumber", EmitDefaultValue = false)]
        public string Customerpartnumber { get; set; }

        /// <summary>
        /// Gets or Sets Linetype
        /// </summary>
        [DataMember(Name = "linetype", EmitDefaultValue = false)]
        public string Linetype { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderModifyRequestServicerequestOrdermodifyrequestLinedataInner {\n");
            sb.Append("  Addlineorupdateline: ").Append(Addlineorupdateline).Append("\n");
            sb.Append("  Linenumber: ").Append(Linenumber).Append("\n");
            sb.Append("  Customerlinenumber: ").Append(Customerlinenumber).Append("\n");
            sb.Append("  Ingrampartnumber: ").Append(Ingrampartnumber).Append("\n");
            sb.Append("  Quantityordered: ").Append(Quantityordered).Append("\n");
            sb.Append("  Customerpartnumber: ").Append(Customerpartnumber).Append("\n");
            sb.Append("  Linetype: ").Append(Linetype).Append("\n");
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
