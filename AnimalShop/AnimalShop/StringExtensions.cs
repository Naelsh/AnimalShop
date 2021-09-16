﻿namespace AnimalShop
{
    public static class StringExtensions
    {
        public static string GetProper(this string text)
        {
            if(text.Length < 2)
            {
                return text.ToUpper();
            }

            return char.ToUpper(text[0]) + text[1..].ToLower();
        }
    }
}
