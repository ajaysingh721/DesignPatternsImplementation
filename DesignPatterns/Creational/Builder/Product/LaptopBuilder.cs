
namespace DesignPatterns.Creational.Builder.Product
{
    using System;
    using IBuilder;

    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();

        public void AddHDD(string size)
        {
            laptop.HDD = size;
        }

        public void AddKeyboard(string keyboard)
        {
            return;
        }

        public void AddMouse(string mouse)
        {
            return;
        }

        public void AddRAM(string memory)
        {
            laptop.RAM = memory;
        }

        public void AddTouchScreen(string enabled)
        {
            laptop.TouchScreen = enabled;
        }

        public void AddToushScreen(string enabled)
        {
            
        }

        public ComputerSystem GetSystem()
        {
            return laptop;
        }

    }
}
