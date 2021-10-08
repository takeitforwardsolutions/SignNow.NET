using System;
using System.Collections.Generic;
using System.Text;

namespace SignNow.Net.Model.Requests
{
    public class RequestUpdateFieldValueModel
    {
        public object[] texts { get; set; }
        public object[] signatures { get; set; }
        public object[] checks { get; set; }
        public object[] radiobuttons { get; set; }
        public object[] attachments { get; set; }
        public List<RequestFieldModel> fields { get; set; }

    }
}
