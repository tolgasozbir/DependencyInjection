using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("File Logged!");
        }
    }
}
