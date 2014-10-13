using System;

namespace School
{
    class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid person name!");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
