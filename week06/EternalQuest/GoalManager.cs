/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    
    public GoalManager()
    {
        
    }
    
    public void Start()
    {
        Write($"You have {_score} points.\n\n");
        Write("Please select one of the following:\n");
        Write("  1. Creat New Goal\n" +
              "  2. List Goals\n" +
              "  3. Save Goals\n" +
              "  4. Load Goals\n" +
              "  5. Record Event\n" +
              "  6. Quit\n");
    }
    
    public void DisplayPlayerInfo()
    {
        
    }
    
    public void ListGoalNames()
    {
        
    }
    
    public void ListGoalDetails()
    {
        
    }
    
    public void CreateGoal()
    {
        
    }
    
    public void RecordEvent()
    {
        
    }
    
    public void SaveGaols()
    {
        
    }
    
    public void LoadGoals()
    {
        
    }
}