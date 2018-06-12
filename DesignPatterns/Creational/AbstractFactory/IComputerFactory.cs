
namespace DesignPatterns.Creational.AbstractFactory
{
    using AbstractProduct;

    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}
