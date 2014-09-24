using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            for (int i = 0; i < 10; i++)
            {
                start = ReadNumber(start, end);
            }
        }

        static int ReadNumber(int start, int end)
        {
            int number = 0;

            try
            {
                Console.Write("Enter number in range {0} - {1}: ", start + 1, end - 1);
                number = int.Parse(Console.ReadLine());

                while (!(start < number && number < end))
                {
                    Console.WriteLine("Your number is not in range {0} - {1}!", start + 1, end - 1);
                    Console.Write("Enter number in range {0} - {1}: ", start + 1, end - 1);
                    number = int.Parse(Console.ReadLine());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return number;
        }
    }
}
