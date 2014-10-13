using System;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, Gender.Male) { }

        public override string ProduceSound()
        {
            return "rawrr!";
        }
    }
}
