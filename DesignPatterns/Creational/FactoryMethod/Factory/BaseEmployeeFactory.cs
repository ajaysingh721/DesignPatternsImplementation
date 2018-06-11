using DesignPatterns.Creational.FactoryMethod.Manager;
using DesignPatterns.Models;

namespace DesignPatterns.Creational.FactoryMethod.Factory
{  
    public abstract class BaseEmployeeFactory
    {
        protected IEmployee _emp;
        public BaseEmployeeFactory(IEmployee emp)
        {
            _emp = emp;
        }
        public IEmployee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();
            return _emp;
        }
        public abstract IEmployeeManager Create();
    }
}
