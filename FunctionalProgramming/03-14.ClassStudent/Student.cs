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
                if (age <= 0 || age > 150)
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
            set { this.marks = value; }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

    }
}
