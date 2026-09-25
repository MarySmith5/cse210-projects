using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
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
            Console.WriteLine($"{product.GetId} {product.GetName}");
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
        float subtotal = CalculateProductCost();
        Console.WriteLine($"Subtotal: ${subtotal}");
        float shipping = DetermineShipping();
        Console.WriteLine($"Shipping: ${shipping}");
        Console.WriteLine($"Total: ${subtotal + shipping}");

    }

    private float CalculateProductCost()
    {
        float totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.CalculateTotalCost();
        }
        return totalProductCost;
    }
    
    private float DetermineShipping()
    {
        float shipping;
        if (_customer.IsUS())
        {
            shipping = 5;
        }
        else shipping = 35;
        return shipping;
    }
}