using System;

namespace CompanyHierarchy.Person
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Person(string firstName, string lastName, int id)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Id = id;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - ID: {2}", this.FirstName, this.LastName, this.Id);
        }
    }
}

