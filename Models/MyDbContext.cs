using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NetMVC
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
               : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    public class Category
    {
        public long id { get; set; }
        public string Name { get; set; }
    }
    public class Product
    {

        public int _id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string add { get; set; }
        public string Save { get; set; }
    }
}
