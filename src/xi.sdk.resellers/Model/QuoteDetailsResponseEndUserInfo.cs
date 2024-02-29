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
    /// QuoteDetailsResponseEndUserInfo
    /// </summary>
    [DataContract(Name = "QuoteDetailsResponse_endUserInfo")]
    public partial class QuoteDetailsResponseEndUserInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDetailsResponseEndUserInfo" /> class.
        /// </summary>
        /// <param name="contact">End User Name.</param>
        /// <param name="companyName">Contact name  of end user associated with the quote..</param>
        /// <param name="addressLine1">Address line 1 for end user associated with the quote.</param>
        /// <param name="addressLine2">Address line 2 for end user associated with the quote..</param>
        /// <param name="addressLine3">Address line 3 for end user associated with the quote..</param>
        /// <param name="city">City for end user associated with the quote.</param>
        /// <param name="state">Two letter state abreviation for end user associated with the quote.</param>
        /// <param name="email">Email of end user the quote associated with the quote..</param>
        /// <param name="phoneNumber">Phone number of end user associated with the quote..</param>
        /// <param name="postalCode">Zip code of end user associated with the quote..</param>
        /// <param name="marketSegment">Market Segment of end user associated with the quote. End user market segment is included when end user is included in specific market segments like Educational, Government, Military, Medical - that may receive special pricing due to their segmentation..</param>
        public QuoteDetailsResponseEndUserInfo(string contact = default(string), string companyName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string city = default(string), string state = default(string), string email = default(string), string phoneNumber = default(string), string postalCode = default(string), string marketSegment = default(string))
        {
            this.Contact = contact;
            this.CompanyName = companyName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.City = city;
            this.State = state;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.PostalCode = postalCode;
            this.MarketSegment = marketSegment;
        }

        /// <summary>
        /// End User Name
        /// </summary>
        /// <value>End User Name</value>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public string Contact { get; set; }

        /// <summary>
        /// Contact name  of end user associated with the quote.
        /// </summary>
        /// <value>Contact name  of end user associated with the quote.</value>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Address line 1 for end user associated with the quote
        /// </summary>
        /// <value>Address line 1 for end user associated with the quote</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 for end user associated with the quote.
        /// </summary>
        /// <value>Address line 2 for end user associated with the quote.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Address line 3 for end user associated with the quote.
        /// </summary>
        /// <value>Address line 3 for end user associated with the quote.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// City for end user associated with the quote
        /// </summary>
        /// <value>City for end user associated with the quote</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Two letter state abreviation for end user associated with the quote
        /// </summary>
        /// <value>Two letter state abreviation for end user associated with the quote</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Email of end user the quote associated with the quote.
        /// </summary>
        /// <value>Email of end user the quote associated with the quote.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Phone number of end user associated with the quote.
        /// </summary>
        /// <value>Phone number of end user associated with the quote.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Zip code of end user associated with the quote.
        /// </summary>
        /// <value>Zip code of end user associated with the quote.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Market Segment of end user associated with the quote. End user market segment is included when end user is included in specific market segments like Educational, Government, Military, Medical - that may receive special pricing due to their segmentation.
        /// </summary>
        /// <value>Market Segment of end user associated with the quote. End user market segment is included when end user is included in specific market segments like Educational, Government, Military, Medical - that may receive special pricing due to their segmentation.</value>
        [DataMember(Name = "marketSegment", EmitDefaultValue = false)]
        public string MarketSegment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDetailsResponseEndUserInfo {\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  MarketSegment: ").Append(MarketSegment).Append("\n");
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
