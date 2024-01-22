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
    /// OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerEnduser
    /// </summary>
    [DataContract(Name = "orderCreateRequest_ordercreaterequest_ordercreatedetails_lines_inner_enduser")]
    public partial class OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerEnduser : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerEnduser" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="addressline1">addressline1.</param>
        /// <param name="addressline2">addressline2.</param>
        /// <param name="addressline3">addressline3.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="postalcode">postalcode.</param>
        /// <param name="countrycode">countrycode.</param>
        /// <param name="phonenumber">phonenumber.</param>
        /// <param name="extensionnumber">extensionnumber.</param>
        /// <param name="faxnumber">faxnumber.</param>
        /// <param name="email">email.</param>
        public OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerEnduser(string id = default(string), string addressline1 = default(string), string addressline2 = default(string), string addressline3 = default(string), string city = default(string), string state = default(string), string postalcode = default(string), string countrycode = default(string), string phonenumber = default(string), string extensionnumber = default(string), string faxnumber = default(string), string email = default(string))
        {
            this.Id = id;
            this.Addressline1 = addressline1;
            this.Addressline2 = addressline2;
            this.Addressline3 = addressline3;
            this.City = city;
            this.State = state;
            this.Postalcode = postalcode;
            this.Countrycode = countrycode;
            this.Phonenumber = phonenumber;
            this.Extensionnumber = extensionnumber;
            this.Faxnumber = faxnumber;
            this.Email = email;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Addressline1
        /// </summary>
        [DataMember(Name = "addressline1", EmitDefaultValue = false)]
        public string Addressline1 { get; set; }

        /// <summary>
        /// Gets or Sets Addressline2
        /// </summary>
        [DataMember(Name = "addressline2", EmitDefaultValue = false)]
        public string Addressline2 { get; set; }

        /// <summary>
        /// Gets or Sets Addressline3
        /// </summary>
        [DataMember(Name = "addressline3", EmitDefaultValue = false)]
        public string Addressline3 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Postalcode
        /// </summary>
        [DataMember(Name = "postalcode", EmitDefaultValue = false)]
        public string Postalcode { get; set; }

        /// <summary>
        /// Gets or Sets Countrycode
        /// </summary>
        [DataMember(Name = "countrycode", EmitDefaultValue = false)]
        public string Countrycode { get; set; }

        /// <summary>
        /// Gets or Sets Phonenumber
        /// </summary>
        [DataMember(Name = "phonenumber", EmitDefaultValue = false)]
        public string Phonenumber { get; set; }

        /// <summary>
        /// Gets or Sets Extensionnumber
        /// </summary>
        [DataMember(Name = "extensionnumber", EmitDefaultValue = false)]
        public string Extensionnumber { get; set; }

        /// <summary>
        /// Gets or Sets Faxnumber
        /// </summary>
        [DataMember(Name = "faxnumber", EmitDefaultValue = false)]
        public string Faxnumber { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInnerEnduser {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Addressline1: ").Append(Addressline1).Append("\n");
            sb.Append("  Addressline2: ").Append(Addressline2).Append("\n");
            sb.Append("  Addressline3: ").Append(Addressline3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Postalcode: ").Append(Postalcode).Append("\n");
            sb.Append("  Countrycode: ").Append(Countrycode).Append("\n");
            sb.Append("  Phonenumber: ").Append(Phonenumber).Append("\n");
            sb.Append("  Extensionnumber: ").Append(Extensionnumber).Append("\n");
            sb.Append("  Faxnumber: ").Append(Faxnumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
