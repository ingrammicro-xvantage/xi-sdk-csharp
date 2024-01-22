/*
 * Reseller API
 *
 * For Resellers. <br> Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;

namespace xi.sdk.resellers.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoicesV5ApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <remarks>
        /// View invoice details. This is a request to query invoice details for a specific Ingram Micro order placed in the last 9 months, whether open or shipped.   &lt;strong&gt;invoiceNumber&lt;/strong&gt;, &lt;strong&gt;isoCountryCode&lt;/strong&gt; and &lt;strong&gt;customerNumber&lt;/strong&gt; parameters are required.
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceNumber">Ingram Micro Invoice Number</param>
        /// <param name="customerNumber">Your unique Ingram Micro customer number</param>
        /// <param name="isoCountryCode">ISO 2 char country code</param>
        /// <returns>InvoiceDetails</returns>
        InvoiceDetails GetInvoices(string invoiceNumber, string customerNumber, string isoCountryCode);

        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <remarks>
        /// View invoice details. This is a request to query invoice details for a specific Ingram Micro order placed in the last 9 months, whether open or shipped.   &lt;strong&gt;invoiceNumber&lt;/strong&gt;, &lt;strong&gt;isoCountryCode&lt;/strong&gt; and &lt;strong&gt;customerNumber&lt;/strong&gt; parameters are required.
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceNumber">Ingram Micro Invoice Number</param>
        /// <param name="customerNumber">Your unique Ingram Micro customer number</param>
        /// <param name="isoCountryCode">ISO 2 char country code</param>
        /// <returns>ApiResponse of InvoiceDetails</returns>
        ApiResponse<InvoiceDetails> GetInvoicesWithHttpInfo(string invoiceNumber, string customerNumber, string isoCountryCode);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoicesV5ApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <remarks>
        /// View invoice details. This is a request to query invoice details for a specific Ingram Micro order placed in the last 9 months, whether open or shipped.   &lt;strong&gt;invoiceNumber&lt;/strong&gt;, &lt;strong&gt;isoCountryCode&lt;/strong&gt; and &lt;strong&gt;customerNumber&lt;/strong&gt; parameters are required.
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceNumber">Ingram Micro Invoice Number</param>
        /// <param name="customerNumber">Your unique Ingram Micro customer number</param>
        /// <param name="isoCountryCode">ISO 2 char country code</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InvoiceDetails</returns>
        System.Threading.Tasks.Task<InvoiceDetails> GetInvoicesAsync(string invoiceNumber, string customerNumber, string isoCountryCode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Invoice Details
        /// </summary>
        /// <remarks>
        /// View invoice details. This is a request to query invoice details for a specific Ingram Micro order placed in the last 9 months, whether open or shipped.   &lt;strong&gt;invoiceNumber&lt;/strong&gt;, &lt;strong&gt;isoCountryCode&lt;/strong&gt; and &lt;strong&gt;customerNumber&lt;/strong&gt; parameters are required.
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceNumber">Ingram Micro Invoice Number</param>
        /// <param name="customerNumber">Your unique Ingram Micro customer number</param>
        /// <param name="isoCountryCode">ISO 2 char country code</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InvoiceDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceDetails>> GetInvoicesWithHttpInfoAsync(string invoiceNumber, string customerNumber, string isoCountryCode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoicesV5Api : IInvoicesV5ApiSync, IInvoicesV5ApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InvoicesV5Api : IDisposable, IInvoicesV5Api
    {
        private xi.sdk.resellers.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV5Api"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public InvoicesV5Api() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV5Api"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public InvoicesV5Api(string basePath)
        {
            this.Configuration = xi.sdk.resellers.Client.Configuration.MergeConfigurations(
                xi.sdk.resellers.Client.GlobalConfiguration.Instance,
                new xi.sdk.resellers.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new xi.sdk.resellers.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV5Api"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public InvoicesV5Api(xi.sdk.resellers.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = xi.sdk.resellers.Client.Configuration.MergeConfigurations(
                xi.sdk.resellers.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new xi.sdk.resellers.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV5Api"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public InvoicesV5Api(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV5Api"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public InvoicesV5Api(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = xi.sdk.resellers.Client.Configuration.MergeConfigurations(
                xi.sdk.resellers.Client.GlobalConfiguration.Instance,
                new xi.sdk.resellers.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new xi.sdk.resellers.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV5Api"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public InvoicesV5Api(HttpClient client, xi.sdk.resellers.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = xi.sdk.resellers.Client.Configuration.MergeConfigurations(
                xi.sdk.resellers.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new xi.sdk.resellers.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesV5Api"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public InvoicesV5Api(xi.sdk.resellers.Client.ISynchronousClient client, xi.sdk.resellers.Client.IAsynchronousClient asyncClient, xi.sdk.resellers.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = xi.sdk.resellers.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public xi.sdk.resellers.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public xi.sdk.resellers.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public xi.sdk.resellers.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public xi.sdk.resellers.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public xi.sdk.resellers.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Invoice Details View invoice details. This is a request to query invoice details for a specific Ingram Micro order placed in the last 9 months, whether open or shipped.   &lt;strong&gt;invoiceNumber&lt;/strong&gt;, &lt;strong&gt;isoCountryCode&lt;/strong&gt; and &lt;strong&gt;customerNumber&lt;/strong&gt; parameters are required.
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceNumber">Ingram Micro Invoice Number</param>
        /// <param name="customerNumber">Your unique Ingram Micro customer number</param>
        /// <param name="isoCountryCode">ISO 2 char country code</param>
        /// <returns>InvoiceDetails</returns>
        public InvoiceDetails GetInvoices(string invoiceNumber, string customerNumber, string isoCountryCode)
        {
            xi.sdk.resellers.Client.ApiResponse<InvoiceDetails> localVarResponse = GetInvoicesWithHttpInfo(invoiceNumber, customerNumber, isoCountryCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Invoice Details View invoice details. This is a request to query invoice details for a specific Ingram Micro order placed in the last 9 months, whether open or shipped.   &lt;strong&gt;invoiceNumber&lt;/strong&gt;, &lt;strong&gt;isoCountryCode&lt;/strong&gt; and &lt;strong&gt;customerNumber&lt;/strong&gt; parameters are required.
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceNumber">Ingram Micro Invoice Number</param>
        /// <param name="customerNumber">Your unique Ingram Micro customer number</param>
        /// <param name="isoCountryCode">ISO 2 char country code</param>
        /// <returns>ApiResponse of InvoiceDetails</returns>
        public xi.sdk.resellers.Client.ApiResponse<InvoiceDetails> GetInvoicesWithHttpInfo(string invoiceNumber, string customerNumber, string isoCountryCode)
        {
            // verify the required parameter 'invoiceNumber' is set
            if (invoiceNumber == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'invoiceNumber' when calling InvoicesV5Api->GetInvoices");

            // verify the required parameter 'customerNumber' is set
            if (customerNumber == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'customerNumber' when calling InvoicesV5Api->GetInvoices");

            // verify the required parameter 'isoCountryCode' is set
            if (isoCountryCode == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'isoCountryCode' when calling InvoicesV5Api->GetInvoices");

            xi.sdk.resellers.Client.RequestOptions localVarRequestOptions = new xi.sdk.resellers.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = xi.sdk.resellers.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = xi.sdk.resellers.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("invoiceNumber", xi.sdk.resellers.Client.ClientUtils.ParameterToString(invoiceNumber)); // path parameter
            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "customerNumber", customerNumber));
            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "isoCountryCode", isoCountryCode));

            // authentication (application) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<InvoiceDetails>("/resellers/v5/invoices/{invoiceNumber}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInvoices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Invoice Details View invoice details. This is a request to query invoice details for a specific Ingram Micro order placed in the last 9 months, whether open or shipped.   &lt;strong&gt;invoiceNumber&lt;/strong&gt;, &lt;strong&gt;isoCountryCode&lt;/strong&gt; and &lt;strong&gt;customerNumber&lt;/strong&gt; parameters are required.
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceNumber">Ingram Micro Invoice Number</param>
        /// <param name="customerNumber">Your unique Ingram Micro customer number</param>
        /// <param name="isoCountryCode">ISO 2 char country code</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InvoiceDetails</returns>
        public async System.Threading.Tasks.Task<InvoiceDetails> GetInvoicesAsync(string invoiceNumber, string customerNumber, string isoCountryCode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            xi.sdk.resellers.Client.ApiResponse<InvoiceDetails> localVarResponse = await GetInvoicesWithHttpInfoAsync(invoiceNumber, customerNumber, isoCountryCode, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Invoice Details View invoice details. This is a request to query invoice details for a specific Ingram Micro order placed in the last 9 months, whether open or shipped.   &lt;strong&gt;invoiceNumber&lt;/strong&gt;, &lt;strong&gt;isoCountryCode&lt;/strong&gt; and &lt;strong&gt;customerNumber&lt;/strong&gt; parameters are required.
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceNumber">Ingram Micro Invoice Number</param>
        /// <param name="customerNumber">Your unique Ingram Micro customer number</param>
        /// <param name="isoCountryCode">ISO 2 char country code</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InvoiceDetails)</returns>
        public async System.Threading.Tasks.Task<xi.sdk.resellers.Client.ApiResponse<InvoiceDetails>> GetInvoicesWithHttpInfoAsync(string invoiceNumber, string customerNumber, string isoCountryCode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'invoiceNumber' is set
            if (invoiceNumber == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'invoiceNumber' when calling InvoicesV5Api->GetInvoices");

            // verify the required parameter 'customerNumber' is set
            if (customerNumber == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'customerNumber' when calling InvoicesV5Api->GetInvoices");

            // verify the required parameter 'isoCountryCode' is set
            if (isoCountryCode == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'isoCountryCode' when calling InvoicesV5Api->GetInvoices");


            xi.sdk.resellers.Client.RequestOptions localVarRequestOptions = new xi.sdk.resellers.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = xi.sdk.resellers.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = xi.sdk.resellers.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("invoiceNumber", xi.sdk.resellers.Client.ClientUtils.ParameterToString(invoiceNumber)); // path parameter
            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "customerNumber", customerNumber));
            localVarRequestOptions.QueryParameters.Add(xi.sdk.resellers.Client.ClientUtils.ParameterToMultiMap("", "isoCountryCode", isoCountryCode));

            // authentication (application) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<InvoiceDetails>("/resellers/v5/invoices/{invoiceNumber}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInvoices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
