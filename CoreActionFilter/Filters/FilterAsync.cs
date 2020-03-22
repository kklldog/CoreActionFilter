using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreActionFilter.Filters
{
    public class FilterAsync : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await Task.Run(() => { Console.WriteLine("FilterAsync method {0} running .", "OnActionExecutionAsync"); });

            await base.OnActionExecutionAsync(context, next);
        }
    }
}
