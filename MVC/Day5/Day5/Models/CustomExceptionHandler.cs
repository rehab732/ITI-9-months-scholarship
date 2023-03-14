using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Day5.Models
{
    public class CustomExceptionHandler:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            var x = new ViewResult()
            {
                ViewName = "Error",
            };
            x.ViewBag.massage = ex.Message;
            filterContext.Result = x;
            base.OnException(filterContext);
        }
    }
}