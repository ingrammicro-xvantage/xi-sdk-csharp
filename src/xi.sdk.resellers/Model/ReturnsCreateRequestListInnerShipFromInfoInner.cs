/*
 * XI SDK Resellers
 *
 * For Resellers. Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
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
    /// ReturnsCreateRequestListInnerShipFromInfoInner
    /// </summary>
    [DataContract(Name = "returnsCreateRequest_list_inner_shipFromInfo_inner")]
    public partial class ReturnsCreateRequestListInnerShipFromInfoInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsCreateRequestListInnerShipFromInfoInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReturnsCreateRequestListInnerShipFromInfoInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsCreateRequestListInnerShipFromInfoInner" /> class.
        /// </summary>
        /// <param name="companyName">Name of the company from where the product will be shipped. (required).</param>
        /// <param name="contact">Contact name of the person from where the product will be shipped. (required).</param>
        /// <param name="addressLine1">Ship from Address Line1. (required).</param>
        /// <param name="addressLine2">Ship from Address Line2..</param>
        /// <param name="addressLine3">Ship from Address Line3..</param>
        /// <param name="city">Ship from City. (required).</param>
        /// <param name="state">Ship from state. (required).</param>
        /// <param name="postalCode">Ship from postal code. (required).</param>
        /// <param name="countryCode">ship from country code. (required).</param>
        /// <param name="email">Ship from email. (required).</param>
        /// <param name="phoneNumber">Ship from phone number..</param>
        public ReturnsCreateRequestListInnerShipFromInfoInner(string companyName = default(string), string contact = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string countryCode = default(string), string email = default(string), string phoneNumber = default(string))
        {
            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new ArgumentNullException("companyName is a required property for ReturnsCreateRequestListInnerShipFromInfoInner and cannot be null");
            }
            this.CompanyName = companyName;
            // to ensure "contact" is required (not null)
            if (contact == null)
            {
                throw new ArgumentNullException("contact is a required property for ReturnsCreateRequestListInnerShipFromInfoInner and cannot be null");
            }
            this.Contact = contact;
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new ArgumentNullException("addressLine1 is a required property for ReturnsCreateRequestListInnerShipFromInfoInner and cannot be null");
            }
            this.AddressLine1 = addressLine1;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for ReturnsCreateRequestListInnerShipFromInfoInner and cannot be null");
            }
            this.City = city;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for ReturnsCreateRequestListInnerShipFromInfoInner and cannot be null");
            }
            this.State = state;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for ReturnsCreateRequestListInnerShipFromInfoInner and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for ReturnsCreateRequestListInnerShipFromInfoInner and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for ReturnsCreateRequestListInnerShipFromInfoInner and cannot be null");
            }
            this.Email = email;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Name of the company from where the product will be shipped.
        /// </summary>
        /// <value>Name of the company from where the product will be shipped.</value>
        [DataMember(Name = "companyName", IsRequired = true, EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Contact name of the person from where the product will be shipped.
        /// </summary>
        /// <value>Contact name of the person from where the product will be shipped.</value>
        [DataMember(Name = "contact", IsRequired = true, EmitDefaultValue = true)]
        public string Contact { get; set; }

        /// <summary>
        /// Ship from Address Line1.
        /// </summary>
        /// <value>Ship from Address Line1.</value>
        [DataMember(Name = "addressLine1", IsRequired = true, EmitDefaultValue = true)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Ship from Address Line2.
        /// </summary>
        /// <value>Ship from Address Line2.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Ship from Address Line3.
        /// </summary>
        /// <value>Ship from Address Line3.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Ship from City.
        /// </summary>
        /// <value>Ship from City.</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Ship from state.
        /// </summary>
        /// <value>Ship from state.</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Ship from postal code.
        /// </summary>
        /// <value>Ship from postal code.</value>
        [DataMember(Name = "postalCode", IsRequired = true, EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// ship from country code.
        /// </summary>
        /// <value>ship from country code.</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Ship from email.
        /// </summary>
        /// <value>Ship from email.</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Ship from phone number.
        /// </summary>
        /// <value>Ship from phone number.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReturnsCreateRequestListInnerShipFromInfoInner {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
