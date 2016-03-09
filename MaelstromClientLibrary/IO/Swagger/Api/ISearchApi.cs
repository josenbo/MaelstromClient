using MaelstromClientLibrary.IO.Swagger.Client;
using MaelstromClientLibrary.IO.Swagger.Model;

namespace MaelstromClientLibrary.IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="request"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>CreateSearchResponse</returns>
        CreateSearchResponse SearchPostSearch (CreateSearchRequest request, string env, string que);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="request"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>ApiResponse of CreateSearchResponse</returns>
        ApiResponse<CreateSearchResponse> SearchPostSearchWithHttpInfo (CreateSearchRequest request, string env, string que);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="request"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of CreateSearchResponse</returns>
        System.Threading.Tasks.Task<CreateSearchResponse> SearchPostSearchAsync (CreateSearchRequest request, string env, string que);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="request"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of ApiResponse (CreateSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateSearchResponse>> SearchPostSearchAsyncWithHttpInfo (CreateSearchRequest request, string env, string que);
        
    }
}