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
    public class QueuesApi : IQueuesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueuesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QueuesApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueuesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public QueuesApi(Configuration configuration = null)
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
        /// <param name="env"></param> 
        /// <returns>List&lt;Queue&gt;</returns>
        public List<Queue> QueuesGetQueues (string env)
        {
             var response = QueuesGetQueuesWithHttpInfo(env);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param> 
        /// <returns>ApiResponse of List&lt;Queue&gt;</returns>
        public ApiResponse< List<Queue> > QueuesGetQueuesWithHttpInfo (string env)
        {
            
            // verify the required parameter 'env' is set
            if (env == null)
                throw new ApiException(400, "Missing required parameter 'env' when calling QueuesApi->QueuesGetQueues");
            
    
            var path_ = "/api/v1/environments/{env}/queues";
    
            var pathParams = new Dictionary<string, string>();
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            object postBody = null;

            // to determine the Content-Type header
            var httpContentTypes = new string[] {
                
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
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (env != null) pathParams.Add("env", Configuration.ApiClient.ParameterToString(env)); // path parameter








            // ReSharper disable ExpressionIsAlwaysNull
            // make the HTTP request
            var response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);
            // ReSharper restore ExpressionIsAlwaysNull

            var statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling QueuesGetQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueuesGetQueues: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Queue>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Queue>) Configuration.ApiClient.Deserialize(response, typeof(List<Queue>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param>
        /// <returns>Task of List&lt;Queue&gt;</returns>
        public async System.Threading.Tasks.Task<List<Queue>> QueuesGetQueuesAsync (string env)
        {
             var response = await QueuesGetQueuesAsyncWithHttpInfo(env);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param>
        /// <returns>Task of ApiResponse (List&lt;Queue&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Queue>>> QueuesGetQueuesAsyncWithHttpInfo (string env)
        {
            // verify the required parameter 'env' is set
            if (env == null) throw new ApiException(400, "Missing required parameter 'env' when calling QueuesGetQueues");
            
    
            var path_ = "/api/v1/environments/{env}/queues";
    
            var pathParams = new Dictionary<string, string>();
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            object postBody = null;

            // to determine the Content-Type header
            var httpContentTypes = new string[] {
                
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
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (env != null) pathParams.Add("env", Configuration.ApiClient.ParameterToString(env)); // path parameter








            // ReSharper disable ExpressionIsAlwaysNull
            // make the HTTP request
            var response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);
            // ReSharper restore ExpressionIsAlwaysNull

            var statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling QueuesGetQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueuesGetQueues: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Queue>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Queue>) Configuration.ApiClient.Deserialize(response, typeof(List<Queue>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param> 
        /// <param name="que"></param> 
        /// <returns>Queue</returns>
        public Queue QueuesGetQueue (string env, string que)
        {
             var response = QueuesGetQueueWithHttpInfo(env, que);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param> 
        /// <param name="que"></param> 
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > QueuesGetQueueWithHttpInfo (string env, string que)
        {
            
            // verify the required parameter 'env' is set
            if (env == null)
                throw new ApiException(400, "Missing required parameter 'env' when calling QueuesApi->QueuesGetQueue");
            
            // verify the required parameter 'que' is set
            if (que == null)
                throw new ApiException(400, "Missing required parameter 'que' when calling QueuesApi->QueuesGetQueue");
            
    
            var path_ = "/api/v1/environments/{env}/queues/{que}";
    
            var pathParams = new Dictionary<string, string>();
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            object postBody = null;

            // to determine the Content-Type header
            var httpContentTypes = new string[] {
                
            };
            var httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            var httpHeaderAccepts = new[] {
                "application/json", "text/json"
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








            // ReSharper disable ExpressionIsAlwaysNull
            // make the HTTP request
            var response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);
            // ReSharper restore ExpressionIsAlwaysNull

            var statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling QueuesGetQueue: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueuesGetQueue: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> QueuesGetQueueAsync (string env, string que)
        {
             var response = await QueuesGetQueueAsyncWithHttpInfo(env, que);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> QueuesGetQueueAsyncWithHttpInfo (string env, string que)
        {
            // verify the required parameter 'env' is set
            if (env == null) throw new ApiException(400, "Missing required parameter 'env' when calling QueuesGetQueue");
            // verify the required parameter 'que' is set
            if (que == null) throw new ApiException(400, "Missing required parameter 'que' when calling QueuesGetQueue");
            
    
            var path_ = "/api/v1/environments/{env}/queues/{que}";
    
            var pathParams = new Dictionary<string, string>();
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            object postBody = null;

            // to determine the Content-Type header
            var httpContentTypes = new string[] {
                
            };
            var httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            var httpHeaderAccepts = new[] {
                "application/json", "text/json"
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








            // ReSharper disable ExpressionIsAlwaysNull
            // make the HTTP request
            var response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);
            // ReSharper restore ExpressionIsAlwaysNull

            var statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling QueuesGetQueue: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QueuesGetQueue: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
        
    }
    
}
