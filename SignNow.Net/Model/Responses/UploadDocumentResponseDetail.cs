#pragma warning disable CA1819 // Properties should not return arrays
using System.IO;

namespace SignNow.Net.Model
{
    /// <summary>
    /// Represents response from SignNow API for upload document request.
    /// </summary>
   public class UploadDocumentResponseDetail
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

        public ResponseDocumentField[] Fields { get; set; }
        public object[] Signatures { get; set; }
        public object[] Texts { get; set; }
        public object[] Checks { get; set; }
        public object[] Radiobuttons { get; set; }
        public object[] Attachments { get; set; }

        public Enumeration_Options[] Enumeration_options { get; set; }
    }
}

