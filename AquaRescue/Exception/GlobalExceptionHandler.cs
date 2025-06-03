using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AquaRescue.Exception
{
    public class GlobalExceptionHandler : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var result = new ObjectResult(new
            {
                Erro = context.Exception.Message
            })
            {
                StatusCode = 500
            };

            context.Result = result;
        }
    }
}
