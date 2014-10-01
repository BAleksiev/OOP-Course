using System;
using System.Threading;

namespace AsynchronousTimer
{
    class Program
    {
        public static void Test1(int num)
        {
            Console.WriteLine("First timer: " + num);
        }

        public static void Test2(int num)
        {
            Console.WriteLine("Second timer: " + num);
        }

        public static void Main(string[] args)
        {

            var firstTimer = new AsyncTimer(Test1, 5, 500);
            var secondTimer = new AsyncTimer(Test2, 5, 1000);

            firstTimer.Run();
            secondTimer.Run();
        }
    }
}
