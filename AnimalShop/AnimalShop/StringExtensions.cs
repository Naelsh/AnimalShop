namespace AnimalShop
{
    public static class StringExtensions
    {
        public static string ToProper(this string text)
        {
            return text.Length < 2 ? text.ToUpper() : char.ToUpper(text[0]) + text[1..].ToLower();
        }
    }
}
