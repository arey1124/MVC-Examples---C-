using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApp.Models
{
    public class Employees
    {
        public int id { get; set; }
        public string name { get; set; }

        public Employees(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}