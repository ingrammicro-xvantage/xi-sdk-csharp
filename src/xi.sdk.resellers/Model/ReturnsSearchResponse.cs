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
    /// ReturnsSearchResponse
    /// </summary>
    [DataContract(Name = "returnsSearchResponse")]
    public partial class ReturnsSearchResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsSearchResponse" /> class.
        /// </summary>
        /// <param name="recordsFound">Number of records found..</param>
        /// <param name="pageSize">Number of records in a page..</param>
        /// <param name="pageNumber">Number of page..</param>
        /// <param name="returnsClaims">returnsClaims.</param>
        /// <param name="nextPage">URL for the next page..</param>
        /// <param name="previousPage">URL for the previous page..</param>
        public ReturnsSearchResponse(int recordsFound = default(int), int pageSize = default(int), int pageNumber = default(int), List<ReturnsSearchResponseReturnsClaimsInner> returnsClaims = default(List<ReturnsSearchResponseReturnsClaimsInner>), string nextPage = default(string), string previousPage = default(string))
        {
            this.RecordsFound = recordsFound;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
            this.ReturnsClaims = returnsClaims;
            this.NextPage = nextPage;
            this.PreviousPage = previousPage;
        }

        /// <summary>
        /// Number of records found.
        /// </summary>
        /// <value>Number of records found.</value>
        [DataMember(Name = "recordsFound", EmitDefaultValue = false)]
        public int RecordsFound { get; set; }

        /// <summary>
        /// Number of records in a page.
        /// </summary>
        /// <value>Number of records in a page.</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Number of page.
        /// </summary>
        /// <value>Number of page.</value>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets ReturnsClaims
        /// </summary>
        [DataMember(Name = "returnsClaims", EmitDefaultValue = false)]
        public List<ReturnsSearchResponseReturnsClaimsInner> ReturnsClaims { get; set; }

        /// <summary>
        /// URL for the next page.
        /// </summary>
        /// <value>URL for the next page.</value>
        [DataMember(Name = "nextPage", EmitDefaultValue = false)]
        public string NextPage { get; set; }

        /// <summary>
        /// URL for the previous page.
        /// </summary>
        /// <value>URL for the previous page.</value>
        [DataMember(Name = "previousPage", EmitDefaultValue = false)]
        public string PreviousPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReturnsSearchResponse {\n");
            sb.Append("  RecordsFound: ").Append(RecordsFound).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  ReturnsClaims: ").Append(ReturnsClaims).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
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
