/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class ExcersizeManager
{
    private List<Excersize> _excersizes = new List<Excersize>();
    
    public ExcersizeManager()
    {
        
    }
    
    public void Start()
    {
        bool quit = false;
        
        while (!quit)
        {
            
            Write("\nWhat type of excersize did you do:\n");
            Write("  1. Running\n" +
                "  2. Lap Swim\n" +
                "  3. Spinning\n" +
                "  4. End Session\n");
            
            int selection = int.Parse(ReadLine());
            
            if (selection == 1)
            {
                EnterRun();
            }
            else if (selection == 2)
            {
                EnterSwim();
            }
            else if (selection == 3)
            {
                Cycling();
            }
            else if (selection == 4)
            {
                quit = true;
            }
            else
            {
                WriteLine("Error Invalid Input. Please try again.");
            }
        }
    }
    
    public string GetDate()
    {
        DateTime today = DateTime.Now.Date;
        
        string date = today.ToString("dd MMM yyyy");
        
        return date;
    }
    
    public void EnterRun()
    {
        Write("How many miles did you run? ");
        
        float miles = float.Parse(ReadLine());
        
        Write("Number of minutes ran: ");
        
        int duration = int.Parse(ReadLine());
        
        string date = GetDate();
        
        Running newRun = new Running(miles, date, duration);
    }
    
    public void EnterSwim()
    {
        Write("How many laps did you swim? ");
        
        int laps = int.Parse(ReadLine());
        
        Write("Number of minutes spent swimming: ");
        
        int duration = int.Parse(ReadLine());
        
        string date = GetDate();
        
        LapSwim newSwim = new LapSwim(laps, date, duration);
    }
    
    public void Cycling()
    {
        Write("What was your average speed in mph? ");
        
        int mph = int.Parse(ReadLine());
        
        Write("Number of minutes spent cycling: ");
        
        int duration = int.Parse(ReadLine());
        
        string date = GetDate();
        
        StationaryBicycles newCycle = new StationaryBicycles(mph, date,
            duration);
    }
}