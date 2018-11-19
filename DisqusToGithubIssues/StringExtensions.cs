using System;

namespace DisqusToGithubIssues
{
    public static class StringExtensions
    {
        public static int ToInteger(this string value)
        {
            if (Int32.TryParse(value, out int result))
            {
                return result;
            }
            return 0;
        }

        public static DateTime ToDateTime(this string value)
        {
            if (DateTime.TryParse(value, out DateTime result))
            {
                return result;
            }
            return DateTime.Now;
        }
    }
}