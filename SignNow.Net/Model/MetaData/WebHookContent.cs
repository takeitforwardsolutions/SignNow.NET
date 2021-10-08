using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SignNow.Net.Model.MetaData
{
    public partial class WebHookContent
    {
        //"content": {
        //   "document_id": "8fbd1dc52c9b4ff69f34dd1bbdc86c4915545b47",
        //   "document_name": "5113514ValidationReport1620822316194.pdf_1620822316194",
        //   "user_id": "06cafb680ac348969d5086305eb47e7eaf62dfe6",
        //   "viewer_user_unique_id": "a49e200f638547e7a5617cc3382993ad17770308"
        // }
        [JsonProperty("document_id")]
        public string DocumentId { get; set; }

        [JsonProperty("document_name")]
        public string DocumentName { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("viewer_user_unique_id")]
        public string ViewerUserUniqueId { get; set; }
    }
}
