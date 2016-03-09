using System.Collections.Generic;
using MaelstromClientLibrary.IO.Swagger.Client;
using MaelstromClientLibrary.IO.Swagger.Model;

namespace MaelstromClientLibrary.IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueuesApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <returns>List&lt;Queue&gt;</returns>
        List<Queue> QueuesGetQueues (string env);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <returns>ApiResponse of List&lt;Queue&gt;</returns>
        ApiResponse<List<Queue>> QueuesGetQueuesWithHttpInfo (string env);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <returns>Task of List&lt;Queue&gt;</returns>
        System.Threading.Tasks.Task<List<Queue>> QueuesGetQueuesAsync (string env);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <returns>Task of ApiResponse (List&lt;Queue&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Queue>>> QueuesGetQueuesAsyncWithHttpInfo (string env);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Queue</returns>
        Queue QueuesGetQueue (string env, string que);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> QueuesGetQueueWithHttpInfo (string env, string que);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> QueuesGetQueueAsync (string env, string que);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="env"></param>
        /// <param name="que"></param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> QueuesGetQueueAsyncWithHttpInfo (string env, string que);
        
    }
}