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
        Video video1 = new Video("Minecraft LDS Temples Build", "Kobayashi",
            1966);
        Comment comment1 = new Comment("robot_pineapple", "Could you " +
            "provide the material lists for each of these builds?");
    }
}