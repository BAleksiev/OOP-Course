﻿using System;

namespace Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null) { }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if(value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Invalid age!");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if(value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Invalid Email!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("name: {0}, age: {1}", this.Name, this.Age) + (this.Email == null ? "" : ", email: " + this.Email);
        }
    }
}