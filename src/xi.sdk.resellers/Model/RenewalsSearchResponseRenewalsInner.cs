/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of APIs and webhooks to craft a seamless journey for your customers.
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
    /// RenewalsSearchResponseRenewalsInner
    /// </summary>
    [DataContract(Name = "renewalsSearchResponse_renewals_inner")]
    public partial class RenewalsSearchResponseRenewalsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalsSearchResponseRenewalsInner" /> class.
        /// </summary>
        /// <param name="renewalId">Unique renewal ID..</param>
        /// <param name="customerOrderNumber">The reseller&#39;s order number for reference in their system..</param>
        /// <param name="referenceNumber">Renewal reference number. It could be notification id or quote number..</param>
        /// <param name="endUser">The company name for the end user/customer..</param>
        /// <param name="vendor">The name of the vendor..</param>
        /// <param name="expirationDate">Renewal expiration date..</param>
        /// <param name="renewalValue">The value of the renewal..</param>
        /// <param name="status">The status of the renewal..</param>
        /// <param name="links">links.</param>
        public RenewalsSearchResponseRenewalsInner(int renewalId = default(int), string customerOrderNumber = default(string), string referenceNumber = default(string), string endUser = default(string), string vendor = default(string), string expirationDate = default(string), double renewalValue = default(double), string status = default(string), List<RenewalsSearchResponseRenewalsInnerLinksInner> links = default(List<RenewalsSearchResponseRenewalsInnerLinksInner>))
        {
            this.RenewalId = renewalId;
            this.CustomerOrderNumber = customerOrderNumber;
            this.ReferenceNumber = referenceNumber;
            this.EndUser = endUser;
            this.Vendor = vendor;
            this.ExpirationDate = expirationDate;
            this.RenewalValue = renewalValue;
            this.Status = status;
            this.Links = links;
        }

        /// <summary>
        /// Unique renewal ID.
        /// </summary>
        /// <value>Unique renewal ID.</value>
        [DataMember(Name = "renewalId", EmitDefaultValue = false)]
        public int RenewalId { get; set; }

        /// <summary>
        /// The reseller&#39;s order number for reference in their system.
        /// </summary>
        /// <value>The reseller&#39;s order number for reference in their system.</value>
        [DataMember(Name = "customerOrderNumber", EmitDefaultValue = false)]
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// Renewal reference number. It could be notification id or quote number.
        /// </summary>
        /// <value>Renewal reference number. It could be notification id or quote number.</value>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The company name for the end user/customer.
        /// </summary>
        /// <value>The company name for the end user/customer.</value>
        [DataMember(Name = "endUser", EmitDefaultValue = false)]
        public string EndUser { get; set; }

        /// <summary>
        /// The name of the vendor.
        /// </summary>
        /// <value>The name of the vendor.</value>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Renewal expiration date.
        /// </summary>
        /// <value>Renewal expiration date.</value>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// The value of the renewal.
        /// </summary>
        /// <value>The value of the renewal.</value>
        [DataMember(Name = "renewalValue", EmitDefaultValue = false)]
        public double RenewalValue { get; set; }

        /// <summary>
        /// The status of the renewal.
        /// </summary>
        /// <value>The status of the renewal.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<RenewalsSearchResponseRenewalsInnerLinksInner> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewalsSearchResponseRenewalsInner {\n");
            sb.Append("  RenewalId: ").Append(RenewalId).Append("\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  EndUser: ").Append(EndUser).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  RenewalValue: ").Append(RenewalValue).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
