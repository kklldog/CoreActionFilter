using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreActionFilter.Filters
{
    public class FilterSyncAsyncBoth : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("FilterSyncAsyncBoth method {0} running .", "OnActionExecuted");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("FilterSyncAsyncBoth method {0} running .", "OnActionExecuting");
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await Task.Run(() => { Console.WriteLine("FilterSyncAsyncBoth method {0} running .", "OnActionExecutionAsync"); });

            await base.OnActionExecutionAsync(context, next);
        }
    }
}
