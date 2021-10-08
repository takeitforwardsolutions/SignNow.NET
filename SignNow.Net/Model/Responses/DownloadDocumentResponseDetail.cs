using System.IO;

namespace SignNow.Net.Model
{
    /// <summary>
    /// Represents response from SignNow API for Document download request.
    /// </summary>
    public class DownloadDocumentResponseDetail
    {
        /// <summary>
        /// File name with extension.
        /// </summary>
        public string id { get; set; }
        public string Filename { get; set; }

        /// <summary>
        /// File length in bytes.
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// File contents as Stream.
        /// </summary>
        public Stream Document { get; set; }
        public ResponseDocumentField[] fields { get; set; }
        public object[] signatures { get; set; }
        public object[] texts { get; set; }
        public object[] checks { get; set; }
        public object[] radiobuttons { get; set; }
        public object[] attachments { get; set; }

        public Enumeration_Options[] enumeration_options { get; set; }
    }
}
