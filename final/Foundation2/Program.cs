using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some addresses
            Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Address address2 = new Address("456 Maple Rd", "Othertown", "ON", "Canada");

            // Create some customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create some products
            Product product1 = new Product("Widget", "W123", 3.50, 2);
            Product product2 = new Product("Gadget", "G456", 7.25, 1);
            Product product3 = new Product("Doodad", "D789", 5.00, 3);

            // Create orders and add products to them
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Display the packing label, shipping label, and total cost for each order
            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
        }
    }
}
