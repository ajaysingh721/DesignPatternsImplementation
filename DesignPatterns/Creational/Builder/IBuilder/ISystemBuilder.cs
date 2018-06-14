
namespace DesignPatterns.Creational.Builder.IBuilder
{
    using Product;

    public interface ISystemBuilder
    {
        void AddHDD(string size);
        void AddRAM(string memory);
        void AddKeyboard(string keyboard);
        void AddMouse(string mouse);
        void AddTouchScreen(string enabled);
        ComputerSystem GetSystem();

    }
}
