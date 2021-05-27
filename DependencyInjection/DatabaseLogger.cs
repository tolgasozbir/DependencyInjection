using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Database Logged!");
        }
    }
}
