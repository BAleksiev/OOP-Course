using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Gosho", 1),
                new Student("Pesho", 3),
                new Student("Tosho", 2),
                new Student("Ivan", 4),
                new Student("Gergana", 5)
            };

            var html = new Discipline("HTML", 1);
            html.AddStudent(students[0]);
            html.AddStudent(students[2]);
            html.AddStudent(students[4]);
            html.Ditails = "Fast-Track";

            var css = new Discipline("CSS", 2);
            css.AddStudent(students[0]);
            css.AddStudent(students[1]);
            css.AddStudent(students[2]);

            var csharp = new Discipline("C#", 3);
            csharp.AddStudent(students[1]);
            csharp.AddStudent(students[3]);
            csharp.AddStudent(students[4]);

            var javaScript = new Discipline("JavaScript", 4, students);

            var cSharpTeacher = new Teacher("Svetlin Nakov");
            cSharpTeacher.AddDiscipline(csharp);

            var webFundamentalsTeacher = new Teacher("Vladimir Georgiev");
            webFundamentalsTeacher.AddDiscipline(html);
            webFundamentalsTeacher.AddDiscipline(css);

            var classA = new Class("A", new List<Teacher> { cSharpTeacher, webFundamentalsTeacher });

            Console.WriteLine(classA.ToString());
        }
    }
}
