/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using System.ComponentModel.Design;
using static System.Console;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    
    public GoalManager()
    {
        
    }
    
    public void Start()
    {
        bool quit = false;
        
        while (!quit)
        {
            Write($"\nYou have {_score} points.\n");
            Write("\nPlease select one of the following:\n");
            Write("  1. Creat New Goal\n" +
                  "  2. List Goals\n" +
                  "  3. Save Goals\n" +
                  "  4. Load Goals\n" +
                  "  5. Record Event\n" +
                  "  7. Quit\n");
            
            int selection = int.Parse(ReadLine());
            
            if (selection == 1)
            {
                CreateGoal();
            }
            if (selection == 2)
            {
                ListGoals();
            }
            else if (selection == 3)
            {
                SaveGoals();
            }
            else if (selection == 4)
            {
                RecordEvent();
            }
            else if (selection == 5)
            {
                LoadGoals();
            }
            else if (selection == 6)
            {
                DeleteGoal();
            }
            else if (selection == 7)
            {
                quit = true;
            }
            else
            {
                WriteLine("Invalid input. Please try again.");
            }
        }
    }
    
    public void DeleteGoal()
    {
        Write("Which goal would you like to delete: ");
        
        foreach (Goal goal in _goals)
        {
            Write($"  {_goals.IndexOf(goal) + 1}. {goal.GetDetailsString().
                Split(new string[] { " (" }, StringSplitOptions.None)[0]}");
        }
        
        int selection = int.Parse(ReadLine()) - 1;
        
        _goals.RemoveAt(selection);
    }
    
    public void ListGoals()
    {
        char tick = ' ';
        
        Write("Your Goals:\n");
        
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                tick = 'X';
            }
            
            Write($"  {_goals.IndexOf(goal) + 1}. [{tick}] " +
                $"{goal.GetDetailsString()}\n");
        }
    }
    
    public void CreateGoal(int goalType = 0, string fromFile = "")
    {
        if (fromFile.Length == 0)
        {
            Write("Goal type:\n");
            Write("  1. Simple Goal\n" +
                "  2. Eternal Goal\n" +
                "  3. Checklist Goal\n");
            
            goalType = int.Parse(ReadLine());
            
            if (goalType == 1)
            {
                Write("Name of your goal: ");
                
                string goalName = ReadLine();
                
                Write("Short description of your goal: ");
                
                string goalDescription = ReadLine();
                
                Write("How many points is this goal worth? ");
                
                int goalPoints = int.Parse(ReadLine());
                
                SimpleGoal newSimpleGoal = new SimpleGoal(goalName,
                    goalDescription, goalPoints);
                
                _goals.Add(newSimpleGoal);
                
                return;
            }
            else if (goalType == 2)
            {
                Write("Name of your goal: ");
                
                string goalName = ReadLine();
                
                Write("Short description of your goal: ");
                
                string goalDescription = ReadLine();
                
                Write("How many points is this goal worth? ");
                
                int goalPoints = int.Parse(ReadLine());
                
                EternalGoal newEternalGoal = new EternalGoal(goalName,
                    goalDescription, goalPoints);
                
                _goals.Add(newEternalGoal);
                
                return;
            }
            else if (goalType == 3)
            {
                Write("Name of your goal: ");
                
                string goalName = ReadLine();
                
                Write("Short description of your goal: ");
                
                string goalDescription = ReadLine();
                
                Write("How many points is this goal worth? ");
                
                int goalPoints = int.Parse(ReadLine());
                
                Write("Number of times to complete for bonus: ");
                
                int goalCount = int.Parse(ReadLine());
                
                Write("Bonus Points: ");
                
                int bonusPoints = int.Parse(ReadLine());
                
                ChecklistGoal newChecklist = new ChecklistGoal(goalCount,
                    bonusPoints, goalName, goalDescription, goalPoints);
                
                _goals.Add(newChecklist);
                
                return;
            }
            else
            {
                WriteLine("Invalid input. Please try again.");
            }
        }
        else
        {
            string[] elements = fromFile.Split("<|>");
            
            if (goalType == 1)
            {
                SimpleGoal newSimpleGoal = new SimpleGoal(elements[0],
                    elements[1], int.Parse(elements[2]),
                    bool.Parse(elements[3]));
                
                _goals.Add(newSimpleGoal);
            }
            else if (goalType == 2)
            {
                EternalGoal newEternalGoal = new EternalGoal(elements[0],
                    elements[1], int.Parse(elements[2]));
                
                _goals.Add(newEternalGoal);
            }
            else if (goalType == 3)
            {
                ChecklistGoal newChecklistGoal = new ChecklistGoal(
                    int.Parse(elements[3]), int.Parse(elements[4]),
                    elements[0], elements[1], int.Parse(elements[2]),
                    int.Parse(elements[5]));
                    
                _goals.Add(newChecklistGoal);
            }
            else
            {
                Write("FileReadError: Check Load/Save File Format/Layout");
            }
        }
    }
    
    public void SaveGoals()
    {
        Write("Name of file to save to: ");
        
        string file = ReadLine();
        
        using (StreamWriter saveFile = new StreamWriter(file))
        {
            saveFile.WriteLine(_score);
            
            foreach (Goal goal in _goals)
                saveFile.WriteLine($"{goal.GetStringRepresentation()}");
        }
    }
    
    public void RecordEvent()
    {
        Write("Which goal did you accomplish: ");
        
        foreach (Goal goal in _goals)
        {
            Write($"  {_goals.IndexOf(goal) + 1}. {goal.GetDetailsString().
                Split(new string[] { " (" }, StringSplitOptions.None)[0]}");
        }
        
        int selection = int.Parse(ReadLine()) - 1;
        
        _goals[selection].RecordEvent();
    }
    
    public void LoadGoals()
    {
        _goals.Clear();
        
        Write("Name of file to load from: ");
        
        string file = ReadLine();
        
        string[] lines = File.ReadAllLines(file);
        
        _score = int.Parse(lines[0]);
        
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(":");
            
            int type = 0;
            string typeName = parts[0];
            string body = parts[1];
            
            if (typeName == "SimpleGoal")
            {
                type = 1;
            }
            else if (typeName == "EternalGoal")
            {
                type = 2;
            }
            else if (typeName == "ChecklistGoal")
            {
                type = 3;
            }
            
            CreateGoal(type, body);
        }
    }
}