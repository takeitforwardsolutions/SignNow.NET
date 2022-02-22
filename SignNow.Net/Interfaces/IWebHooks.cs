using System.Threading;
using System.Threading.Tasks;
using SignNow.Net.Model;
using SignNow.Net.Model.Requests;
using SignNow.Net.Model.Responses;

namespace SignNow.Net.Interfaces
{
    /// <summary>
    /// Interface for any operations with a User in SignNow;
    /// i.e. create a user, authenticate a user, retrieve user's documents etc.
    /// </summary>
    public interface IWebHooksService
    {
        /// <summary>
        /// Creates a Web Hook 
        /// </summary>
        /// <param name="scopeId"></param>
        /// <param name="eventName"></param>
        /// <param name="cancellation">Propagates notification that operations should be canceled</param>
        /// <param name="callBackUrl"></param>
        /// <returns></returns>
        Task<WebHookResponse> CreateWebHook(string scopeId, string eventName, System.Uri callBackUrl, CancellationToken cancellation = default);

    }
}
