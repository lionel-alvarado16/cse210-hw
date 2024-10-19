using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        // Order 1
        List<Product> products1 = [
            new Product("Wheat Bread", "W112", 2.55, 2),
            new Product("1 Cup Yogurt", "D083", 0.75, 4),
            new Product("Twix Candy Bar", "C013", 0.85, 2),
            new Product("1 Gallon Milk", "D150", 3.85, 3)
        ];

        Address address1 = new Address("720 N Main St", "Salt Lake City", "UT", "USA");

        Customer customer1 = new Customer("Kenneth Green", address1);

        // Order 2

        List<Product> products2 = [
            new Product("Laptop", "L450", 2250, 1),
            new Product("Keyboard", "K126", 16.99, 3),
            new Product("Mouse", "M521", 8.90, 4),
            new Product("Monitor", "MN63", 79.97, 2)
        ];

        Address address2 = new Address("450 Ca. Aviación", "Surco", "Lima", "Peru");

        Customer customer2 = new Customer("Lionel Alvarado", address2);

        List<Order> orders = [
            new Order(products1, customer1),
            new Order(products2, customer2)
            ];

        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine($"ORDER {i+1}\n");
            Console.WriteLine($"Packing Label \n{orders[i].PackingLabel()}");
            Console.WriteLine($"Shipping Label \n{orders[i].ShippingLabel()}");
            Console.WriteLine($"\nTotal price of the order: \n${Math.Round(orders[i].TotalCost(), 2)}\n");
        }
    }
}