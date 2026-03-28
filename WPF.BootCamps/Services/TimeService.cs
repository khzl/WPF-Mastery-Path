using System;
using System.Collections.Generic;
using System.Text;

namespace WPF.BootCamps.Services
{
    public class TimeService
    {
        public string? GetCurrentTime()
        {
            // Implementation 
            return DateTime.Now.ToString();
        }
    }
}
