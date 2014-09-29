using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(4);
            list.Add(38);
            list.Add(22);
            list.Add(12);
            list.Add(53);

            Console.WriteLine(list);
        }
    }
}
