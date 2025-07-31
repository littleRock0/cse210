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
        Order order1 = new Order(new Customer("Johan Smidt", new Address
            ("2736N 557W", "Baker", "Utah", "USA")));
        order1.AddProduct("50x Key Chain Can Openers", "50xP38", 23.48f, 3);
        order1.AddProduct("100x Carpenter Pencils", "100xCar_Pen", 15.23f,
            2);
        order1.AddProduct("3x Fine Tip Sharpie", "3xFTSharp", 1.28f, 47);

        Order order2 = new Order(new Customer("Bartolemue Vorevochke", new
            Address("Ulitsa Lenina, 27", "Kostroma", "Kostromskaya Oblast",
            "Russia")));
        order2.AddProduct("Oathbringer By Brandon Sanderson",
            "Oath_Sanderson", 38.50f, 3);
        order2.AddProduct("Hero of Ages By Brandon Sanderson",
            "HoA_Sanderson", 36.75f, 4);
        order2.AddProduct("Elantris By Brandon Sanderson", "Elnt_Sanderson",
            37.63f, 2);

        Write(order1.GetDisplayText());
        Write(order2.GetDisplayText());
    }
}