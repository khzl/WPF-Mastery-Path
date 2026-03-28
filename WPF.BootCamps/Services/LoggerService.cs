using System;
using System.Collections.Generic;
using System.Text;

namespace WPF.BootCamps.Services
{
    public class LoggerService
    {
        public void Log(string? message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
