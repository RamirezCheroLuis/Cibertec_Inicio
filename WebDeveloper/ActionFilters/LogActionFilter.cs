using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper.ActionFilters
{
    public class LogActionFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //var controllerName = filterContext.RouteData.Values["controller"];
            //var actionName = filterContext.RouteData.Values["action"];
            //var message = $"onActionExecuting controller:{controllerName} action: {actionName}";
            //Debug.WriteLine(message, "Action Filter Log");
            Log("OnActionExecuting", filterContext.RouteData);
            //base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);
            //var controllerName = filterContext.RouteData.Values["controller"];
            //var actionName = filterContext.RouteData.Values["action"];
            //var message = $"onActionExecuting controller:{controllerName} action: {actionName}";
            //Debug.WriteLine(message, "Action Filter Log");
            Log("OnActionExecuted", filterContext.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //base.OnResultExecuting(filterContext);
            Log("OnResultExecuting", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //base.OnResultExecuted(filterContext);
            //var controllerName = filterContext.RouteData.Values["controller"];
            //var actionName = filterContext.RouteData.Values["action"];
            //var message = $"onActionExecuting controller:{controllerName} action: {actionName}";
            //Debug.WriteLine(message, "Action Filter Log");
            //Control(filterContext);
            Log("OnResultExecuted", filterContext.RouteData);
        }
        private void Log(string actionMethod,RouteData routeData)
        {            
            
                var controllerName = routeData.Values["controller"];
                var actionName = routeData.Values["action"];
                var message = $"{actionMethod} controller:{controllerName} action: {actionName}";
                Debug.WriteLine(message, "Action Filter Log");
               

        }

    }
}
