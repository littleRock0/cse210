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
    private string _region;
    private string _country;
    
    public Address(string streetAddress, string city, string region, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _region = region;
        _country = country;
    }
    
    public string CheckCountry()
    {
        return _country;
    }
    
    public string GetDisplayText()
    {
        return $"{_streetAddress}\n{_city},{_region}\n{_country}";
    }
}