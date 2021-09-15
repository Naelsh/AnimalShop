using System.Threading;

namespace AnimalShop
{
    public static class StringExtensions
    {
        public static string GetProper(this string text) => Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(text);
    }
}
