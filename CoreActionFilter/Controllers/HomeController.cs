using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreActionFilter.Filters;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreActionFilter.Controllers
{
    public class HomeController : ControllerBase
    {
        [FilterSync]
        public string Sync()
        {
            Console.WriteLine("HomeController method Sync running .");

            return "Sync";
        }

        [FilterAsync]
        public string A_sync()
        {
            Console.WriteLine("HomeController method Async running .");

            return "Async";
        }

        [FilterSync]
        [FilterAsync]
        public string Together()
        {
            Console.WriteLine("HomeController method Together running .");

            return "Together";
        }

        [FilterSync]
        [FilterAsync]
        public string Order()
        {
            Console.WriteLine("HomeController method Order running .");

            return "Order";
        }

        [FilterSyncAsyncBoth]
        public string Both()
        {
            Console.WriteLine("HomeController method Both running .");

            return "Both";
        }

        [FilterInject]
        public string DI()
        {
            Console.WriteLine("HomeController method DI running .");

            return "DI";
        }
    }
}
