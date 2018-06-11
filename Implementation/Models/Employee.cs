namespace Implementation.Models
{
    using DesignPatterns.Models;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Employee")]
    public partial class Employee : IEmployee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string JobDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        [Required]
        public decimal HourlyPay { get; set; }

        [Required]
        public decimal Bonus { get; set; }
        
        public decimal HouseAllowance { get; set; }

        public decimal MedicalAllowance { get; set; }

        [StringLength(250)]
        public string ComputerDetails { get; set; }


        public int EmployeeTypeID { get; set; }

        public virtual Employee_Type Employee_Type { get; set; }
    }
}
