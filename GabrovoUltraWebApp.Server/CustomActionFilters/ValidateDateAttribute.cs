using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Globalization;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Race;
namespace GabrovoUltraWebApp.Server.CustomActionFilters
{
    public class ValidateDateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            if (actionContext.ActionArguments.ContainsKey("raceRequestDTO"))
            {
                var createRaceRequestDTO = actionContext.ActionArguments["raceRequestDTO"] as CreateOrUpdateRaceRequestDTO;
                if (createRaceRequestDTO != null)
                {
                    if (!DateTime.TryParseExact(createRaceRequestDTO.Date, DateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                    {
                        actionContext.ModelState.AddModelError("Date", $"Invalid date format. Please use {DateTimeFormat}");
                    }
                }
            }
        }
    }
}
