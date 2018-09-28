using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApp.Models
{
    public class Product
    {
        public int id { get; set; }
        public string pname { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
    }
}