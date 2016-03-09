using System.Collections.Generic;
using MaelstromClientLibrary.IO.Swagger.Client;
using MaelstromClientLibrary.IO.Swagger.Model;

namespace MaelstromClientLibrary.IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEnvironmentsApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;Environment&gt;</returns>
        List<Environment> EnvironmentsGetEnvironments ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;Environment&gt;</returns>
        ApiResponse<List<Environment>> EnvironmentsGetEnvironmentsWithHttpInfo ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;Environment&gt;</returns>
        System.Threading.Tasks.Task<List<Environment>> EnvironmentsGetEnvironmentsAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;Environment&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Environment>>> EnvironmentsGetEnvironmentsAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <returns>Environment</returns>
        Environment EnvironmentsGetEnvironment (string env);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <returns>ApiResponse of Environment</returns>
        ApiResponse<Environment> EnvironmentsGetEnvironmentWithHttpInfo (string env);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <returns>Task of Environment</returns>
        System.Threading.Tasks.Task<Environment> EnvironmentsGetEnvironmentAsync (string env);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <returns>Task of ApiResponse (Environment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Environment>> EnvironmentsGetEnvironmentAsyncWithHttpInfo (string env);
        
    }
}