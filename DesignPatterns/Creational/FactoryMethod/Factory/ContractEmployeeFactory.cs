
namespace DesignPatterns.Creational.FactoryMethod.Factory
{
    using Manager;
    using Interfaces;

    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(IEmployee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
