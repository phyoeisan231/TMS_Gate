using System.IO;
using System.Web;
namespace TMS_Gate.Models
{
    public class CustomPostedFile : HttpPostedFileBase
    {
        private readonly Stream _stream;
        private readonly string _fileName;
        private readonly string _contentType;

        public CustomPostedFile(Stream stream, string fileName, string contentType)
        {
            _stream = stream;
            _fileName = fileName;
            _contentType = contentType;
        }

        public override int ContentLength => (int)_stream.Length;

        public override string FileName => _fileName;

        public override string ContentType => _contentType;

        public override Stream InputStream => _stream;
    }

}
