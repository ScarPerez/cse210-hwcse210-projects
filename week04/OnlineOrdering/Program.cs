using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A1", 800, 1));
        order1.AddProduct(new Product("Mouse", "B2", 20, 2));

        // Order 2 (International)
        Address address2 = new Address("Zona 1", "Guatemala City", "Guatemala", "Guatemala");
        Customer customer2 = new Customer("Scarlett Perez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "C3", 500, 1));
        order2.AddProduct(new Product("Headphones", "D4", 50, 2));

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalCost()}");

        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalCost()}");
    }
}