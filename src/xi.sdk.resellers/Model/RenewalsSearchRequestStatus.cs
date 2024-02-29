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
    /// RenewalsSearchRequestStatus
    /// </summary>
    [DataContract(Name = "renewalsSearchRequest_status")]
    public partial class RenewalsSearchRequestStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalsSearchRequestStatus" /> class.
        /// </summary>
        /// <param name="opporutinyStatus">opporutinyStatus.</param>
        public RenewalsSearchRequestStatus(RenewalsSearchRequestStatusOpporutinyStatus opporutinyStatus = default(RenewalsSearchRequestStatusOpporutinyStatus))
        {
            this.OpporutinyStatus = opporutinyStatus;
        }

        /// <summary>
        /// Gets or Sets OpporutinyStatus
        /// </summary>
        [DataMember(Name = "OpporutinyStatus", EmitDefaultValue = false)]
        public RenewalsSearchRequestStatusOpporutinyStatus OpporutinyStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewalsSearchRequestStatus {\n");
            sb.Append("  OpporutinyStatus: ").Append(OpporutinyStatus).Append("\n");
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
