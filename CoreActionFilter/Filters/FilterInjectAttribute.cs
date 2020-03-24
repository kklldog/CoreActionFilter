using CoreActionFilter.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreActionFilter.Filters
{
    public class FilterInjectAttribute: ActionFilterAttribute
    {
        public FilterInjectAttribute(string arg1, IMyService myService, string arg2)
        {
            if (myService == null)
            {
                throw new ArgumentNullException("myService");
            }

            Console.WriteLine("Service {0} was injected .", myService.GetServiceName());
            Console.WriteLine("arg1 is {0} .", arg1);
            Console.WriteLine("arg2 is {0} .", arg2);

            Console.WriteLine("FilterInjectAttribute was created .");
        }
    }
}
