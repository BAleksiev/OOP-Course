using System;
using System.Text.RegularExpressions;

namespace HumanStudentAndWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                var regex = new Regex("[\\dA-Za-z]");
                var matches = regex.Matches(value);

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid faculty number!");
                }
                else if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number must be 5-10 digits / letters!");
                }
                else if (value.Length > matches.Count)
                {
                    throw new ArgumentException("Invalid faculty number. Use only digits and/or letters");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this.FacultyNumber;
        }
    }
}
