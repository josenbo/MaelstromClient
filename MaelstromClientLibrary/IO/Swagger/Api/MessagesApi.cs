using System;
using System.Collections.Generic;
using System.Linq;
using MaelstromClientLibrary.IO.Swagger.Client;
using MaelstromClientLibrary.IO.Swagger.Model;
using RestSharp;
using Configuration = MaelstromClientLibrary.IO.Swagger.Client.Configuration;

namespace MaelstromClientLibrary.IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MessagesApi : IMessagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagesApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessagesApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="requests"></param> 
        /// <param name="env"></param> 
        /// <param name="que"></param> 
        /// <returns>List&lt;CreateMessageResponse&gt;</returns>
        public List<CreateMessageResponse> MessagesPostMessages (List<CreateMessageRequest> requests, string env, string que)
        {
             var response = MessagesPostMessagesWithHttpInfo(requests, env, que);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="requests"></param> 
        /// <param name="env"></param> 
        /// <param name="que"></param> 
        /// <returns>ApiResponse of List&lt;CreateMessageResponse&gt;</returns>
        public ApiResponse< List<CreateMessageResponse> > MessagesPostMessagesWithHttpInfo (List<CreateMessageRequest> requests, string env, string que)
        {
            
            // verify the required parameter 'requests' is set
            if (requests == null)
                throw new ApiException(400, "Missing required parameter 'requests' when calling MessagesApi->MessagesPostMessages");
            
            // verify the required parameter 'env' is set
            if (env == null)
                throw new ApiException(400, "Missing required parameter 'env' when calling MessagesApi->MessagesPostMessages");
            
            // verify the required parameter 'que' is set
            if (que == null)
                throw new ApiException(400, "Missing required parameter 'que' when calling MessagesApi->MessagesPostMessages");
            
    
            var path_ = "/api/v1/environments/{env}/queues/{que}/messages";
    
            var pathParams = new Dictionary<string, string>();
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            // ReSharper disable once RedundantAssignment
            object postBody = null;

            // to determine the Content-Type header
            var httpContentTypes = new[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            var httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            var httpHeaderAccepts = new[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            // ReSharper disable ConditionIsAlwaysTrueOrFalse
            if (env != null) pathParams.Add("env", Configuration.ApiClient.ParameterToString(env)); // path parameter
            if (que != null) pathParams.Add("que", Configuration.ApiClient.ParameterToString(que)); // path parameter
            // ReSharper restore ConditionIsAlwaysTrueOrFalse
            
            
            
            
            if (requests.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(requests); // http body (model) parameter
            }
            else
            {
                postBody = requests; // byte array
            }

            
    
            // make the HTTP request
            var response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            var statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MessagesPostMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MessagesPostMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<CreateMessageResponse>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CreateMessageResponse>) Configuration.ApiClient.Deserialize(response, typeof(List<CreateMessageResponse>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="requests"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of List&lt;CreateMessageResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<CreateMessageResponse>> MessagesPostMessagesAsync (List<CreateMessageRequest> requests, string env, string que)
        {
             var response = await MessagesPostMessagesAsyncWithHttpInfo(requests, env, que);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="requests"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of ApiResponse (List&lt;CreateMessageResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CreateMessageResponse>>> MessagesPostMessagesAsyncWithHttpInfo (List<CreateMessageRequest> requests, string env, string que)
        {
            // verify the required parameter 'requests' is set
            if (requests == null) throw new ApiException(400, "Missing required parameter 'requests' when calling MessagesPostMessages");
            // verify the required parameter 'env' is set
            if (env == null) throw new ApiException(400, "Missing required parameter 'env' when calling MessagesPostMessages");
            // verify the required parameter 'que' is set
            if (que == null) throw new ApiException(400, "Missing required parameter 'que' when calling MessagesPostMessages");
            
    
            var path_ = "/api/v1/environments/{env}/queues/{que}/messages";
    
            var pathParams = new Dictionary<string, string>();
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            // ReSharper disable once RedundantAssignment
            object postBody = null;

            // to determine the Content-Type header
            var httpContentTypes = new[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            var httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            var httpHeaderAccepts = new[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            // ReSharper disable ConditionIsAlwaysTrueOrFalse
            if (env != null) pathParams.Add("env", Configuration.ApiClient.ParameterToString(env)); // path parameter
            if (que != null) pathParams.Add("que", Configuration.ApiClient.ParameterToString(que)); // path parameter
            // ReSharper restore ConditionIsAlwaysTrueOrFalse
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(requests); // http body (model) parameter
            

            

            // make the HTTP request
            var response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            var statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MessagesPostMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MessagesPostMessages: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<CreateMessageResponse>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CreateMessageResponse>) Configuration.ApiClient.Deserialize(response, typeof(List<CreateMessageResponse>)));
            
        }
        
    }
    
}
