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
    ///  Class for testing DealsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DealsApiTests : IDisposable
    {
        private DealsApi instance;

        public DealsApiTests()
        {
            instance = new DealsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DealsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DealsApi
            //Assert.IsType<DealsApi>(instance);
        }

        /// <summary>
        /// Test GetResellersV6Dealsdetails
        /// </summary>
        [Fact]
        public void GetResellersV6DealsdetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string iMApplicationId = null;
            //string dealId = null;
            //var response = instance.GetResellersV6Dealsdetails(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMApplicationId, dealId);
            //Assert.IsType<DealsDetailsResponse>(response);
        }

        /// <summary>
        /// Test GetResellersV6Dealssearch
        /// </summary>
        [Fact]
        public void GetResellersV6DealssearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string? iMSenderID = null;
            //string? endUser = null;
            //string? vendor = null;
            //string? dealId = null;
            //int? size = null;
            //int? page = null;
            //var response = instance.GetResellersV6Dealssearch(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, endUser, vendor, dealId, size, page);
            //Assert.IsType<DealsSearchResponse>(response);
        }
    }
}
