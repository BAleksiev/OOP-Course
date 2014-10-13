namespace StringDisperser
{
    using System;

    class Program
    {
        static void Main()
        {
            StringDisperser gosho = new StringDisperser("Gosho", "Goshev", "Goshev");
            StringDisperser pesho = new StringDisperser("Pesho", "Peshev", "Peshev");
            Console.WriteLine("Are gosho and ivan equal: {0}", Equals(gosho, pesho));
            Console.WriteLine("Are gosho and pesho equal using '!=': {0}", (gosho != pesho));
            Console.WriteLine(gosho);
            Console.WriteLine(pesho);
            Console.WriteLine();

            StringDisperser tosho = new StringDisperser("Tosho", "Toshev");
            StringDisperser[] stringDispersers = { tosho, gosho };
            Array.Sort(stringDispersers);
            Console.WriteLine("Sort by total string lexicographically");

            foreach (var stringDisperser in stringDispersers)
            {
                Console.WriteLine(stringDisperser);
            }

            Console.WriteLine("Foreach total string");
            foreach (var ch in tosho)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            StringDisperser toshoNew = (StringDisperser)tosho.Clone();
            toshoNew.Text = new string[2] { "Nov", "Toshko" };
            Console.WriteLine("Clone:");
            Console.WriteLine("original: {0}", tosho);
            Console.WriteLine("cloning: {0}", toshoNew);

        }
    }
}
