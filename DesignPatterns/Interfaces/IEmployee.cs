namespace DesignPatterns.Interfaces
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        string JobDescription { get; set; }
        string Number { get; set; }
        string Department { get; set; }
        decimal HourlyPay { get; set; }
        decimal Bonus { get; set; }
        decimal HouseAllowance { get; set; }
        decimal MedicalAllowance { get; set; }
        int EmployeeTypeID { get; set; }
        string ComputerDetails { get; set; }
    }
}
