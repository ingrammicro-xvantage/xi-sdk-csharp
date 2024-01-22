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
    /// OrderDetailResponseServiceresponseOrderdetailresponseCommentlinesInner
    /// </summary>
    [DataContract(Name = "orderDetailResponse_serviceresponse_orderdetailresponse_commentlines_inner")]
    public partial class OrderDetailResponseServiceresponseOrderdetailresponseCommentlinesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailResponseServiceresponseOrderdetailresponseCommentlinesInner" /> class.
        /// </summary>
        /// <param name="commenttext1">commenttext1.</param>
        /// <param name="commenttext2">commenttext2.</param>
        public OrderDetailResponseServiceresponseOrderdetailresponseCommentlinesInner(string commenttext1 = default(string), string commenttext2 = default(string))
        {
            this.Commenttext1 = commenttext1;
            this.Commenttext2 = commenttext2;
        }

        /// <summary>
        /// Gets or Sets Commenttext1
        /// </summary>
        [DataMember(Name = "commenttext1", EmitDefaultValue = false)]
        public string Commenttext1 { get; set; }

        /// <summary>
        /// Gets or Sets Commenttext2
        /// </summary>
        [DataMember(Name = "commenttext2", EmitDefaultValue = false)]
        public string Commenttext2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailResponseServiceresponseOrderdetailresponseCommentlinesInner {\n");
            sb.Append("  Commenttext1: ").Append(Commenttext1).Append("\n");
            sb.Append("  Commenttext2: ").Append(Commenttext2).Append("\n");
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
