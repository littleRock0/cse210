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
}