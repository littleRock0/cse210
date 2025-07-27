/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("2736N 557W", "Baker", "Utah", "USA");
        Customer customer1 = new Customer("Johan Smidt", address1);
        Product product1 = new Product("", 0, 0.00, 0);
        Order order1 = new Order(customer1);
    }
}