using System;

namespace Customer
{
    public class Payment
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Payment(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("\n{0} for {1} BGN", this.ProductName, this.Price);
        }
    }
}
