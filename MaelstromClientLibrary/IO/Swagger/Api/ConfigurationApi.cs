using System;
using System.Collections.Generic;
using System.Linq;
using MaelstromClientLibrary.IO.Swagger.Client;
using RestSharp;

namespace MaelstromClientLibrary.IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfigurationApi : IConfigurationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigurationApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigurationApi(Configuration configuration = null)
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
        /// <returns>Configuration</returns>
        public Configuration ConfigurationGetConfiguration ()
        {
             var response = ConfigurationGetConfigurationWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>ApiResponse of Configuration</returns>
        public ApiResponse< Configuration > ConfigurationGetConfigurationWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration";
    
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








            // ReSharper disable once ExpressionIsAlwaysNull
            // make the HTTP request
            var response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            var statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConfigurationGetConfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConfigurationGetConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Configuration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Configuration) Configuration.ApiClient.Deserialize(response, typeof(Configuration)));
            
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of Configuration</returns>
        public async System.Threading.Tasks.Task<Configuration> ConfigurationGetConfigurationAsync ()
        {
             var response = await ConfigurationGetConfigurationAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Task of ApiResponse (Configuration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Configuration>> ConfigurationGetConfigurationAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration";
    
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








            // ReSharper disable ExpressionIsAlwaysNull
            // make the HTTP request
            var response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);
            // ReSharper restore ExpressionIsAlwaysNull

            var statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConfigurationGetConfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConfigurationGetConfiguration: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Configuration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Configuration) Configuration.ApiClient.Deserialize(response, typeof(Configuration)));
            
        }
        
    }
    
}
