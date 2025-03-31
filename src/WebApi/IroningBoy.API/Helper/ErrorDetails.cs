using System.Text.Json;

namespace IroningBoy.API.Helper
{
    public class ErrorDetails
    {
        public string ServiceURL { get; set; }
        public string RequestMethod { get; set; }
        public string RequestBody { get; set; }
        public string Authorization { get; set; }
        public string ContentType { get; set; }
        public string Cookie { get; set; }
        public string Host { get; set; }
        public string Referer { get; set; }
        public string Origin { get; set; }
        public string UserAgent { get; set; }
        public string ErrorType { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime TimeStamp { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
