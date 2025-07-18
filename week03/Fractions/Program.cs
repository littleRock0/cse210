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
        int num1 = 5;
        int num2 = 3;
        int num3 = 4;
        int num4 = 1;

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(num1);
        Fraction fraction3 = new Fraction(num2, num3);
        Fraction fraction4 = new Fraction(num4, num2);
    }
}