using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine(Math.Sqrt(number));
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
