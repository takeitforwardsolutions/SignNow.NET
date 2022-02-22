using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SignNow.Net.Model.MetaData
{
    public partial class WebHookMeta
    {
        // "timestamp": 1620842283,
        //"event": "document.open",
        //"environment": "",
        //"callback_url": "",
        //"access_token": ""
        [JsonProperty("timestamp")]
        public int TimeStamp { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("callback_url")]
        public System.Uri CallBackUrl { get; set; }

        [JsonProperty("access_token")]
        public string Token { get; set; }
    }
}
