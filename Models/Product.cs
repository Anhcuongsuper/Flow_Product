using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NetMVC.Models
{
    public class Product : Controller
    {
       public int  Id { get; set; }
        public string Name { get; set; }
        public  int Price { get; set; }

    }
}