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
    /// AvailabilityAsyncNotificationRequest
    /// </summary>
    [DataContract(Name = "AvailabilityAsyncNotificationRequest")]
    public partial class AvailabilityAsyncNotificationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityAsyncNotificationRequest" /> class.
        /// </summary>
        /// <param name="topic">Field for identifying whether it is a reseller or vendor event. For eg, resellers/orders.</param>
        /// <param name="varEvent">The event sent in the request. For eg, im::create..</param>
        /// <param name="eventTimeStamp">The timestamp at which the event was sent..</param>
        /// <param name="eventId">A unique id used as identifier for the sepcific event and used for generating the x-hub signature..</param>
        /// <param name="resource">resource.</param>
        public AvailabilityAsyncNotificationRequest(string topic = default(string), string varEvent = default(string), string eventTimeStamp = default(string), string eventId = default(string), List<AvailabilityAsyncNotificationRequestResourceInner> resource = default(List<AvailabilityAsyncNotificationRequestResourceInner>))
        {
            this.Topic = topic;
            this.VarEvent = varEvent;
            this.EventTimeStamp = eventTimeStamp;
            this.EventId = eventId;
            this.Resource = resource;
        }

        /// <summary>
        /// Field for identifying whether it is a reseller or vendor event. For eg, resellers/orders
        /// </summary>
        /// <value>Field for identifying whether it is a reseller or vendor event. For eg, resellers/orders</value>
        [DataMember(Name = "topic", EmitDefaultValue = false)]
        public string Topic { get; set; }

        /// <summary>
        /// The event sent in the request. For eg, im::create.
        /// </summary>
        /// <value>The event sent in the request. For eg, im::create.</value>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        public string VarEvent { get; set; }

        /// <summary>
        /// The timestamp at which the event was sent.
        /// </summary>
        /// <value>The timestamp at which the event was sent.</value>
        [DataMember(Name = "eventTimeStamp", EmitDefaultValue = false)]
        public string EventTimeStamp { get; set; }

        /// <summary>
        /// A unique id used as identifier for the sepcific event and used for generating the x-hub signature.
        /// </summary>
        /// <value>A unique id used as identifier for the sepcific event and used for generating the x-hub signature.</value>
        [DataMember(Name = "eventId", EmitDefaultValue = false)]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public List<AvailabilityAsyncNotificationRequestResourceInner> Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AvailabilityAsyncNotificationRequest {\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  VarEvent: ").Append(VarEvent).Append("\n");
            sb.Append("  EventTimeStamp: ").Append(EventTimeStamp).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
