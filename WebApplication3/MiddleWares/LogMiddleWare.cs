using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
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
           // var ActionName = httpContext.Request.Query["ActionName"].ToString();
        //    var credate = httpContext.Request.Query["credate"].ToString();
        //    var userid = httpContext.Request.Query["userid"].ToString();
        //    var entityname = httpContext.Request.Query["entityname"].ToString();
          
       


           
                //var controllerActionDescriptor = httpContext
                //.GetEndpoint()
                //.Metadata
                //.GetMetadata<ControllerActionDescriptor>();

                //var controllerName = controllerActionDescriptor.ControllerName;
              //  var actionName = controllerActionDescriptor.ActionName;

                var username = httpContext.Request.Query["username"].ToString();

                LogRepo myLogger = new LogRepo();
                myLogger.Add("", "", "testi");
                await nextDelegate.Invoke(httpContext);

                //bool isActiveTime = new ActiveTimeData().IsNowInActiveTime();
                //if (isActiveTime)
                //{
                //    await nextDelegate.Invoke(httpContext);
                //}
                //else
                //{
                //    httpContext.Response.StatusCode = 403;
                //}

            }
        }
}
