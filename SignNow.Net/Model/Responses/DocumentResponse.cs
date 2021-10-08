using System;
using System.Collections.Generic;
using System.Text;

namespace SignNow.Net.Model.Responses
{
    public class ResponseDocumentFieldsModel
    {
        public string id { get; set; }
        public string Filename { get; set; }
        public ResponseDocumentField[] fields { get; set; }
        public object[] signatures { get; set; }
        public object[] texts { get; set; }
        public object[] checks { get; set; }
        public object[] radiobuttons { get; set; }
        public object[] attachments { get; set; }

        public Enumeration_Options[] enumeration_options { get; set; }

    }
}
