using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IroningBoy.Core.Models.Response
{
 
    public class PriceList : Response
    {
        public List<CategoryDetails> Data { get; set; } = new List<CategoryDetails>();
    }

    public class CategoryDetails
    {
        public string Name { get; set; } = string.Empty; 
        public string Description { get; set; } = string.Empty;
        public List<ServiceDetails> ServiceList { get; set; } = new List<ServiceDetails>();
    }

    public class ServiceDetails 
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } 
    }
}
