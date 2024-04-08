/*
 * XI Sdk Resellers
 *
 * For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of APIs and webhooks to craft a seamless journey for your customers.
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
    /// OrderCreateRequestAdditionalAttributesInner
    /// </summary>
    [DataContract(Name = "OrderCreateRequest_additionalAttributes_inner")]
    public partial class OrderCreateRequestAdditionalAttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCreateRequestAdditionalAttributesInner" /> class.
        /// </summary>
        /// <param name="attributeName">allowPartialOrder: Allow orders with failed lines. (SAP) Depends on backorder settings.    DpasRating: DX rating by Department of Defense is the highest rating by the highest offices and meant to be top priority. DO any other gov offices at the federal level to priotize.    DpasProgramId: Identifies the actual agency that signed off on the DPAS priority.    allowDuplicateCustomerOrderNumber: Allow orders with duplicate customer PO numbers. Enables resellers to have the same PO number for multiple orders.     channelCode: Determine storage location for Markeplace(SAP) for different orderTypes.    customerPOType: Used for pricing, similar to orderType. Possible SAP values- ZXML and ZWEB.    storageLocation: Determine the location of the product stock in SAP for Marketplaces.    soldTo: To be used in cases when Sold-To is different than Customer ID.    orderType: Order Type[SAP]- ZOR and ZLCN.    endUserSearchTerm: Search ID for a end user contact is used in SAP to determine the contact name.    Z101: Used for end customer details such as name, address, phone, etc. This information flows to SAP and is used by warehouse.    euDepId: DEP ID would be the &#39;End User DEP/ABM Organization ID&#39; up to 32 characters and is assigned by Apple.    depOrderNbr: depordernbr is &#39;End User PO to reseller&#39; Can appear in message lines or dedicated end user po#.    govtProgramType: Program type, “PA” for government orders, “ED” for education order.    govtEndUserType: Type of end user of the program. F &#x3D; Federal, S &#x3D; State, E &#x3D; Local, K &#x3D; K-12 school, and H &#x3D; Higher Education    govtSolicitationNumber: Education order’s contract number    govtPublicPrivateCode: Determines TAX / NO TAX.   &#39;P&#39; PUBLIC SECTOR,   &#39;R&#39; PRIVATE SECTOR.  Value needs only to be provided for EDUCATION order.    govtEndUserData: Name of the End user of the program. For example, STATE OF OHIO, CHICAGO SCHOOLDISTRICT etc.    govtEndUserPostalCode: 9 CHAR FIELD / Zip Code of the End user of the order.    dynamicMessageLine1: Custom Dynamic Message line 1.    allowOrderOnCustomerHold: Boolean value flag which allows a customer to create an order with the hold status..</param>
        /// <param name="attributeValue">attributefield data.</param>
        public OrderCreateRequestAdditionalAttributesInner(string attributeName = default(string), string attributeValue = default(string))
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
        }

        /// <summary>
        /// allowPartialOrder: Allow orders with failed lines. (SAP) Depends on backorder settings.    DpasRating: DX rating by Department of Defense is the highest rating by the highest offices and meant to be top priority. DO any other gov offices at the federal level to priotize.    DpasProgramId: Identifies the actual agency that signed off on the DPAS priority.    allowDuplicateCustomerOrderNumber: Allow orders with duplicate customer PO numbers. Enables resellers to have the same PO number for multiple orders.     channelCode: Determine storage location for Markeplace(SAP) for different orderTypes.    customerPOType: Used for pricing, similar to orderType. Possible SAP values- ZXML and ZWEB.    storageLocation: Determine the location of the product stock in SAP for Marketplaces.    soldTo: To be used in cases when Sold-To is different than Customer ID.    orderType: Order Type[SAP]- ZOR and ZLCN.    endUserSearchTerm: Search ID for a end user contact is used in SAP to determine the contact name.    Z101: Used for end customer details such as name, address, phone, etc. This information flows to SAP and is used by warehouse.    euDepId: DEP ID would be the &#39;End User DEP/ABM Organization ID&#39; up to 32 characters and is assigned by Apple.    depOrderNbr: depordernbr is &#39;End User PO to reseller&#39; Can appear in message lines or dedicated end user po#.    govtProgramType: Program type, “PA” for government orders, “ED” for education order.    govtEndUserType: Type of end user of the program. F &#x3D; Federal, S &#x3D; State, E &#x3D; Local, K &#x3D; K-12 school, and H &#x3D; Higher Education    govtSolicitationNumber: Education order’s contract number    govtPublicPrivateCode: Determines TAX / NO TAX.   &#39;P&#39; PUBLIC SECTOR,   &#39;R&#39; PRIVATE SECTOR.  Value needs only to be provided for EDUCATION order.    govtEndUserData: Name of the End user of the program. For example, STATE OF OHIO, CHICAGO SCHOOLDISTRICT etc.    govtEndUserPostalCode: 9 CHAR FIELD / Zip Code of the End user of the order.    dynamicMessageLine1: Custom Dynamic Message line 1.    allowOrderOnCustomerHold: Boolean value flag which allows a customer to create an order with the hold status.
        /// </summary>
        /// <value>allowPartialOrder: Allow orders with failed lines. (SAP) Depends on backorder settings.    DpasRating: DX rating by Department of Defense is the highest rating by the highest offices and meant to be top priority. DO any other gov offices at the federal level to priotize.    DpasProgramId: Identifies the actual agency that signed off on the DPAS priority.    allowDuplicateCustomerOrderNumber: Allow orders with duplicate customer PO numbers. Enables resellers to have the same PO number for multiple orders.     channelCode: Determine storage location for Markeplace(SAP) for different orderTypes.    customerPOType: Used for pricing, similar to orderType. Possible SAP values- ZXML and ZWEB.    storageLocation: Determine the location of the product stock in SAP for Marketplaces.    soldTo: To be used in cases when Sold-To is different than Customer ID.    orderType: Order Type[SAP]- ZOR and ZLCN.    endUserSearchTerm: Search ID for a end user contact is used in SAP to determine the contact name.    Z101: Used for end customer details such as name, address, phone, etc. This information flows to SAP and is used by warehouse.    euDepId: DEP ID would be the &#39;End User DEP/ABM Organization ID&#39; up to 32 characters and is assigned by Apple.    depOrderNbr: depordernbr is &#39;End User PO to reseller&#39; Can appear in message lines or dedicated end user po#.    govtProgramType: Program type, “PA” for government orders, “ED” for education order.    govtEndUserType: Type of end user of the program. F &#x3D; Federal, S &#x3D; State, E &#x3D; Local, K &#x3D; K-12 school, and H &#x3D; Higher Education    govtSolicitationNumber: Education order’s contract number    govtPublicPrivateCode: Determines TAX / NO TAX.   &#39;P&#39; PUBLIC SECTOR,   &#39;R&#39; PRIVATE SECTOR.  Value needs only to be provided for EDUCATION order.    govtEndUserData: Name of the End user of the program. For example, STATE OF OHIO, CHICAGO SCHOOLDISTRICT etc.    govtEndUserPostalCode: 9 CHAR FIELD / Zip Code of the End user of the order.    dynamicMessageLine1: Custom Dynamic Message line 1.    allowOrderOnCustomerHold: Boolean value flag which allows a customer to create an order with the hold status.</value>
        [DataMember(Name = "attributeName", EmitDefaultValue = false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// attributefield data
        /// </summary>
        /// <value>attributefield data</value>
        [DataMember(Name = "attributeValue", EmitDefaultValue = false)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCreateRequestAdditionalAttributesInner {\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  AttributeValue: ").Append(AttributeValue).Append("\n");
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
