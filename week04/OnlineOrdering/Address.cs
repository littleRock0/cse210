/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    
    public string CheckCountry()
    {
        return _country;
    }
    
    public string GetDisplayText()
    {
        
    }
}