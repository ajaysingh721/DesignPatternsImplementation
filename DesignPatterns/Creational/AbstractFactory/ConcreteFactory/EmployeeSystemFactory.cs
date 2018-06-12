
namespace DesignPatterns.Creational.AbstractFactory.ConcreteFactory
{

    using Interfaces;

    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(IEmployee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeID == 1)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new MackBookFactory();
                }
                else
                {
                    returnValue = new IMacFactory();
                }
            }
            else if (e.EmployeeTypeID == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                    returnValue = new DellDesktopFactory();
            }
            return returnValue;
        }
    }
}
