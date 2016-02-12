using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace MompreneursIndia.Core
{
    public static class DateTimeExtension
    {
        [DebuggerStepThrough]
        public static bool IsValid(this DateTime target)
        {
            return (target >= DateTime.MinValue) && (target <= DateTime.MaxValue);
        }                           
    }
}