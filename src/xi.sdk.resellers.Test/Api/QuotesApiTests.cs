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
    ///  Class for testing QuotesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class QuotesApiTests : IDisposable
    {
        private QuotesApi instance;

        public QuotesApiTests()
        {
            instance = new QuotesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QuotesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' QuotesApi
            //Assert.IsType<QuotesApi>(instance);
        }

        /// <summary>
        /// Test GetQuotessearchV6
        /// </summary>
        [Fact]
        public void GetQuotessearchV6Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCustomerContact = null;
            //string iMCorrelationID = null;
            //List<string>? ingramOrderDateBt = null;
            //string? quoteNumber = null;
            //string? specialBidNumber = null;
            //string? endUserContact = null;
            //string? sortingOrder = null;
            //string? sortBy = null;
            //int? pageSize = null;
            //int? pageNumber = null;
            //string? vendorName = null;
            //string? quoteName = null;
            //string? status = null;
            //string? quoteCreateDateBt = null;
            //string? iMSenderID = null;
            //var response = instance.GetQuotessearchV6(iMCustomerNumber, iMCountryCode, iMCustomerContact, iMCorrelationID, ingramOrderDateBt, quoteNumber, specialBidNumber, endUserContact, sortingOrder, sortBy, pageSize, pageNumber, vendorName, quoteName, status, quoteCreateDateBt, iMSenderID);
            //Assert.IsType<QuoteSearchResponse>(response);
        }

        /// <summary>
        /// Test GetResellerV6ValidateQuote
        /// </summary>
        [Fact]
        public void GetResellerV6ValidateQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string quoteNumber = null;
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string? iMSenderID = null;
            //var response = instance.GetResellerV6ValidateQuote(quoteNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID);
            //Assert.IsType<ValidateQuoteResponse>(response);
        }

        /// <summary>
        /// Test GetResellersV6Quotes
        /// </summary>
        [Fact]
        public void GetResellersV6QuotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string quoteNumber = null;
            //string? iMSenderID = null;
            //var response = instance.GetResellersV6Quotes(iMCustomerNumber, iMCountryCode, iMCorrelationID, quoteNumber, iMSenderID);
            //Assert.IsType<QuoteDetailsResponse>(response);
        }
    }
}
