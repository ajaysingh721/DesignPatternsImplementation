namespace Implementation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Type
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string EmployeeType { get; set; } 
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
