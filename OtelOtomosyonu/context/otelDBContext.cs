using OtelOtomosyonu.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OtelOtomosyonu.context
{
    public class otelDBContext
    {
        public class OtelDBContext : DbContext
        {

            public OtelDBContext()
                : base("name=otelDBContext")
            {
            }


            public virtual DbSet<Employee> Employees{ get; set; }
            public virtual DbSet<Customer> Customers{ get; set; }
        }
    }
}
