
namespace DesignPatterns.Creational.FactoryMethod.Factory
{
    using Manager;
    using Interfaces;

    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {

        public PermanentEmployeeFactory(IEmployee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}
