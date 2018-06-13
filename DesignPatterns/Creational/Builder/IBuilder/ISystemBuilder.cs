using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.IBuilder
{
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
