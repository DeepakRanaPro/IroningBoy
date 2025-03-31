using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IroningBoy.Core.Models.Response
{
    public class Response
    {
        public int ResponseCode { get; set; } = 200;
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "Success";
    }

    public class ResponseData : Response
    {
        public bool Data { get; set; }
    }

    public class ResponseResult : Response
    {
        public string Data { get; set; }
    }
}
