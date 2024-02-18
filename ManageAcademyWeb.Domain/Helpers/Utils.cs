using System.ComponentModel;

namespace ManageAcademyWeb.Domain.Helpers
{
    public static partial class Utils
    {
        public static string Description(this Enum value)
        {
            DescriptionAttribute[] array = (DescriptionAttribute[])value.GetType().GetField(value.ToString())
                ?.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
            return (array != null && array.Length != 0) ? array[0].Description : value.ToString();
        }
    }
}