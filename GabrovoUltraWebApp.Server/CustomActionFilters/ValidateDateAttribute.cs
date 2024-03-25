using GabrovoUltraWebApp.Infrastructure.Models.ImportDTO;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Globalization;

namespace GabrovoUltraWebApp.Server.CustomActionFilters
{
    public class ValidateDateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            if (actionContext.ActionArguments.ContainsKey("createRaceRequestDTO"))
            {
                var createRaceRequestDTO = actionContext.ActionArguments["createRaceRequestDTO"] as CreateRaceRequestDTO;
                if (createRaceRequestDTO != null)
                {
                    if (!DateTime.TryParseExact(createRaceRequestDTO.Date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                    {
                        actionContext.ModelState.AddModelError("Date", "Invalid date format. Please use yyyy-MM-dd");
                    }
                }
            }
        }
    }
}
