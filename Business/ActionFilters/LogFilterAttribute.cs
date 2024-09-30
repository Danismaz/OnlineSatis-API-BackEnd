using Business.LogModel;
using Business.Sevices.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using NLog.Fluent;

namespace Business.ActionFilters;

public class LogFilterAttribute : ActionFilterAttribute
{
    private readonly ILoggerService _logger;

    public LogFilterAttribute(ILoggerService logger)
    {
        _logger = logger;
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        _logger.LogInfo(Log("OnActionExecuting", context.RouteData));
    }

    private string Log(string modelName, RouteData routeData)
    {
        var logDetails = new LogDetails()
        {
            ModelName = modelName,
            Controller = routeData.Values["controller"],
            Action = routeData.Values["action"],
        };

        if (routeData.Values.ContainsKey("Id"))
            logDetails.Id = routeData.Values["Id"];

        return logDetails.ToString();
    }
}