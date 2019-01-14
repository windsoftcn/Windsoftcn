using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Extensions
{
    public static class ValidateExtensions
    {
        public static T CheckNull<T>(this T value) where T : class => value ?? throw new ArgumentNullException(nameof(value));

        public static T CheckNull<T>(this Nullable<T> value) where T : struct => value ?? throw new ArgumentNullException(nameof(value));


        public static void CheckNullOrWhitespace(this string value)
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{value} cannot be null or whitespace");
        }

        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        public static bool IsNotNullOrWhiteSpace(this string value) => !value.IsNullOrWhiteSpace();

        public static bool IsNull<T>(this T value) where T : class => value == null;

        public static bool IsNotNull<T>(this T value) where T : class => !value.IsNull();

        public static bool IsNull<T>(this Nullable<T> value) where T : struct => value == null;

    }
}
