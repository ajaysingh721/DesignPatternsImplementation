using DesignPatterns.Creational.FactoryMethod.Factory;
using DesignPatterns.Creational.FactoryMethod.Manager;
using DesignPatterns.Models;

namespace DesignPatterns.Creational.FactoryMethod.Factory
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }
        
        public override IEmployeeManager Create()
        {
            ContractEmployeeFactory manager = new ContractEmployeeFactory();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
