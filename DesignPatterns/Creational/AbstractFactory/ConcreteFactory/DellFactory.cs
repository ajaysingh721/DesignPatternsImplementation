
namespace DesignPatterns.Creational.AbstractFactory.ConcreteFactory
{
    using AbstractProduct;
    using ConcreteProduct;

    public class DellDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Dell();
        }

        public virtual IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    public class DellLaptopFactory : DellDesktopFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }

        public override IProcessor Processor()
        {
            return new I7();
        }
    }
}
