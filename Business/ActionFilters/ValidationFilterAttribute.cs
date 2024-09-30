using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Business.ActionFilters;

public class ValidationFilterAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var controller = context.RouteData.Values["controller"];
        var action = context.RouteData.Values["action"];

        var param = context.ActionArguments
            .SingleOrDefault(p => p.Value.ToString().Contains("Vm")).Value;

        if (param is null)
        {
            context.Result = new BadRequestObjectResult($"Geçersiz istek. Model null. " +
                                                        $"Controller : {controller} " +
                                                        $"Action : {action} ");
            return;
        }

        if (!context.ModelState.IsValid)
            context.Result = new UnprocessableEntityObjectResult(context.ModelState);
    }
}