using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    class Discipline : School
    {
        private string name;
        private int lecturesCount;
        private List<Student> students = new List<Student>();

        public Discipline(string name, int lecturesCount)
        {
            this.Name = name;
            this.LecturesCount = lecturesCount;
        }

        public Discipline(string name, int lecturesCount, List<Student> students)
            : this(name, lecturesCount)
        {
            this.students = students;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid discipline name!");
                }
                this.name = value;
            }
        }

        public int LecturesCount
        {
            get { return this.lecturesCount; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number of lectures for this discipline must be greater than 0!");
                }
                this.lecturesCount = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public override string ToString()
        {
            return "  Discipline " + this.Name + ":\n" + string.Join("", this.students.Select(s => s.ToString() + "\n").ToArray());
        }

        public string Ditails { get; set; }
    }
}
