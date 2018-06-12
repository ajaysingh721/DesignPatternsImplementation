
namespace DesignPatterns.Creational.AbstractFactory.ConcreteFactory
{
    using AbstractProduct;
    using ConcreteProduct;

    public class IMacFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Apple();
        }

        public virtual IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new IMac();
        }
    }

    public class MackBookFactory : IMacFactory
    {
        public override ISystemType SystemType()
        {
            return new MacBook();
        }

        public override IProcessor Processor()
        {
            return new I7();
        }
    }
}
