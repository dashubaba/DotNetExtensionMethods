using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MompreneursIndia.Core
{
    public static class EnumerableExtension
    {
        [DebuggerStepThrough]
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T item in enumerable)
            {
                action(item);
            }
        }

        [DebuggerStepThrough]
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return (enumerable == null) || (enumerable.Count() == 0);
        }
    }
}