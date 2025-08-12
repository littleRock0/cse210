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
    
    public ReflectingActivity(string name,
        string description) : base(name, description)
    {
        
    }
    
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    
    public void AddQuestion(string question)
    {
        _prompts.Add(question);
    }
    
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        DateTime currentTime = DateTime.Now;
        
        while (currentTime <= futureTime)
        {
            
        }
        
        return;
    }
    
    public string GetRandomPrompt()
    {
        string file = "ReflectingPrompts.txt";
        string[] lines = File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            AddPrompt(line);
        }
        
        Random number = new Random();
        int promptNum = number.Next(0, lines.Length);
        
        string prompt = _prompts[promptNum];
        
        return prompt;
    }
    
    public string GetRandomQuestion()
    {
        string file = "ReflectingQuestions.txt";
        string[] lines = File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            AddQuestion(line);
        }
        
        Random number = new Random();
        int questionNum = number.Next(0, lines.Length);
        
        string question = _questions[questionNum];
        
        return question;
    }
    
    public void DisplayPrompt()
    {
        
    }
    
    public void DisplayQuestions()
    {
        
    }
}