using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DevFreela.API.Filters
{
    public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Executado depois de chegar na Action
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //executado antes de chegar na Action
            
            if (!context.ModelState.IsValid)
            {
                var messages = context.ModelState
                                    .SelectMany(ms => ms.Value.Errors)
                                    .Select(e => e.ErrorMessage)
                                    .ToList();

                context.Result = new BadRequestObjectResult(messages);
            }
        }
    }
}
