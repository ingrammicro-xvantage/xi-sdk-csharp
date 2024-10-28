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
    /// ProductSearchResponse
    /// </summary>
    [DataContract(Name = "ProductSearch_Response")]
    public partial class ProductSearchResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSearchResponse" /> class.
        /// </summary>
        /// <param name="recordsFound">The number of recourds found for the search..</param>
        /// <param name="pageSize">The number of results per page. Default is 25..</param>
        /// <param name="pageNumber">current page number default is 1.</param>
        /// <param name="catalog">catalog.</param>
        /// <param name="subscriptionCatalog">subscriptionCatalog.</param>
        /// <param name="nextPage">link/URL for accessing next page..</param>
        /// <param name="previousPage">link/URL for accessing previous page..</param>
        public ProductSearchResponse(int recordsFound = default(int), int pageSize = default(int), int pageNumber = default(int), List<ProductSearchResponseCatalogInner> catalog = default(List<ProductSearchResponseCatalogInner>), List<ProductSearchResponseSubscriptionCatalogInner> subscriptionCatalog = default(List<ProductSearchResponseSubscriptionCatalogInner>), string nextPage = default(string), string previousPage = default(string))
        {
            this.RecordsFound = recordsFound;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
            this.Catalog = catalog;
            this.SubscriptionCatalog = subscriptionCatalog;
            this.NextPage = nextPage;
            this.PreviousPage = previousPage;
        }

        /// <summary>
        /// The number of recourds found for the search.
        /// </summary>
        /// <value>The number of recourds found for the search.</value>
        [DataMember(Name = "recordsFound", EmitDefaultValue = false)]
        public int RecordsFound { get; set; }

        /// <summary>
        /// The number of results per page. Default is 25.
        /// </summary>
        /// <value>The number of results per page. Default is 25.</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// current page number default is 1
        /// </summary>
        /// <value>current page number default is 1</value>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets Catalog
        /// </summary>
        [DataMember(Name = "catalog", EmitDefaultValue = false)]
        public List<ProductSearchResponseCatalogInner> Catalog { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionCatalog
        /// </summary>
        [DataMember(Name = "subscriptionCatalog", EmitDefaultValue = false)]
        public List<ProductSearchResponseSubscriptionCatalogInner> SubscriptionCatalog { get; set; }

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
            sb.Append("class ProductSearchResponse {\n");
            sb.Append("  RecordsFound: ").Append(RecordsFound).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Catalog: ").Append(Catalog).Append("\n");
            sb.Append("  SubscriptionCatalog: ").Append(SubscriptionCatalog).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
