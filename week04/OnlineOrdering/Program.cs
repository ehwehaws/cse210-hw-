using System;

class Program
{
    static void Main(string[] args)
    {
        //cust1
        Address addr1 = new Address("33 easy st", "San Antonio", "ID", "USA");
        Customer cust1 = new Customer("Jim John", addr1);
        Order order1 = new Order(cust1);
        order1.AddItem(new Product("Shoes", "A1", 1.5, 4));
        order1.AddItem(new Product("Toothpaste", "B2", .75, 6));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total: " + order1.GetTotal());
        Console.WriteLine();
        //cust2
        Address addr2 = new Address("45 Long", "Italy", "Ile", "Rome");
        Customer cust2 = new Customer("Timothy", addr2);
        Order order2 = new Order(cust2);
        order2.AddItem(new Product("Roman Sword", "BG1", 2.5, 2));
        order2.AddItem(new Product("Roman Shield", "CH2", 4.25, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total: " + order2.GetTotal());









    }
}