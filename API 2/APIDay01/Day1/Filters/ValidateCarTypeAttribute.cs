using Day1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.RegularExpressions;

namespace Day1.Filters
{
    public class ValidateCarTypeAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Car? car = context.ActionArguments["car"] as Car;
            var regex = new Regex("^(Electric|Gas|Diesel|Hybrid)$",
                RegexOptions.IgnoreCase,
                TimeSpan.FromSeconds(2));
            if(car is null || regex.IsMatch(car.CarType))
            {
                context.ModelState.AddModelError("CarType", "CarType is Not Valid");
                context.Result = new BadRequestObjectResult(context.ModelState);

            }
        }
    }
}
