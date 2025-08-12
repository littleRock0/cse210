/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private string[] _lines1;
    private string[] _lines2;
    
    public ReflectingActivity(string name,
        string description) : base(name, description)
    {
        string file1 = "ReflectingPrompts.txt";
        _lines1 = File.ReadAllLines(file1);
        
        foreach (string line in _lines1)
        {
            AddPrompt(line);
        }
        
        string file2 = "ReflectingQuestions.txt";
        _lines2 = File.ReadAllLines(file2);
        
        foreach (string line in _lines2)
        {
            AddQuestion(line);
        }
    }
    
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    
    public void AddQuestion(string question)
    {
        _questions.Add(question);
    }
    
    public void Run()
    {
        DisplaySartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        DateTime currentTime = DateTime.Now;
        
        Random number = new Random();
        
        DisplayPrompt(number);
        
        while (currentTime <= futureTime)
        {
            DisplayQuestions(number);
            
            currentTime = DateTime.Now;
        }
        
        DisplayEndMessage();
        
        return;
    }
    
    public string GetRandomPrompt(Random number)
    {
        int promptNum = number.Next(0, _lines1.Length);
        
        string prompt = _prompts[promptNum];
        
        return prompt;
    }
    
    public string GetRandomQuestion(Random number)
    {
        int questionNum = number.Next(0, _lines2.Length);
        
        string question = _questions[questionNum];
        
        return question;
    }
    
    public void DisplayPrompt(Random number)
    {
        WriteLine("Consider the following: \n");
        WriteLine($" --- {GetRandomPrompt(number)} --- \n");
        Write("When you have something in mind press enter.\n");
        
        ReadLine();
        
        Write("Now ponder each of the following questions as they relate to " +
            "this experience.\n");
        Write("You may begin in: ");
        
        ShowCountDown(4);
        
        Clear();
    }
    
    public void DisplayQuestions(Random number)
    {
        Write($"> {GetRandomQuestion(number)} ");
        
        ShowSpinner(5);
        
        WriteLine();
    }
}