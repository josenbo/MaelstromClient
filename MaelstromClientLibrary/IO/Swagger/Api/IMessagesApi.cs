using System.Collections.Generic;
using MaelstromClientLibrary.IO.Swagger.Client;
using MaelstromClientLibrary.IO.Swagger.Model;

namespace MaelstromClientLibrary.IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="requests"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>List&lt;CreateMessageResponse&gt;</returns>
        List<CreateMessageResponse> MessagesPostMessages (List<CreateMessageRequest> requests, string env, string que);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="requests"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>ApiResponse of List&lt;CreateMessageResponse&gt;</returns>
        ApiResponse<List<CreateMessageResponse>> MessagesPostMessagesWithHttpInfo (List<CreateMessageRequest> requests, string env, string que);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="requests"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of List&lt;CreateMessageResponse&gt;</returns>
        System.Threading.Tasks.Task<List<CreateMessageResponse>> MessagesPostMessagesAsync (List<CreateMessageRequest> requests, string env, string que);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="requests"></param>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of ApiResponse (List&lt;CreateMessageResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CreateMessageResponse>>> MessagesPostMessagesAsyncWithHttpInfo (List<CreateMessageRequest> requests, string env, string que);
        
    }
}