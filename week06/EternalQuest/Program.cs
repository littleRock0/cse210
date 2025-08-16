/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
 * Showing Creativity:
 *  added remove Goal function for if you want to remove completed goals or
 *      a goal is nolonger viable
 *  trying to stick as close as possible to the sample Class Design thing
 *      resulted in a few very interesting solutions
 * plan to add more if I have time but hopefully this is enough to qualify
***************************************************************************/
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.Start();
    }
}