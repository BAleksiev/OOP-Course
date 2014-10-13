using System;
using System.Linq;

namespace Animals
{
    class Program
    {
        static void Main()
        {
            var animals = new Animal[]
            {
                new Dog("Belcho", 13, Gender.Male),
                new Cat("Buzlio", 9, Gender.Female),
                new Frog("Fizz", 1, Gender.Male),
                new Kitten("Darcy", 5),
                new Tomcat("Tommy", 3)
            };

            animals.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            var animalsBygroups = animals.GroupBy(GetAnimalKind,
                (g, a) => new { kind = g, averagAge = a.Average(animal => animal.Age) });

            foreach (var animalGroup in animalsBygroups)
            {
                Console.WriteLine("The average age of {0}s is {1:f2} years.", animalGroup.kind, animalGroup.averagAge);
            }
        }

        public static string GetAnimalKind(Animal animal)
        {
            string kind = "";
            if (animal.GetType().BaseType.Name == "Animal")
            {
                kind = animal.GetType().Name;
            }
            else
            {
                kind = animal.GetType().BaseType.Name;
            }
            return kind;
        }
    }
}
