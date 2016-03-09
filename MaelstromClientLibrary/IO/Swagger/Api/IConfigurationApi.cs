using MaelstromClientLibrary.IO.Swagger.Client;

namespace MaelstromClientLibrary.IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigurationApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Configuration</returns>
        Configuration ConfigurationGetConfiguration ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Configuration</returns>
        ApiResponse<Configuration> ConfigurationGetConfigurationWithHttpInfo ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Configuration</returns>
        System.Threading.Tasks.Task<Configuration> ConfigurationGetConfigurationAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Configuration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Configuration>> ConfigurationGetConfigurationAsyncWithHttpInfo ();
        
    }
}