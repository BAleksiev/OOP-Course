using System;

namespace School
{
    class Student : People
    {
        private int classNumber;

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid class number!");
                }
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return "    " + base.ToString() + " - No. " + this.ClassNumber;
        }
    }
}
