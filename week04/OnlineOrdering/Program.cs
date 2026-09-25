using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        string filePath = "orders.json";

        // 1. Open the file as a stream
        using FileStream openStream = File.OpenRead(filePath);

        // 2. Map case-insensitive properties (e.g., lower-case 'id' in JSON to capital 'Id' in C#)
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        // 3. Deserialize directly into a List<User>
        List<Order> orders = JsonSerializer.Deserialize<List<Order>>(openStream, options);
        foreach(Order order in orders)
        {
            order.DisplayPackingLabel();
            order.DisplayShippingLabel();
            order.DisplayTotal();
        }


    }
}