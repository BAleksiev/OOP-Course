using System;

namespace Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid age!");
                }
                this.age = value;
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public override string ToString()
        {
            return string.Format("I am {0}, {1} and i {2}", this.Name, (this.Gender + " " + this.GetType()).ToLower().Replace('.', ' '), this.ProduceSound());
        }

        public abstract string ProduceSound();
    }
}
