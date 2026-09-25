using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();
        Address address1 = new Address("434 Miners Rd.", "Canon City", "CO", "USA");
        Customer customer1 = new Customer("Paul Smith", address1);
        Product product1A = new Product("shower gel", "4SG", 3.75, 1);
        Product product2A = new Product("protein powder", "5PP", 49.95, 2);
        Product product3A = new Product("dental floss", "3DF", 1.50, 3);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1A);
        order1.AddProduct(product2A);
        order1.AddProduct(product3A);
        order1.DisplayPackingLabel();
        Console.WriteLine("------------");
        order1.DisplayShippingLabel();
        Console.WriteLine("------------");
        order1.DisplayTotal();
        Console.WriteLine();

        Console.WriteLine();
        Address address2 = new Address("1164 Morse Ave.", "Sunnyvale", "CA", "USA");
        Customer customer2 = new Customer("Mary Smith", address2);
        Product product1B = new Product("soap", "1BS", 2.75, 3);
        Product product2B = new Product("toothpaste", "2DTP", 5.39, 2);
        Product product3B = new Product("dental floss", "3DF", 1.50, 4);
        Order order2 = new Order(customer2);
        order2.AddProduct(product1B);
        order2.AddProduct(product2B);
        order2.AddProduct(product3B);
        order2.DisplayPackingLabel();
        Console.WriteLine("------------");
        order2.DisplayShippingLabel();
        Console.WriteLine("------------");
        order2.DisplayTotal();
        Console.WriteLine();

        Console.WriteLine();
        Address address3 = new Address("123 Calle de Las Sirenas", "Bella Ciudad", "Alajuela", "Costa Rica");
        Customer customer3 = new Customer("Danielle Rosas", address3);
        Product product1C = new Product("shoes", "6HH", 50.35, 1);
        Product product2C = new Product("toothpaste", "2DTP", 5.39, 1);
        Product product3C = new Product("womens blouse", "7WB", 15.49, 2);
        Order order3 = new Order(customer3);
        order3.AddProduct(product1C);
        order3.AddProduct(product2C);
        order3.AddProduct(product3C);
        order3.DisplayPackingLabel();
        Console.WriteLine("------------");
        order3.DisplayShippingLabel();
        Console.WriteLine("------------");
        order3.DisplayTotal();
        Console.WriteLine();



    }
}