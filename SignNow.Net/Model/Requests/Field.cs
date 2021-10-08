using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SignNow.Net.Model.Requests
{
    public class RequestFieldModel
    {
        public int page_number { get; set; }
        public string role { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public bool required { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public object prefilled_text { get; set; }
        public string label { get; set; }
        public bool bold { get; set; }
        public bool underline { get; set; }
        public string align { get; set; }
        public string valign { get; set; }
        public string arrangement { get; set; }
        public int max_chars { get; set; }
        public int max_lines { get; set; }
        public string font { get; set; }
        public int size { get; set; }
        public bool custom_defined_option { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public IEnumerable<string> enumeration_options { get; set; }
        public object calculation_formula { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int calculation_precision { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool italic { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string formula { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float line_height { get; set; }
    }

    public abstract class FieldRequestBase
    {
        public int page_number { get; set; }
        public string role { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool required { get; set; }
        public string label { get; set; }
        public object prefilled_text { get; set; }
        public string custom_defined_option { get; set; }
        public string name { get; set; }
        public dynamic calculation_formula { get; set; }
        public string formula { get; set; }
        public bool italic { get; set; }
        public bool bold { get; set; }
        public int calculation_precision { get; set; }
        public string validator_id { get; set; }
        public int size { get; set; }
        public string font { get; set; }
        public int line_height { get; set; }
        public string type { get; set; }


    }
}
