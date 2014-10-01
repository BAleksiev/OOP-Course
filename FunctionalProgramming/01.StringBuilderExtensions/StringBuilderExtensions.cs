using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace StringBuilderExtensions
{
    static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder inputString, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            return result.Append(inputString.ToString().Substring(startIndex, length));
        }

        public static StringBuilder RemoveText(this StringBuilder inputString, string text)
        {
            string modified = Regex.Replace(inputString.ToString(), text, string.Empty, RegexOptions.IgnoreCase);

            inputString.Clear();
            inputString.Append(modified);

            return inputString;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder inputString, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                inputString.Append(item.ToString());
            }

            return inputString;
        }
    }
}
