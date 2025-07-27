/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;
    
    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    
    public float CoatTotal()
    {
        return _price * _quantity;
    }
    
    public string GetDisplayText()
    {
        
    }
}