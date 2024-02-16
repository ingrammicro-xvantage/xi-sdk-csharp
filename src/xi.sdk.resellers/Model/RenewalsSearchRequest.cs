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
    /// RenewalsSearchRequest
    /// </summary>
    [DataContract(Name = "renewalsSearchRequest")]
    public partial class RenewalsSearchRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalsSearchRequest" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="vendor">The name of the Vendor..</param>
        /// <param name="endUser">The name of the enduser. .</param>
        public RenewalsSearchRequest(RenewalsSearchRequestStatus status = default(RenewalsSearchRequestStatus), RenewalsSearchRequestDataType dataType = default(RenewalsSearchRequestDataType), string vendor = default(string), string endUser = default(string))
        {
            this.Status = status;
            this.DataType = dataType;
            this.Vendor = vendor;
            this.EndUser = endUser;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public RenewalsSearchRequestStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "dataType", EmitDefaultValue = false)]
        public RenewalsSearchRequestDataType DataType { get; set; }

        /// <summary>
        /// The name of the Vendor.
        /// </summary>
        /// <value>The name of the Vendor.</value>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public string Vendor { get; set; }

        /// <summary>
        /// The name of the enduser. 
        /// </summary>
        /// <value>The name of the enduser. </value>
        [DataMember(Name = "endUser", EmitDefaultValue = false)]
        public string EndUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewalsSearchRequest {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  EndUser: ").Append(EndUser).Append("\n");
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
