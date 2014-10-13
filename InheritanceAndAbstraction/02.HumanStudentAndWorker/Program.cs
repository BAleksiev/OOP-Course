using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanStudentAndWorker
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Ivan", "Ivanov", "54vy45y"),
                new Student("Petar", "Petrov", "3490cmg3"),
                new Student("Todor", "Todorov", "ve6bgwe5bw"),
                new Student("Dimitar", "Dimitrov", "cw4b5crrs"),
                new Student("Angel", "Angelov", "bvt6bv4"),
                new Student("Atanas", "Atanasov", "b56bw4"),
                new Student("Boris", "Borisov", "vw45h4h"),
                new Student("Gergana", "Gerganova", "vrthw4"),
                new Student("Desislava", "Desislavova", "vwrt45h"),
                new Student("Elena", "Elenova", "hw56df")
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("John", "Doe", 350, 8),
                new Worker("Gergana", "Gerganova", 240, 6),
                new Worker("Iva", "Ivova", 290, 8),
                new Worker("Vasil", "Vasilov", 320, 7),
                new Worker("Evgeni", "Evgeniev", 480, 8),
                new Worker("Minka", "Minka", 150, 8),
                new Worker("Angelina", "Angelova", 270, 4),
                new Worker("Bill", "Jobs", 500, 2),
                new Worker("Steve", "Gates", 500, 3),
                new Worker("Kevin", "Mitnic", 9999, 1)
            };

            var sortedStudentByFacultyNumber = students.OrderBy(s => s.FacultyNumber);
            Console.WriteLine("Students sorted by faculty number:\n----------------------------------");
            Console.WriteLine(string.Join("\n", sortedStudentByFacultyNumber.Select(s => s.ToString())));
            Console.WriteLine();

            var sortedWorkerByPaymentPerHour = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine("Workers sorted by payment per hour (descending order):\n------------------------------------------------------");
            Console.WriteLine(string.Join("\n", sortedWorkerByPaymentPerHour.Select(w => w.ToString())));
            Console.WriteLine();

            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var sortHumansByNames = humans
                .OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName)
                .Select(h => h.FirstName + " " + h.LastName);
            Console.WriteLine("Merged students and workers and ordered by names:\n-------------------------------------------------");
            Console.WriteLine(string.Join("\n", sortHumansByNames));
        }
    }
}
