using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("PackingLabel:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetId()} {product.GetName()}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("ShippingLabel:");
        Console.WriteLine(_customer.GetName());
        _customer.GetAddress().DisplayFullAddress();

    }

    public void DisplayTotal()
    {
        double subtotal = CalculateProductCost();
        Console.WriteLine($"Subtotal: ${subtotal}");
        int shipping = DetermineShipping();
        Console.WriteLine($"Shipping: ${shipping}");
        Console.WriteLine($"Total: ${subtotal + shipping}");

    }

    private double CalculateProductCost()
    {
        double totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.CalculateTotalCost();
        }
        return totalProductCost;
    }
    
    private int DetermineShipping()
    {
        int shipping;
        if (_customer.IsUS())
        {
            shipping = 5;
        }
        else shipping = 35;
        return shipping;
    }
}