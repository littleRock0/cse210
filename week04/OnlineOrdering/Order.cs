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
    
    public float PriceTotal()
    {
        float total = 0;
        
        foreach (Product product in _products)
        {
            total += product.CoatTotal();
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
    
    public string GetDisplayText()
    {
        return "";
    }
    
    public string GetPackingLabel()
    {
        string packingLabel = "";
        
        foreach (Product product in _products)
        {
            packingLabel += product.GetDisplayText() + "\n";
        }
        
        return packingLabel;
    }
    
    public string GetShippingLabel()
    {
        string shippingLabel = "";
        
        shippingLabel += _customer.GetDisplayText() + "\n";
        
        return shippingLabel;
    }
}