using SignNow.Net.Internal.Constants;
using SignNow.Net.Internal.Extensions;
using SignNow.Net.Interfaces;
using SignNow.Net.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using SignNow.Net.Internal.Requests;
using SignNow.Net.Internal.Helpers;
using System.Net.Http;
using SignNow.Net.Model.Responses;
using SignNow.Net.Model.MetaData;

namespace SignNow.Net.Service
{
    public class WebHooksService : AuthorizedWebClientBase, IWebHooksService
    {
        /// <inheritdoc cref="DocumentService(Uri, Token, ISignNowClient)"/>
        public WebHooksService(Token token) : this(ApiUrl.ApiBaseUrl, token)
        {
        }

        public WebHooksService(Uri apiBaseUrl, Token token) : base(apiBaseUrl, token)
        {
        }

        public WebHooksService(Uri baseApiUrl, Token token, ISignNowClient signNowClient) : base(baseApiUrl, token, signNowClient)
        {
        }

     
        public async Task<WebHookResponse> CreateWebHook(string scopeId, string eventName, System.Uri callBackUrl,
            CancellationToken cancellation = default)
        {
          //          "event": "document.complete",
          //"entity_id": "890d13607d89a7b3f6e67a14757d02ec00cf5eae",
          //"action": "callback"
            var requestUrl = new Uri(ApiBaseUrl, "api/v2/events");
            var webHookAttributes = new WebHookAttributes { CallBackURL = callBackUrl };
            var webHookObj = new WebHook { Event = eventName, EntityId = scopeId, Action = "callback", 
                webHookAttributes=webHookAttributes};
            var requestOptions = new PostHttpRequestOptions
            {
                RequestUrl = requestUrl,
                Content = new JsonHttpContent(webHookObj),
                Token = Token
            };
            return await SignNowClient
                .RequestAsync<WebHookResponse>(requestOptions, cancellation)
                .ConfigureAwait(false);
        }
    }
}
