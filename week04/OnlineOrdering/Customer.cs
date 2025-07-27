/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Customer
{
    private string _name;
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    public bool InUSA()
    {
        if (_address.CheckCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public string GetDisplayText()
    {
        string address = _address.GetDisplayText();
        return "";
    }
}