using System;
using System.Text;
using System.Collections.Generic;

namespace StringBuilderExtensions
{
    class Program
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder("Example text.");
            IEnumerable<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(text.Substring(1, 3));
            Console.WriteLine(text.RemoveText("exa"));
            Console.WriteLine(text.AppendAll<int>(list));
        }
    }
}
