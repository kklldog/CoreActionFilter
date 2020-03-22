using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreActionFilter.Filters
{
    public class FilterSync : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("FilterSync method {0} running .", "OnActionExecuted");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("FilterSync method {0} running .", "OnActionExecuting");
        }
    }
}
