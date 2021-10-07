using System;
using System.Collections.Generic;
using System.Text;

namespace SignNow.Net.Model
{
    public class ResponseJson_Attributes
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
