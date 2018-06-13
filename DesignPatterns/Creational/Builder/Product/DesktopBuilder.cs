
namespace DesignPatterns.Creational.Builder.Product
{
    using IBuilder;

    public class DesktopBuilder : ISystemBuilder
    {
        ComputerSystem desktop = new ComputerSystem();

        public void AddHDD(string size)
        {
            desktop.HDD = size;
        }

        public void AddKeyboard(string keyboard)
        {
            desktop.Keyboard = keyboard;
        }

        public void AddMouse(string mouse)
        {
            desktop.Mouse = mouse;
        }

        public void AddRAM(string memory)
        {
            desktop.RAM = memory;
        }

        public void AddTouchScreen(string enabled)
        {
            return;
        }

        public ComputerSystem GetSystem()
        {
            return desktop;
        }

    }
}
