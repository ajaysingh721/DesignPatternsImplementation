using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public interface ILog
    {
        void Error(string message);
        void Warn(string message);
        void Fatal(string message);
        void Info(string message);
        void Debug(string message);
    }
}
