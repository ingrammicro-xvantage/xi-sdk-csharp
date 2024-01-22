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
    /// OrderDetailB2BLinesInnerServiceContractInfoSubscriptions
    /// </summary>
    [DataContract(Name = "OrderDetailB2B_lines_inner_serviceContractInfo_subscriptions")]
    public partial class OrderDetailB2BLinesInnerServiceContractInfoSubscriptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailB2BLinesInnerServiceContractInfoSubscriptions" /> class.
        /// </summary>
        /// <param name="subscriptionId">The ID of the subscription..</param>
        /// <param name="subscriptionTerm">The term of the subscription..</param>
        /// <param name="renewalTerm">The renewal term of the subscription..</param>
        /// <param name="billingModel">The billing model of the billing..</param>
        /// <param name="subcriptionStartDate">Start date of the subcription..</param>
        /// <param name="subcriptionEndDate">End date of the subcription..</param>
        public OrderDetailB2BLinesInnerServiceContractInfoSubscriptions(string subscriptionId = default(string), string subscriptionTerm = default(string), string renewalTerm = default(string), string billingModel = default(string), string subcriptionStartDate = default(string), string subcriptionEndDate = default(string))
        {
            this.SubscriptionId = subscriptionId;
            this.SubscriptionTerm = subscriptionTerm;
            this.RenewalTerm = renewalTerm;
            this.BillingModel = billingModel;
            this.SubcriptionStartDate = subcriptionStartDate;
            this.SubcriptionEndDate = subcriptionEndDate;
        }

        /// <summary>
        /// The ID of the subscription.
        /// </summary>
        /// <value>The ID of the subscription.</value>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The term of the subscription.
        /// </summary>
        /// <value>The term of the subscription.</value>
        [DataMember(Name = "subscriptionTerm", EmitDefaultValue = false)]
        public string SubscriptionTerm { get; set; }

        /// <summary>
        /// The renewal term of the subscription.
        /// </summary>
        /// <value>The renewal term of the subscription.</value>
        [DataMember(Name = "renewalTerm", EmitDefaultValue = false)]
        public string RenewalTerm { get; set; }

        /// <summary>
        /// The billing model of the billing.
        /// </summary>
        /// <value>The billing model of the billing.</value>
        [DataMember(Name = "billingModel", EmitDefaultValue = false)]
        public string BillingModel { get; set; }

        /// <summary>
        /// Start date of the subcription.
        /// </summary>
        /// <value>Start date of the subcription.</value>
        [DataMember(Name = "subcriptionStartDate", EmitDefaultValue = false)]
        public string SubcriptionStartDate { get; set; }

        /// <summary>
        /// End date of the subcription.
        /// </summary>
        /// <value>End date of the subcription.</value>
        [DataMember(Name = "subcriptionEndDate", EmitDefaultValue = false)]
        public string SubcriptionEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailB2BLinesInnerServiceContractInfoSubscriptions {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  SubscriptionTerm: ").Append(SubscriptionTerm).Append("\n");
            sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
            sb.Append("  BillingModel: ").Append(BillingModel).Append("\n");
            sb.Append("  SubcriptionStartDate: ").Append(SubcriptionStartDate).Append("\n");
            sb.Append("  SubcriptionEndDate: ").Append(SubcriptionEndDate).Append("\n");
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
