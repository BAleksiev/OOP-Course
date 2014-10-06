using System;
using System.Collections.Generic;

namespace ClassStudent
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Invalid first name!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Invalid last name!");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0 || value > 150)
                {
                    throw new ArgumentOutOfRangeException("Invalid age!");
                }
                this.age = value;
            }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public string Phone
        {
            get { return this.phone; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Invalid phone number!");
                }
                this.phone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Invalid email address!");
                }
                this.email = value;
            }
        }

        public IList<int> Marks
        {
            get { return this.marks; }
            set
            {
                if (value == null)
                {
                    this.marks = new List<int>();
                }
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public override string ToString()
        {
            string marks = string.Join(", ", this.Marks as IEnumerable<int>);

            return string.Format(
            "{0} {1}, age: {2}, fac number: {3}, phone: {4}, email: {5}, marks: {{ {6} }}, group: {7}",
            this.FirstName,
            this.LastName,
            this.Age,
            this.FacultyNumber,
            this.Phone,
            this.Email,
            marks,
            this.GroupNumber);
        }

    }
}
