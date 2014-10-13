using System;

namespace Customer
{
    public class Program
    {
        static void Main()
        {
            Payment payment = new Payment("laptop", 600);
            Payment payment2 = new Payment("pc", 2300);

            Customer gosho = new Customer("Gosho", "Goshev", "Goshev", 6212123344, "test address 0", "0123456789", "gosho@gmail.bg", Type.Diamond, payment);
            Customer pesho = new Customer("Pesho", "Peshev", "Peshev", 1567515677, "test address 1", "0897654321", "pesho@abv.bg", Type.Golden, payment);
            Customer tosho = new Customer("Tosho", "Toshev", "Toshev", 4687515615, "test address 23", "0456789123", "tosho@mail.bg", Type.OneTime);

            Console.WriteLine("Are gosho and pesho equal: {0}", Equals(gosho, pesho));
            Console.WriteLine("Are pesho and tosho equal: {0}", Equals(pesho, tosho));
            Console.WriteLine("Are gosho and tosho equal using '==': {0}", (gosho == tosho));
            Console.WriteLine(gosho);
            Console.WriteLine("Pesho HashCode is: {0}", pesho.GetHashCode());

            var nasko = (Customer)pesho.Clone();
            nasko.FirstName = "Nasko";
            nasko.MiddleName = "Atanasov";
            nasko.LastName = "Naskov";
            Console.WriteLine();
            Console.WriteLine("Original after cloning: {0}", pesho);
            Console.WriteLine();
            Console.WriteLine("Clone: {0}", nasko);

            var atanas = (Customer)nasko.Clone();
            atanas.EGN = 411214784;
            Customer[] customers = { gosho, atanas, nasko, pesho };
            Array.Sort(customers);
            Console.WriteLine();
            Console.WriteLine("Sorted customers(first name, egn):");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.EGN);
            }
        }
    }
}
