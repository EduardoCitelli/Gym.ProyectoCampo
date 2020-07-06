namespace Common
{
    using System.Text.RegularExpressions;

    public static class StringExtensionMethods
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return str == "0" ? true : string.IsNullOrEmpty(str);
        }

        public static string QuitarGuiones(this string str) => str.Replace("-", string.Empty);

        public static string SoloNumeros(this string str) => Regex.Replace(str, @"[^\d]", string.Empty);
    }
}
