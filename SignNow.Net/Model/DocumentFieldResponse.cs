using System;
using System.Collections.Generic;
using System.Text;

namespace SignNow.Net.Model
{
    public class ResponseDocumentField    {        public string id { get; set; }
        public string @type { get; set; }
        public string role_id { get; set; }
        public ResponseJson_Attributes json_attributes { get; set; }
        public string role { get; set; }
        public string originator { get; set; }
        public string fulfiller { get; set; }
        public string field_request_id { get; set; }
        public string element_id { get; set; }
        public object field_request_canceled { get; set; }
        public string template_field_id { get; set; }
        public string field_id { get; set; }
        //public Radio[] radio { get; set; }
    }
}
