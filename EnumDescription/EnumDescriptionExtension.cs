using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EnumDescription
{
    public static class EnumDescriptionExtension
    {
        public static string GetEnumDescriptionWithoutGenerics(this Enum item)
        {
            var value = item.ToString();
            var member = item.GetType().GetMember(value)[0];
            DescriptionAttribute description = (DescriptionAttribute)member
                .GetCustomAttributes(typeof(DescriptionAttribute))
                .FirstOrDefault();

            return description?.Description ?? value;
        }

        public static string GetEnumDescriptionWithGenerics<T>(this T item) where T : Enum
        {
            var value = item.ToString();
            var member = typeof(T).GetMember(value)[0];
            DescriptionAttribute description = (DescriptionAttribute)member
                .GetCustomAttributes(typeof(DescriptionAttribute))
                .FirstOrDefault();

            return description?.Description ?? value;
        }
    }
}