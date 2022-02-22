using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using SignNow.Net.Model.MetaData;

namespace SignNow.Net.Model
{
    public partial class WebHook
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("attributes")]
        public WebHookAttributes webHookAttributes { get; set; }
    }
}
