using DesignPatterns.Creational.FactoryMethod.Factory;
using DesignPatterns.Creational.FactoryMethod.Manager;
using DesignPatterns.Models;

namespace DesignPatterns.Creational.FactoryMethod.Factory
{
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
