/*******************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
 ******************************************************************************/
using System;
using System.Globalization; // don't know where this came from ?
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Please enter thea series of numbers enter 0 when done");
        
        float input;
        List<float> numbers = new List<float>();
        float sum = 0;
        float largest = 0;
        
        do
        {
            Write("Enter number: ");
            input = float.Parse(ReadLine());
            
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);
        
        foreach (float number in numbers)
        {
            sum += number;
            
            if (number > largest)
            {
                largest = number;
            }
        }
        
        float avg = sum / numbers.Count;
        
        WriteLine($"Sum: {sum}\nAverage: {avg}\nLargest number: {largest}");
    }
}