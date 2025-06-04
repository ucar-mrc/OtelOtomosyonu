using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomosyonu.models
{
    public class Customer
    {
        [Key]
      public  int customerId { get; set; }
      public  String customerName { get; set; }
      public  String customerLastname { get; set; }
      public  int customerAge { get; set; }
      public  String roomType { get; set; }
      public DateTime dayOfEntry { get; set; }






    }
}
