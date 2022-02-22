using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using SignNow.Net.Model.MetaData;

namespace SignNow.Net.Model.Responses
{
    public partial class WebHookResponse
    {
        /// <summary>
        /// </summary>
        /// 
        [JsonProperty("meta")]
        public WebHookMeta MetaData { get; set; }

        /// <summary>
        /// </summary>
        /// 
        [JsonProperty("content")]
        public WebHookContent Content { get; set; }

    }
}
