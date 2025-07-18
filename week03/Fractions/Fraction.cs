/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Fraction
{
    private int _numerator;
    private int _denominator;
    
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    
    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }
}