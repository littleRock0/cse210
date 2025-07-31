/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class Program
{
    static void Display(List<Video> videos)
    {
        foreach (Video video in videos)
        {
            Write(video.GetDisplayText());
        }
    }
    
    static void Main(string[] args)
    {
        Video video1 = new Video("Minecraft LDS Temples Build", "Kobayashi",
            2966);
        video1.AddComment("robot_pineapple", "Could you provide the " +
            "material lists for each of these builds?");
        video1.AddComment("AlanChevyGuy", "Wow that's really impressive " +
            "you're awesome!");
        video1.AddComment("AlfredoCheese", "Could you upload a detailed " +
            $"tutorial the Logan Utah Temple?");
        video1.AddComment("SoNotABot", "NiceVideo CouldWeGetSchems?");
        
        Video video2 = new Video("Almost didn't make it back from this one",
            "climbing@redmont", 47);
        video2.AddComment("BLR", "Glad you made it back in one piece.");
        video2.AddComment("RedThing5G0F@st", "Dude!!!");
        video2.AddComment("longtimefan", "Hope the wife doesn't see this " +
            "one ;P");
        video2.AddComment("#girls_climb2", "nice forearms");
        
        Video video3 = new Video("We Built A Giant Obstical Course",
            "RedMonster", 2192);
        video3.AddComment("littleRock", "I wish I had the money for this");
        video3.AddComment("two2Rochelles", "Where did you source your " +
            "materials?");
        video3.AddComment("pineapple_crafts", "What was your budget for " +
            "this project?");
        video3.AddComment("total_whipe_out", "Could you drop us the plans" +
            " for this ? ");
        
        Display(new List<Video> { video1, video2, video3 });
    }
}