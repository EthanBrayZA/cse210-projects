class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Apple AirPods pro", 1234, 249.99m, 1);
        Product product2 = new Product("Instant Pot Duo 7-in-1 Electric Pressure Cooker", 5678, 99.95m, 1);
        Product product3 = new Product("Sony PlayStation 5", 9012, 499.99m, 1);
        Product product4 = new Product("Samsung 55inch 4K Smart QLED TV", 7018, 1099.99m, 1);
        Product product5 = new Product("Fitbit Charge 4 Fitness and Activity Tracker", 9429, 149.95m, 1);

        // Create customer
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create customer
        Address address2 = new Address("27 Elm St", "Discovery", "Gauteng", "South Africa");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order 1 information
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");
        Console.WriteLine("----------------------------------------");

        // Display order 2 information
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
        Console.WriteLine("----------------------------------------");
    }
}