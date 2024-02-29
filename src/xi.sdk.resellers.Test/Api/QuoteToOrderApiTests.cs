/*
 * XI Sdk Resellers
 *
 * For Ingram Micro Resellers. Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
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
    ///  Class for testing QuoteToOrderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class QuoteToOrderApiTests : IDisposable
    {
        private QuoteToOrderApi instance;

        public QuoteToOrderApiTests()
        {
            instance = new QuoteToOrderApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QuoteToOrderApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' QuoteToOrderApi
            //Assert.IsType<QuoteToOrderApi>(instance);
        }

        /// <summary>
        /// Test PostQuoteToOrderV6
        /// </summary>
        [Fact]
        public void PostQuoteToOrderV6Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //QuoteToOrderDetailsDTO quoteToOrderDetailsDTO = null;
            //string? iMSenderID = null;
            //var response = instance.PostQuoteToOrderV6(iMCustomerNumber, iMCountryCode, iMCorrelationID, quoteToOrderDetailsDTO, iMSenderID);
            //Assert.IsType<QuoteToOrderResponse>(response);
        }
    }
}
