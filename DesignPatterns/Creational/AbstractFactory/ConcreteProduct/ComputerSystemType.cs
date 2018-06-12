
namespace DesignPatterns.Creational.AbstractFactory.ConcreteProduct
{
    using AbstractProduct;
    using Enums;

    class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.Desktop.ToString();
        }
    }

    class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.Laptop.ToString();
        }
    }


    class IMac : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.iMac.ToString();
        }
    }

    class MacBook : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.MacBook.ToString();
        }
    }
}
