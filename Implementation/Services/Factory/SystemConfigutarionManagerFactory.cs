

namespace Implementation.Services.Factory
{
    using DesignPatterns.Creational.Builder.ConcreteBuilder;
    using DesignPatterns.Creational.Builder.IBuilder;
    using Models;

    public class SystemConfigutarionManagerFactory
    {
        private ISystemBuilder systemBuilder = null;
        public ISystemBuilder GetSystemConfiguration(Employee employee)
        {
            if (employee.JobDescription.ToUpper().Equals("MANAGER"))
            {
                systemBuilder = new LaptopBuilder();
            }
            else
            {
                systemBuilder = new DesktopBuilder();
            }
            return systemBuilder;
        }
    }
}