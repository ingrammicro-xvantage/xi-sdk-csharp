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
    /// ReturnsCreateResponseReturnsClaimsInner
    /// </summary>
    [DataContract(Name = "returnsCreateResponse_returnsClaims_inner")]
    public partial class ReturnsCreateResponseReturnsClaimsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsCreateResponseReturnsClaimsInner" /> class.
        /// </summary>
        /// <param name="rmaClaimId">The rmaClaimId claim id..</param>
        /// <param name="caseRequestNumber">A unique return request number..</param>
        /// <param name="referenceNumber">The reference number for the return..</param>
        /// <param name="createdOn">The date on which the return request was created. .</param>
        /// <param name="type">Type of request..</param>
        /// <param name="returnReason">The reason for the return..</param>
        /// <param name="ingramPartNumber">Unique line number from Ingram..</param>
        /// <param name="vendorPartNumber">Vendor Part Number..</param>
        /// <param name="quantity">Return quantity of the product..</param>
        /// <param name="notes">Return notes..</param>
        /// <param name="estimatedTotalValue">The estimated total value of the return..</param>
        /// <param name="credit">The amount of credit..</param>
        /// <param name="status">The status of the request..</param>
        /// <param name="links">links.</param>
        public ReturnsCreateResponseReturnsClaimsInner(string rmaClaimId = default(string), string caseRequestNumber = default(string), string referenceNumber = default(string), DateOnly createdOn = default(DateOnly), string type = default(string), string returnReason = default(string), string ingramPartNumber = default(string), string vendorPartNumber = default(string), int quantity = default(int), string notes = default(string), decimal estimatedTotalValue = default(decimal), decimal credit = default(decimal), string status = default(string), List<ReturnsSearchResponseReturnsClaimsInnerLinksInner> links = default(List<ReturnsSearchResponseReturnsClaimsInnerLinksInner>))
        {
            this.RmaClaimId = rmaClaimId;
            this.CaseRequestNumber = caseRequestNumber;
            this.ReferenceNumber = referenceNumber;
            this.CreatedOn = createdOn;
            this.Type = type;
            this.ReturnReason = returnReason;
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.Quantity = quantity;
            this.Notes = notes;
            this.EstimatedTotalValue = estimatedTotalValue;
            this.Credit = credit;
            this.Status = status;
            this.Links = links;
        }

        /// <summary>
        /// The rmaClaimId claim id.
        /// </summary>
        /// <value>The rmaClaimId claim id.</value>
        [DataMember(Name = "rmaClaimId", EmitDefaultValue = false)]
        public string RmaClaimId { get; set; }

        /// <summary>
        /// A unique return request number.
        /// </summary>
        /// <value>A unique return request number.</value>
        [DataMember(Name = "caseRequestNumber", EmitDefaultValue = false)]
        public string CaseRequestNumber { get; set; }

        /// <summary>
        /// The reference number for the return.
        /// </summary>
        /// <value>The reference number for the return.</value>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The date on which the return request was created. 
        /// </summary>
        /// <value>The date on which the return request was created. </value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateOnly CreatedOn { get; set; }

        /// <summary>
        /// Type of request.
        /// </summary>
        /// <value>Type of request.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The reason for the return.
        /// </summary>
        /// <value>The reason for the return.</value>
        [DataMember(Name = "returnReason", EmitDefaultValue = false)]
        public string ReturnReason { get; set; }

        /// <summary>
        /// Unique line number from Ingram.
        /// </summary>
        /// <value>Unique line number from Ingram.</value>
        [DataMember(Name = "ingramPartNumber", EmitDefaultValue = false)]
        public string IngramPartNumber { get; set; }

        /// <summary>
        /// Vendor Part Number.
        /// </summary>
        /// <value>Vendor Part Number.</value>
        [DataMember(Name = "vendorPartNumber", EmitDefaultValue = false)]
        public string VendorPartNumber { get; set; }

        /// <summary>
        /// Return quantity of the product.
        /// </summary>
        /// <value>Return quantity of the product.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Return notes.
        /// </summary>
        /// <value>Return notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// The estimated total value of the return.
        /// </summary>
        /// <value>The estimated total value of the return.</value>
        [DataMember(Name = "estimatedTotalValue", EmitDefaultValue = false)]
        public decimal EstimatedTotalValue { get; set; }

        /// <summary>
        /// The amount of credit.
        /// </summary>
        /// <value>The amount of credit.</value>
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        public decimal Credit { get; set; }

        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <value>The status of the request.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<ReturnsSearchResponseReturnsClaimsInnerLinksInner> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReturnsCreateResponseReturnsClaimsInner {\n");
            sb.Append("  RmaClaimId: ").Append(RmaClaimId).Append("\n");
            sb.Append("  CaseRequestNumber: ").Append(CaseRequestNumber).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReturnReason: ").Append(ReturnReason).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  EstimatedTotalValue: ").Append(EstimatedTotalValue).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
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
