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
    public interface IStockUpdateApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Stock Update
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targeturl">The webhook url where the request needs to sent.</param>
        /// <param name="xHubSignature">Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.</param>
        /// <param name="availabilityAsyncNotificationRequest"></param>
        /// <returns></returns>
        void ResellersV1WebhooksAvailabilityupdatePost(string targeturl, string xHubSignature, AvailabilityAsyncNotificationRequest availabilityAsyncNotificationRequest);

        /// <summary>
        /// Stock Update
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targeturl">The webhook url where the request needs to sent.</param>
        /// <param name="xHubSignature">Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.</param>
        /// <param name="availabilityAsyncNotificationRequest"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResellersV1WebhooksAvailabilityupdatePostWithHttpInfo(string targeturl, string xHubSignature, AvailabilityAsyncNotificationRequest availabilityAsyncNotificationRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStockUpdateApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Stock Update
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targeturl">The webhook url where the request needs to sent.</param>
        /// <param name="xHubSignature">Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.</param>
        /// <param name="availabilityAsyncNotificationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ResellersV1WebhooksAvailabilityupdatePostAsync(string targeturl, string xHubSignature, AvailabilityAsyncNotificationRequest availabilityAsyncNotificationRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Stock Update
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targeturl">The webhook url where the request needs to sent.</param>
        /// <param name="xHubSignature">Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.</param>
        /// <param name="availabilityAsyncNotificationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ResellersV1WebhooksAvailabilityupdatePostWithHttpInfoAsync(string targeturl, string xHubSignature, AvailabilityAsyncNotificationRequest availabilityAsyncNotificationRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStockUpdateApi : IStockUpdateApiSync, IStockUpdateApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StockUpdateApi : IDisposable, IStockUpdateApi
    {
        private xi.sdk.resellers.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StockUpdateApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public StockUpdateApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StockUpdateApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public StockUpdateApi(string basePath)
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
        /// Initializes a new instance of the <see cref="StockUpdateApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public StockUpdateApi(xi.sdk.resellers.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="StockUpdateApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public StockUpdateApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StockUpdateApi"/> class.
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
        public StockUpdateApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="StockUpdateApi"/> class using Configuration object.
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
        public StockUpdateApi(HttpClient client, xi.sdk.resellers.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="StockUpdateApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public StockUpdateApi(xi.sdk.resellers.Client.ISynchronousClient client, xi.sdk.resellers.Client.IAsynchronousClient asyncClient, xi.sdk.resellers.Client.IReadableConfiguration configuration)
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
        /// Stock Update 
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targeturl">The webhook url where the request needs to sent.</param>
        /// <param name="xHubSignature">Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.</param>
        /// <param name="availabilityAsyncNotificationRequest"></param>
        /// <returns></returns>
        public void ResellersV1WebhooksAvailabilityupdatePost(string targeturl, string xHubSignature, AvailabilityAsyncNotificationRequest availabilityAsyncNotificationRequest)
        {
            ResellersV1WebhooksAvailabilityupdatePostWithHttpInfo(targeturl, xHubSignature, availabilityAsyncNotificationRequest);
        }

        /// <summary>
        /// Stock Update 
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targeturl">The webhook url where the request needs to sent.</param>
        /// <param name="xHubSignature">Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.</param>
        /// <param name="availabilityAsyncNotificationRequest"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public xi.sdk.resellers.Client.ApiResponse<Object> ResellersV1WebhooksAvailabilityupdatePostWithHttpInfo(string targeturl, string xHubSignature, AvailabilityAsyncNotificationRequest availabilityAsyncNotificationRequest)
        {
            // verify the required parameter 'targeturl' is set
            if (targeturl == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'targeturl' when calling StockUpdateApi->ResellersV1WebhooksAvailabilityupdatePost");

            // verify the required parameter 'xHubSignature' is set
            if (xHubSignature == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'xHubSignature' when calling StockUpdateApi->ResellersV1WebhooksAvailabilityupdatePost");

            // verify the required parameter 'availabilityAsyncNotificationRequest' is set
            if (availabilityAsyncNotificationRequest == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'availabilityAsyncNotificationRequest' when calling StockUpdateApi->ResellersV1WebhooksAvailabilityupdatePost");

            xi.sdk.resellers.Client.RequestOptions localVarRequestOptions = new xi.sdk.resellers.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = xi.sdk.resellers.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = xi.sdk.resellers.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("targeturl", xi.sdk.resellers.Client.ClientUtils.ParameterToString(targeturl)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("x-hub-signature", xi.sdk.resellers.Client.ClientUtils.ParameterToString(xHubSignature)); // header parameter
            localVarRequestOptions.Data = availabilityAsyncNotificationRequest;

            // authentication (application) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/resellers/v1/webhooks/availabilityupdate", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResellersV1WebhooksAvailabilityupdatePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Stock Update 
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targeturl">The webhook url where the request needs to sent.</param>
        /// <param name="xHubSignature">Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.</param>
        /// <param name="availabilityAsyncNotificationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ResellersV1WebhooksAvailabilityupdatePostAsync(string targeturl, string xHubSignature, AvailabilityAsyncNotificationRequest availabilityAsyncNotificationRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ResellersV1WebhooksAvailabilityupdatePostWithHttpInfoAsync(targeturl, xHubSignature, availabilityAsyncNotificationRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Stock Update 
        /// </summary>
        /// <exception cref="xi.sdk.resellers.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targeturl">The webhook url where the request needs to sent.</param>
        /// <param name="xHubSignature">Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.</param>
        /// <param name="availabilityAsyncNotificationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<xi.sdk.resellers.Client.ApiResponse<Object>> ResellersV1WebhooksAvailabilityupdatePostWithHttpInfoAsync(string targeturl, string xHubSignature, AvailabilityAsyncNotificationRequest availabilityAsyncNotificationRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'targeturl' is set
            if (targeturl == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'targeturl' when calling StockUpdateApi->ResellersV1WebhooksAvailabilityupdatePost");

            // verify the required parameter 'xHubSignature' is set
            if (xHubSignature == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'xHubSignature' when calling StockUpdateApi->ResellersV1WebhooksAvailabilityupdatePost");

            // verify the required parameter 'availabilityAsyncNotificationRequest' is set
            if (availabilityAsyncNotificationRequest == null)
                throw new xi.sdk.resellers.Client.ApiException(400, "Missing required parameter 'availabilityAsyncNotificationRequest' when calling StockUpdateApi->ResellersV1WebhooksAvailabilityupdatePost");


            xi.sdk.resellers.Client.RequestOptions localVarRequestOptions = new xi.sdk.resellers.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = xi.sdk.resellers.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = xi.sdk.resellers.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("targeturl", xi.sdk.resellers.Client.ClientUtils.ParameterToString(targeturl)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("x-hub-signature", xi.sdk.resellers.Client.ClientUtils.ParameterToString(xHubSignature)); // header parameter
            localVarRequestOptions.Data = availabilityAsyncNotificationRequest;

            // authentication (application) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/resellers/v1/webhooks/availabilityupdate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResellersV1WebhooksAvailabilityupdatePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
