using System;
using System.Collections.Generic;
using System.Text;

namespace SignNow.Net.Model
{
    public class DocumentUpdateRequestModel
    {
        public List<ResponseJson_Attributes> fields { get; private set; } = new List<ResponseJson_Attributes>();
    }
}
