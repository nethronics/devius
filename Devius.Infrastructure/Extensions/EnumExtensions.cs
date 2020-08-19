using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Devius.Infrastructure.Extensions
{
    public static class EnumExtensions
    {
        //public static IDictionary<Enum, string> ToDictionary(this Enum enumerator)
        //{

        //}

        public static string GetDisplayName(this Enum value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var name = value.ToString();
            var field = value.GetType().GetField(name);
            var attributes = (DisplayAttribute[])field.GetCustomAttributes(typeof(DisplayAttribute), false);

            if (attributes.Length > 0)
                name = attributes.First().Description;

            return name;
        }
    }
}
