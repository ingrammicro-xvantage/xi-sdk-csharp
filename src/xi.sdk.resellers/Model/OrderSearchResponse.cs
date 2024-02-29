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
    /// OrderSearchResponse
    /// </summary>
    [DataContract(Name = "OrderSearch_Response")]
    public partial class OrderSearchResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSearchResponse" /> class.
        /// </summary>
        /// <param name="recordsFound">No of recourds found for the search..</param>
        /// <param name="pageSize">No of results per page.(default is 25).</param>
        /// <param name="pageNumber">Current page number.(default is 1).</param>
        /// <param name="orders">The details for the order..</param>
        /// <param name="nextPage">link/URL for accessing next page..</param>
        /// <param name="previousPage">link/URL for accessing previous page..</param>
        public OrderSearchResponse(int recordsFound = default(int), int pageSize = default(int), int pageNumber = default(int), List<OrderSearchResponseOrdersInner> orders = default(List<OrderSearchResponseOrdersInner>), string nextPage = default(string), string previousPage = default(string))
        {
            this.RecordsFound = recordsFound;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
            this.Orders = orders;
            this.NextPage = nextPage;
            this.PreviousPage = previousPage;
        }

        /// <summary>
        /// No of recourds found for the search.
        /// </summary>
        /// <value>No of recourds found for the search.</value>
        [DataMember(Name = "recordsFound", EmitDefaultValue = false)]
        public int RecordsFound { get; set; }

        /// <summary>
        /// No of results per page.(default is 25)
        /// </summary>
        /// <value>No of results per page.(default is 25)</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Current page number.(default is 1)
        /// </summary>
        /// <value>Current page number.(default is 1)</value>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public int PageNumber { get; set; }

        /// <summary>
        /// The details for the order.
        /// </summary>
        /// <value>The details for the order.</value>
        [DataMember(Name = "orders", EmitDefaultValue = false)]
        public List<OrderSearchResponseOrdersInner> Orders { get; set; }

        /// <summary>
        /// link/URL for accessing next page.
        /// </summary>
        /// <value>link/URL for accessing next page.</value>
        [DataMember(Name = "nextPage", EmitDefaultValue = false)]
        public string NextPage { get; set; }

        /// <summary>
        /// link/URL for accessing previous page.
        /// </summary>
        /// <value>link/URL for accessing previous page.</value>
        [DataMember(Name = "previousPage", EmitDefaultValue = false)]
        public string PreviousPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderSearchResponse {\n");
            sb.Append("  RecordsFound: ").Append(RecordsFound).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
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
