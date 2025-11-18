using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        //create the products
        Product p1 = new Product("Coffee Mug", 1001, 9.99, 2); //for order 1
        Product p2 = new Product("T-Shirt", 1002, 19.99, 1);
        Product p3 = new Product("USB Cable", 1003, 4.99, 3);

        Product p4 = new Product("Notebook", 2001, 6.50, 2); //for order 2
        Product p5 = new Product("Pen Pack", 2002, 2.99, 5);

        Product p6 = new Product("Aliminum Foils", 3001, 7.55, 2); //for order 3
        Product p7 = new Product("Potatos", 3002, 4, 8);

        Address addressUs = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Williame Wallace", addressUs);

        Address addressMa = new Address("121 Mhamid Saada", "Marrakech", "Tansift-el-haouz", "Morocco");
        Customer customer2 = new Customer("Hamza Bouhou", addressMa);

        Address addressUsSecond = new Address("69 W 9th St", "New York", "NY 10011", "USA");
        Customer customer3 = new Customer("Mathew The Great", addressUsSecond);

        Order order1 = new Order(customer1, new List<Product> { p1, p2, p3 });
        Order order2 = new Order(customer2, new List<Product> { p4, p5 });
        Order order3 = new Order(customer3, new List<Product> { p6, p7 });

        Console.WriteLine(order1.GetPackingLable());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order total inc Shipping: ${order1.CalculateTotalOrder():0.00} \n");

        Console.WriteLine(order2.GetPackingLable());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order total inc Shipping: ${order2.CalculateTotalOrder():0.00} \n");

        Console.WriteLine(order3.GetPackingLable());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Order total inc Shipping: ${order3.CalculateTotalOrder():0.00} \n");










    }
}