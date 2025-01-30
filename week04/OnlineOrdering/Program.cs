using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address adressUsa = new Address("123 Porter East", "Portland", "Oregon", "USA");
        Customer customerUsa = new Customer("Donald Trump", adressUsa);

        Address adressMexico = new Address("123 Chimichanga", "Chihuahua", "Chihuahua", "Mexico");
        Customer customerMexico = new Customer("Alejandro", adressMexico);



        Product product1 = new Product("Notebook", "#2001", 999.99, 1);
        Product product2 = new Product("Battery", "#2002", 10, 5);

        Product product3 = new Product("SmartPhone", "#3001", 799.99, 1);
        Product product4 = new Product("Tortillas", "#3002", 10, 6);


         Order order1 = new Order(customerUsa);
         order1.AddProduct(product1);
         order1.AddProduct(product2);

         Order order2 = new Order(customerMexico);
         order2.AddProduct(product3);
         order2.AddProduct(product4);


         Console.WriteLine("Order 1:");
         Console.WriteLine($"{order1.GetPackLabel()}");
         Console.WriteLine($"{order1.GetShippLabel()}");
         Console.WriteLine($"Total Price: {order1.GetTotalPrice()}");
         Console.WriteLine();
         Console.WriteLine("Order 2 Details:");
         Console.WriteLine(order2.GetPackLabel());
         Console.WriteLine(order2.GetShippLabel());
         Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");

    }
}