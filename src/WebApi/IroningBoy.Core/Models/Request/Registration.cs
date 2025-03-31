using System.Reflection;
using System.Xml.Linq;

namespace Models.Request
{
    public class Registration
    {
        public string PostCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public string EmailID { get; set; } = string.Empty;
    }
 
}
