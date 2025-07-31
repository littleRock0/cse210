/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    public void AddProduct(string name, string productId, float price,
        int quantity)
    {
        _products.Add(new Product(name, productId, price, quantity));
    }
    
    public float PriceTotal()
    {
        float total = 0;
        
        foreach (Product product in _products)
        {
            total += product.CostTotal();
        }
        
        if (_customer.InUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        
        return total;
    }
    
    public string GetPackingLabel()
    {
        string packingLabel = "";
        
        foreach (Product product in _products)
        {
            packingLabel += product.GetDisplayText() + "\n";
        }
        
        return $"Packing Label:\n{packingLabel}\n";
    }
    
    public string GetShippingLabel()
    {
        string shippingLabel;
        
        shippingLabel = $"Shipping Label:\n{_customer.GetDisplayText()}" +
            "\n\n \n";
        
        return shippingLabel;
    }
    
    public string GetDisplayText()
    {
        return $"Order:\nTotal:${PriceTotal()}\n\n{GetPackingLabel()}" +
            GetShippingLabel();
    }
}