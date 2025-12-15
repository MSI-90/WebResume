using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Entites.Enums.Extends
{
  public static class EnumExtensions
  {
    public static string GetDisplayName(this Enum value)
    {
      var field = value.GetType().GetField(value.ToString());
      if (field == null)
        return value.ToString();

      var attribute = field.GetCustomAttribute<DisplayAttribute>();
      return attribute?.Name ?? value.ToString();
    }
  }
}
