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
        string verse = "Jesus wept.";
        Reference reference = new Reference("John", 11, 35);
        Scripture scripture = new Scripture(reference, verse);
    }
}