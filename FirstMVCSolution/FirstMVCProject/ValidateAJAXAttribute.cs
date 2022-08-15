using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace FirstMVCProject
{
    public class ValidateAJAXAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return;

            var modelState = context.ModelState;
            if (!modelState.IsValid)
            {
                var errors = modelState
                    .Where(x => x.Value.Errors.Count() > 0)
                    .Select(y => new BadRequestModel
                    {
                        Key = y.Key,
                        ErrorMessages = y.Value.Errors.Select(z => z.ErrorMessage).ToArray()
                    }).ToList();

                context.Result = new JsonResult(errors);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }
    }
}