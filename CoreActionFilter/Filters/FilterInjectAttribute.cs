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
        public FilterInjectAttribute(IMyService myService)
        {
            if (myService == null)
            {
                throw new ArgumentNullException("myService");
            }

            Console.WriteLine("Service {0} was injected .", myService.GetServiceName());
        }
    }
}
