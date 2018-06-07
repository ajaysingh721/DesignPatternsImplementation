using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Implementation.Models
{
    public class Employee_Type
    {
        public int Id { get; set; }
        public string EmployeeType { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public string ContactNumber { get; set; }
        public string Department { get; set; }
        public string HourlyPay { get; set; }
        public string Bonus { get; set; }
        public Employee_Type Employee_Types { get; set; }

    }
}