/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    /// OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner_serviceContractInfo_licenseInfo")]
    public partial class OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo" /> class.
        /// </summary>
        /// <param name="licenseNumber">License numbers..</param>
        /// <param name="licenseStartDate">Start Date of the license..</param>
        /// <param name="licenseEndDate">End Date of the license..</param>
        /// <param name="description">Description of the license..</param>
        /// <param name="quantity">Quantity of the license..</param>
        public OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo(List<string> licenseNumber = default(List<string>), string licenseStartDate = default(string), string licenseEndDate = default(string), string description = default(string), string quantity = default(string))
        {
            this.LicenseNumber = licenseNumber;
            this.LicenseStartDate = licenseStartDate;
            this.LicenseEndDate = licenseEndDate;
            this.Description = description;
            this.Quantity = quantity;
        }

        /// <summary>
        /// License numbers.
        /// </summary>
        /// <value>License numbers.</value>
        [DataMember(Name = "licenseNumber", EmitDefaultValue = true)]
        public List<string> LicenseNumber { get; set; }

        /// <summary>
        /// Start Date of the license.
        /// </summary>
        /// <value>Start Date of the license.</value>
        [DataMember(Name = "licenseStartDate", EmitDefaultValue = false)]
        public string LicenseStartDate { get; set; }

        /// <summary>
        /// End Date of the license.
        /// </summary>
        /// <value>End Date of the license.</value>
        [DataMember(Name = "licenseEndDate", EmitDefaultValue = false)]
        public string LicenseEndDate { get; set; }

        /// <summary>
        /// Description of the license.
        /// </summary>
        /// <value>Description of the license.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Quantity of the license.
        /// </summary>
        /// <value>Quantity of the license.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo {\n");
            sb.Append("  LicenseNumber: ").Append(LicenseNumber).Append("\n");
            sb.Append("  LicenseStartDate: ").Append(LicenseStartDate).Append("\n");
            sb.Append("  LicenseEndDate: ").Append(LicenseEndDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
