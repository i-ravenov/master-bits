using System.Linq;
public static class StringExtensions
{
  public static bool IsUpperCase(this string s)
  {
    return s.All(c => c <= 'Z');
  }
}