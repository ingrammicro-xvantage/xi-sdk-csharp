/*
 * XI Sdk Resellers
 *
 * For Resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    /// ReturnsCreateRequestListInner
    /// </summary>
    [DataContract(Name = "returnsCreateRequest_list_inner")]
    public partial class ReturnsCreateRequestListInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsCreateRequestListInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReturnsCreateRequestListInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsCreateRequestListInner" /> class.
        /// </summary>
        /// <param name="invoiceNumber">The Invoice number of the order. (required).</param>
        /// <param name="invoiceDate">Date of an Invoice. (required).</param>
        /// <param name="customerOrderNumber">The reseller&#39;s order number for reference in their system..</param>
        /// <param name="ingramPartNumber">Unique line number from Ingram..</param>
        /// <param name="vendorPartNumber">Vendor Part Number..</param>
        /// <param name="serialNumber">Serial number of the product..</param>
        /// <param name="quantity">Return quantity of the product. (required).</param>
        /// <param name="primaryReason">Primary reason to return the product. (required).</param>
        /// <param name="secondaryReason">Secondary reason to return the product. (required).</param>
        /// <param name="notes">Return notes..</param>
        /// <param name="referenceNumber">Reference number to return the product..</param>
        /// <param name="billToAddressId">Suffix used to identify billing address..</param>
        /// <param name="shipFromInfo">shipFromInfo (required).</param>
        /// <param name="numberOfBoxes">Number of boxes to return. (required).</param>
        public ReturnsCreateRequestListInner(string invoiceNumber = default(string), DateOnly invoiceDate = default(DateOnly), string customerOrderNumber = default(string), string ingramPartNumber = default(string), string vendorPartNumber = default(string), string serialNumber = default(string), int quantity = default(int), string primaryReason = default(string), string secondaryReason = default(string), string notes = default(string), string referenceNumber = default(string), string billToAddressId = default(string), List<ReturnsCreateRequestListInnerShipFromInfoInner> shipFromInfo = default(List<ReturnsCreateRequestListInnerShipFromInfoInner>), int numberOfBoxes = default(int))
        {
            // to ensure "invoiceNumber" is required (not null)
            if (invoiceNumber == null)
            {
                throw new ArgumentNullException("invoiceNumber is a required property for ReturnsCreateRequestListInner and cannot be null");
            }
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceDate = invoiceDate;
            this.Quantity = quantity;
            // to ensure "primaryReason" is required (not null)
            if (primaryReason == null)
            {
                throw new ArgumentNullException("primaryReason is a required property for ReturnsCreateRequestListInner and cannot be null");
            }
            this.PrimaryReason = primaryReason;
            // to ensure "secondaryReason" is required (not null)
            if (secondaryReason == null)
            {
                throw new ArgumentNullException("secondaryReason is a required property for ReturnsCreateRequestListInner and cannot be null");
            }
            this.SecondaryReason = secondaryReason;
            // to ensure "shipFromInfo" is required (not null)
            if (shipFromInfo == null)
            {
                throw new ArgumentNullException("shipFromInfo is a required property for ReturnsCreateRequestListInner and cannot be null");
            }
            this.ShipFromInfo = shipFromInfo;
            this.NumberOfBoxes = numberOfBoxes;
            this.CustomerOrderNumber = customerOrderNumber;
            this.IngramPartNumber = ingramPartNumber;
            this.VendorPartNumber = vendorPartNumber;
            this.SerialNumber = serialNumber;
            this.Notes = notes;
            this.ReferenceNumber = referenceNumber;
            this.BillToAddressId = billToAddressId;
        }

        /// <summary>
        /// The Invoice number of the order.
        /// </summary>
        /// <value>The Invoice number of the order.</value>
        [DataMember(Name = "invoiceNumber", IsRequired = true, EmitDefaultValue = true)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Date of an Invoice.
        /// </summary>
        /// <value>Date of an Invoice.</value>
        [DataMember(Name = "invoiceDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly InvoiceDate { get; set; }

        /// <summary>
        /// The reseller&#39;s order number for reference in their system.
        /// </summary>
        /// <value>The reseller&#39;s order number for reference in their system.</value>
        [DataMember(Name = "customerOrderNumber", EmitDefaultValue = false)]
        public string CustomerOrderNumber { get; set; }

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
        /// Serial number of the product.
        /// </summary>
        /// <value>Serial number of the product.</value>
        [DataMember(Name = "serialNumber", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Return quantity of the product.
        /// </summary>
        /// <value>Return quantity of the product.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public int Quantity { get; set; }

        /// <summary>
        /// Primary reason to return the product.
        /// </summary>
        /// <value>Primary reason to return the product.</value>
        [DataMember(Name = "primaryReason", IsRequired = true, EmitDefaultValue = true)]
        public string PrimaryReason { get; set; }

        /// <summary>
        /// Secondary reason to return the product.
        /// </summary>
        /// <value>Secondary reason to return the product.</value>
        [DataMember(Name = "secondaryReason", IsRequired = true, EmitDefaultValue = true)]
        public string SecondaryReason { get; set; }

        /// <summary>
        /// Return notes.
        /// </summary>
        /// <value>Return notes.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Reference number to return the product.
        /// </summary>
        /// <value>Reference number to return the product.</value>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Suffix used to identify billing address.
        /// </summary>
        /// <value>Suffix used to identify billing address.</value>
        [DataMember(Name = "billToAddressId", EmitDefaultValue = false)]
        public string BillToAddressId { get; set; }

        /// <summary>
        /// Gets or Sets ShipFromInfo
        /// </summary>
        [DataMember(Name = "shipFromInfo", IsRequired = true, EmitDefaultValue = true)]
        public List<ReturnsCreateRequestListInnerShipFromInfoInner> ShipFromInfo { get; set; }

        /// <summary>
        /// Number of boxes to return.
        /// </summary>
        /// <value>Number of boxes to return.</value>
        [DataMember(Name = "numberOfBoxes", IsRequired = true, EmitDefaultValue = true)]
        public int NumberOfBoxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReturnsCreateRequestListInner {\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  CustomerOrderNumber: ").Append(CustomerOrderNumber).Append("\n");
            sb.Append("  IngramPartNumber: ").Append(IngramPartNumber).Append("\n");
            sb.Append("  VendorPartNumber: ").Append(VendorPartNumber).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  PrimaryReason: ").Append(PrimaryReason).Append("\n");
            sb.Append("  SecondaryReason: ").Append(SecondaryReason).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  BillToAddressId: ").Append(BillToAddressId).Append("\n");
            sb.Append("  ShipFromInfo: ").Append(ShipFromInfo).Append("\n");
            sb.Append("  NumberOfBoxes: ").Append(NumberOfBoxes).Append("\n");
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
