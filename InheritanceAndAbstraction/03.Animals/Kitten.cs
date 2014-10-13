using System;

namespace Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, Gender.Female) { }

        public override string ProduceSound()
        {
            return "murr!";
        }
    }
}
    