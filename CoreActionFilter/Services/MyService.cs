using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreActionFilter.Services
{
    public class MyService : IMyService
    {
        public MyService ()
        {
            Console.WriteLine("Service {0} created .", GetServiceName());
        }

        public string GetServiceName()
        {
            return "MyService";
        }
    }
}
