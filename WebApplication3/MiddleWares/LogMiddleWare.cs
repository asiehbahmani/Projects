using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Repositories;

namespace WebApplication3.MiddleWares
{
    public class LogMiddleWare
    {
        private RequestDelegate nextDelegate;

        public LogMiddleWare(RequestDelegate next)
        {
            this.nextDelegate = next;
        }
        public async Task Invoke(HttpContext httpContext)
        { 
        }
    }
}
