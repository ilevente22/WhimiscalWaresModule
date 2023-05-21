using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace fITness.Dnn.HelloWorld.Models
{
    public class ProductDto
    {
        public string Bvin { get; set; }
        public string ImageFileSmall { get; set; }
        public string ProductName { get; set; }
        public decimal SitePrice { get; set; }
    }
}