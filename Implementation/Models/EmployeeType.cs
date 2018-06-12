namespace Implementation.Models
{
    using DesignPatterns.Interfaces;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class EmployeeType : IEmployeeType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string TypeOfEmployee { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
