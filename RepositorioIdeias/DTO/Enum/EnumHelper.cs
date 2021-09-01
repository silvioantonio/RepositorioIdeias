using System;
using System.ComponentModel;

namespace RepositorioIdeias.DTO.Enum
{
    public static class EnumHelper
    {
        public static string GetDescription<T>(this T enumValue) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return null;
            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                var attribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attribute != null && attribute.Length > 0)
                {
                    description = ((DescriptionAttribute)attribute[0]).Description;
                }
            }

            return description;
        }
    }
}
