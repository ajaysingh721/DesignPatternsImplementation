using DesignPatterns.Creational.FactoryMethod.Factory;
using DesignPatterns.Creational.FactoryMethod.Manager;
using DesignPatterns.Models;

namespace DesignPatterns.Creational.FactoryMethod.Factory
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {

        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeFactory();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}
