/*
 * XI Sdk Resellers
 *
 * For Resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using xi.sdk.resellers.Client;
using xi.sdk.resellers.Api;
// uncomment below to import models
//using xi.sdk.resellers.Model;

namespace xi.sdk.resellers.Test.Api
{
    /// <summary>
    ///  Class for testing OrdersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrdersApiTests : IDisposable
    {
        private OrdersApi instance;

        public OrdersApiTests()
        {
            instance = new OrdersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrdersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrdersApi
            //Assert.IsType<OrdersApi>(instance);
        }

        /// <summary>
        /// Test DeleteOrdercancel
        /// </summary>
        [Fact]
        public void DeleteOrdercancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderNumber = null;
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string? regionCode = null;
            //string? iMSenderID = null;
            //instance.DeleteOrdercancel(orderNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, regionCode, iMSenderID);
        }

        /// <summary>
        /// Test GetOrderdetailsV61
        /// </summary>
        [Fact]
        public void GetOrderdetailsV61Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ordernumber = null;
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string? iMSenderID = null;
            //DateOnly? ingramOrderDate = null;
            //string? vendorNumber = null;
            //string? simulateStatus = null;
            //bool? isIml = null;
            //string? regionCode = null;
            //var response = instance.GetOrderdetailsV61(ordernumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, ingramOrderDate, vendorNumber, simulateStatus, isIml, regionCode);
            //Assert.IsType<OrderDetailB2B>(response);
        }

        /// <summary>
        /// Test GetResellersV6Ordersearch
        /// </summary>
        [Fact]
        public void GetResellersV6OrdersearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string? ingramOrderNumber = null;
            //string? orderStatus = null;
            //List<string>? orderStatusIn = null;
            //string? ingramOrderDate = null;
            //List<string>? ingramOrderDateBt = null;
            //string? iMSenderID = null;
            //string? customerOrderNumber = null;
            //int? pageSize = null;
            //int? pageNumber = null;
            //string? endCustomerOrderNumber = null;
            //List<string>? invoiceDateBt = null;
            //List<string>? shipDateBt = null;
            //List<string>? deliveryDateBt = null;
            //string? ingramPartNumber = null;
            //string? vendorPartNumber = null;
            //string? serialNumber = null;
            //string? trackingNumber = null;
            //string? vendorName = null;
            //string? specialBidNumber = null;
            //var response = instance.GetResellersV6Ordersearch(iMCustomerNumber, iMCountryCode, iMCorrelationID, ingramOrderNumber, orderStatus, orderStatusIn, ingramOrderDate, ingramOrderDateBt, iMSenderID, customerOrderNumber, pageSize, pageNumber, endCustomerOrderNumber, invoiceDateBt, shipDateBt, deliveryDateBt, ingramPartNumber, vendorPartNumber, serialNumber, trackingNumber, vendorName, specialBidNumber);
            //Assert.IsType<OrderSearchResponse>(response);
        }

        /// <summary>
        /// Test PostCreateorderV6
        /// </summary>
        [Fact]
        public void PostCreateorderV6Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //OrderCreateRequest orderCreateRequest = null;
            //string? iMSenderID = null;
            //var response = instance.PostCreateorderV6(iMCustomerNumber, iMCountryCode, iMCorrelationID, orderCreateRequest, iMSenderID);
            //Assert.IsType<OrderCreateResponse>(response);
        }

        /// <summary>
        /// Test PostCreateorderV7
        /// </summary>
        [Fact]
        public void PostCreateorderV7Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //OrderCreateV7Request orderCreateV7Request = null;
            //string? iMSenderID = null;
            //var response = instance.PostCreateorderV7(iMCustomerNumber, iMCountryCode, iMCorrelationID, orderCreateV7Request, iMSenderID);
            //Assert.IsType<OrderCreateV7Response201>(response);
        }

        /// <summary>
        /// Test PutOrdermodify
        /// </summary>
        [Fact]
        public void PutOrdermodifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderNumber = null;
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //OrderModifyRequest orderModifyRequest = null;
            //string? actionCode = null;
            //string? regionCode = null;
            //string? iMSenderID = null;
            //var response = instance.PutOrdermodify(orderNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, orderModifyRequest, actionCode, regionCode, iMSenderID);
            //Assert.IsType<OrderModifyResponse>(response);
        }
    }
}
