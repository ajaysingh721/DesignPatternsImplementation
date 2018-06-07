using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Implementation.Models
{
    public class Employee_Type
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string EmployeeType { get; set; }

        public virtual Employee Employee { get; set; }
    }

    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string JobDescription { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        public string Department { get; set; }

        public decimal HourlyPay { get; set; }

        public decimal Bonus { get; set; }

        [ForeignKey("Employee_Type")]
        public int EmployeeTypeId { get; set; }

        public virtual ICollection<Employee_Type> EmployeeTypes { get; set; }

    }
}