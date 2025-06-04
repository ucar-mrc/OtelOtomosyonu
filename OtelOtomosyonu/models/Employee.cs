using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace OtelOtomosyonu.models
{
   
    public class Employee
    {

        [Key]

     public  int employeeId { get; set; }
     public  String employeeName { get; set; }
     public  String employeeLastname { get; set; }
     public  int employeeAge { get; set; }
     public String employeeSection { get; set; }



    }
}
