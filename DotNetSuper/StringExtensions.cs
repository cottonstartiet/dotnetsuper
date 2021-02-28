namespace DotNetSuper
{
    public static class StringExtensions
    {
        public static bool IsValid(this string input)
        {
            return !string.IsNullOrEmpty(input.Trim()) ;
        }

        public static bool IsNumber(this string input, out int result)
        {
            if (int.TryParse(input, out result))
            {
                return true;
            }

            return false;
        }

        public static string After(this string input, string after)
        {
            return input.Substring(input.IndexOf(after));
        }

        public static string Before(this string input, string before)
        {
            int length = input.IndexOf(before);
            return input.Substring(0, length);
        }
    }
}
