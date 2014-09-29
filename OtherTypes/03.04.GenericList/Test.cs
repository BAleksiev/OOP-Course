using System;

namespace GenericList
{
    class Test
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(4);

            Console.WriteLine("Added elements:");
            list.Add(38);
            list.Add(22);
            list.Add(12);
            list.Add(53);
            list.Add(55);

            Console.WriteLine(list);

            Console.WriteLine("Element at possition 1: " + list.FindAt(1));

            list.Remove(2);
            Console.WriteLine("\nElements after removing element at possition 2:");
            Console.WriteLine(list);

            list.Insert(2, 11);
            Console.WriteLine("Elements after inserting element at possition 2:");
            Console.WriteLine(list);

            int elementIndex = list.IndexOf(11);
            Console.WriteLine("Index of element with value \"11\": " + elementIndex); ;

            bool contains = list.Contains(55);
            Console.WriteLine("\nIf element contains value \"55\"? " + contains);

            Console.WriteLine("\nMin element: " + list.Min());
            Console.WriteLine("\nMax element: " + list.Max());

            var allAttributes = typeof(GenericList<>).GetCustomAttributes(typeof(Version), false);
            Console.WriteLine("\nVersion: " + allAttributes[0]);

            list.Clear();
            Console.WriteLine(list);
        }
    }
}
