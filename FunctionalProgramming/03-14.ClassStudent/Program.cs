using System;
using System.Collections.Generic;

namespace ClassStudent
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>() {
                new Student("Pesho", "Peshev", 23, "324234", "0123456789", "peshev@peshev.info", List<int>() {3, 4, 6}, 2);
            }
        }
    }
}
