using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Common
{
    public static class ErrorMessages
    {
        public const string LengthErrorMessage = "{0} must be between {2} and {1} characters long!";

        public const string StartTimeErrorMessage = "Start time must be in format HH:MM and between 00:00 and 23:59!";
       
    }
}
