using System;
using System.Collections.Generic;
using System.Linq;
using MaelstromClientLibrary.IO.Swagger.Client;
using RestSharp;
using Configuration = MaelstromClientLibrary.IO.Swagger.Client.Configuration;
using Environment = MaelstromClientLibrary.IO.Swagger.Model.Environment;

namespace MaelstromClientLibrary.IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EnvironmentsApi : IEnvironmentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EnvironmentsApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EnvironmentsApi(Configuration configuration = null)
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
        /// <returns>List&lt;Environment&gt;</returns>
        public List<Environment> EnvironmentsGetEnvironments ()
        {
             var response = EnvironmentsGetEnvironmentsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>ApiResponse of List&lt;Environment&gt;</returns>
        public ApiResponse< List<Environment> > EnvironmentsGetEnvironmentsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/environments";
    
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








            // ReSharper disable ExpressionIsAlwaysNull
            // make the HTTP request
            var response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);
            // ReSharper restore ExpressionIsAlwaysNull

            var statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EnvironmentsGetEnvironments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EnvironmentsGetEnvironments: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Environment>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Environment>) Configuration.ApiClient.Deserialize(response, typeof(List<Environment>)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of List&lt;Environment&gt;</returns>
        public async System.Threading.Tasks.Task<List<Environment>> EnvironmentsGetEnvironmentsAsync ()
        {
             var response = await EnvironmentsGetEnvironmentsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;Environment&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Environment>>> EnvironmentsGetEnvironmentsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/environments";
    
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








            // ReSharper disable ExpressionIsAlwaysNull
            // make the HTTP request
            var response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);
            // ReSharper restore ExpressionIsAlwaysNull

            var statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EnvironmentsGetEnvironments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EnvironmentsGetEnvironments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Environment>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Environment>) Configuration.ApiClient.Deserialize(response, typeof(List<Environment>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param> 
        /// <returns>Environment</returns>
        public Environment EnvironmentsGetEnvironment (string env)
        {
             var response = EnvironmentsGetEnvironmentWithHttpInfo(env);
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param> 
        /// <returns>ApiResponse of Environment</returns>
        public ApiResponse< Environment > EnvironmentsGetEnvironmentWithHttpInfo (string env)
        {
            
            // verify the required parameter 'env' is set
            if (env == null)
                throw new ApiException(400, "Missing required parameter 'env' when calling EnvironmentsApi->EnvironmentsGetEnvironment");
            
    
            var path_ = "/api/v1/environments/{env}";
    
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
                throw new ApiException (statusCode, "Error calling EnvironmentsGetEnvironment: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EnvironmentsGetEnvironment: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Environment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Environment) Configuration.ApiClient.Deserialize(response, typeof(Environment)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param>
        /// <returns>Task of Environment</returns>
        public async System.Threading.Tasks.Task<Environment> EnvironmentsGetEnvironmentAsync (string env)
        {
             var response = await EnvironmentsGetEnvironmentAsyncWithHttpInfo(env);
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="env"></param>
        /// <returns>Task of ApiResponse (Environment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Environment>> EnvironmentsGetEnvironmentAsyncWithHttpInfo (string env)
        {
            // verify the required parameter 'env' is set
            if (env == null) throw new ApiException(400, "Missing required parameter 'env' when calling EnvironmentsGetEnvironment");
            
    
            var path_ = "/api/v1/environments/{env}";
    
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
                throw new ApiException (statusCode, "Error calling EnvironmentsGetEnvironment: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EnvironmentsGetEnvironment: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Environment>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Environment) Configuration.ApiClient.Deserialize(response, typeof(Environment)));
            
        }
        
    }
    
}
