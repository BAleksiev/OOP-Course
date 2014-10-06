using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassStudent
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>() {
                new Student("Pesho", "Peshev", 23, "215314", "0123456789", "peshev@abv.bg", new List<int>() {3, 4, 6}, 2),
                new Student("Gosho", "Ivanov", 43, "534513", "0123456789", "goshov@gmail.com", new List<int>() {5, 4, 2, 5, 3}, 2),
                new Student("Tosho", "Goshev", 32, "954209", "0123456789", "tosho@mail.bg", new List<int>() {5, 6, 4, 2, 2, 3}, 1),
                new Student("Minka", "Coneva", 18, "546414", "+359246578", "coneva@abv.bg", new List<int>() {5, 6, 4, 2, 2, 3}, 4)
            };

            students.ForEach(st => Console.WriteLine(st.ToString()));


            // Problem 4. Students by Group
            var selectedStudents = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName).Select(s => string.Format("{0} {1} - {2}", s.FirstName, s.LastName, s.GroupNumber));

            Console.WriteLine("\nProblem 4. Students by Group");
            Console.WriteLine("----------------------------------------------");

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            // Problem 5. Students by First and Last Name
            selectedStudents = students.Where(s => string.Compare(s.FirstName, s.LastName) < 0).Select(s => string.Format("{0} {1}", s.FirstName, s.LastName));

            Console.WriteLine("\nProblem 5. Students by First and Last Name");
            Console.WriteLine("----------------------------------------------");

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            // Problem 6. Students by Age
            var selectedStudentsByAge = students.Where(s => s.Age >= 18 && s.Age <= 24).Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age });

            Console.WriteLine("\nProblem 6. Students by Age");
            Console.WriteLine("----------------------------------------------");

            foreach (var student in selectedStudentsByAge)
            {
                Console.WriteLine(student);
            }

            // Problem 7. Sort StudentsProblem 6. Students by Age
            var sortStudents = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName).Select(s => new { FirstName = s.FirstName, LastName = s.LastName });

            Console.WriteLine("\nProblem 7. Sort StudentsProblem 6. Students by Age");
            Console.WriteLine("----------------------------------------------");

            foreach (var student in sortStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("-------------");

            var querySortStudents =
                from s in students
                orderby s.FirstName + s.LastName descending
                select new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age };

            foreach (var student in querySortStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            // Problem 8. Filter Students by Email Domain
            var selectedStudentsByEmail = students.Where(s => s.Email.Contains("@abv.bg")).Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Email = s.Email });

            Console.WriteLine("\nProblem 8. Filter Students by Email Domain");
            Console.WriteLine("----------------------------------------------");

            foreach (var student in selectedStudentsByEmail)
            {
                Console.WriteLine(student);
            }

            // Problem 9. Filter Students by Phone
            var selectedStudentsByPhone = students.Where(s => s.Phone.IndexOf("02") == 0 || s.Phone.IndexOf("+3592") == 0 || s.Phone.IndexOf("+359 2") == 0).Select(s => string.Format("{0} {1} - {2}", s.FirstName, s.LastName, s.Phone));

            Console.WriteLine("\nProblem 9. Filter Students by Phone");
            Console.WriteLine("----------------------------------------------");

            foreach (var student in selectedStudentsByPhone)
            {
                Console.WriteLine(student);
            }

            // Problem 10. Excellent Students
            var exellentStudents = students.Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks }).Where(s => s.Marks.IndexOf(6) >= 0);

            Console.WriteLine("\nProblem 10. Excellent Students");
            Console.WriteLine("----------------------------------------------");

            foreach (var student in exellentStudents)
            {
                Console.WriteLine("{0} - Marks: {1}", student.FullName, string.Join(", ", student.Marks));
            }

            // Problem 11. Weak Students
            var weakStudents = students.Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks }).Where(st => st.Marks.Where(m => m == 2).Count() == 2);

            Console.WriteLine("\nProblem 11. Weak Students");
            Console.WriteLine("----------------------------------------------");

            foreach (var student in weakStudents)
            {
                Console.WriteLine("{0} - Marks: {1}", student.FullName, string.Join(", ", student.Marks));
            }

            // Problem 12. Students Enrolled in 2014
            var enrolled = from st in students
                           where st.FacultyNumber.EndsWith("14")
                           select st;

            Console.WriteLine("\nProblem 12. Students Enrolled in 2014");
            Console.WriteLine("----------------------------------------------");

            foreach (var student in enrolled)
            {
                Console.WriteLine(student);
            }
        }
    }
}
