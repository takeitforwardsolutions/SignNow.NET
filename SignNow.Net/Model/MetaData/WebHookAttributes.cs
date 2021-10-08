using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SignNow.Net.Model.MetaData
{
    public partial class WebHookAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("callback")]
        public System.Uri CallBackURL { get; set; }
    }
}
