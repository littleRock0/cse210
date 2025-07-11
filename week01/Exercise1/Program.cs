/*******************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
*******************************************************************************/
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Write("First name: ");
        string firstName = ReadLine();
        
        Write("Last Name: ");
        string lastName = ReadLine();
        
        Write($"Hello {lastName}, {firstName} {lastName}");
    }
}