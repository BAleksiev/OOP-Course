using System;

namespace BitArray
{
    class BitArrayClass
    {
        static void Main()
        {
            BitArray num = new BitArray(8);
            num[0] = 1;
            num[3] = 1;
            num[6] = 1;
            Console.WriteLine(num);
        }
    }
}