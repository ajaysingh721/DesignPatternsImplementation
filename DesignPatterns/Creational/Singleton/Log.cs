using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class Log : ILog
    {
        private static readonly Lazy<Log> instance =
        new Lazy<Log>(() => new Log());

        private Log() { }

        public static Log GetInstance { get { return instance.Value; } }

        public void Debug(string message)
        {
            FileWritter.Write(message, LogType.DEBUG);
        }

        public void Error(string message)
        {
            FileWritter.Write(message, LogType.ERROR);
        }

        public void Fatal(string message)
        {
            FileWritter.Write(message, LogType.FATAL);
        }

        public void Info(string message)
        {
            FileWritter.Write(message, LogType.INFO);
        }

        public void Warn(string message)
        {
            FileWritter.Write(message, LogType.WARN);
        }
    }
}
