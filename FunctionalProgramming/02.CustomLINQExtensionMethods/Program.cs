using System;
using System.Collections.Generic;

namespace CustomLINQExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(string.Join(", ", nums.WhereNot<int>(a => a == 4)));
            Console.WriteLine(string.Join(", ", nums.Repeat<int>(3)));

            IEnumerable<string> stringItems = new List<string>() { "banana", "apple", "cherry", "orange", "lime" };
            IEnumerable<string> suffixes = new List<string>() { "ana", "ge" };

            Console.WriteLine(string.Join(", ", stringItems.WhereEndsWith(suffixes)));
        }
    }
}
