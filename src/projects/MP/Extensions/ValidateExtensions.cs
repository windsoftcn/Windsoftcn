using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Extensions
{
    public static class ValidateExtensions
    {
        public static T CheckNull<T>(this T value) where T : class => value ?? throw new ArgumentNullException(nameof(value));


        public static void CheckNullOrWhitespace(this string value)
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{value} cannot be null or whitespace");
        }

        public static bool IsNull<T>(this T value) where T : class => value == null;
        
    }
}
