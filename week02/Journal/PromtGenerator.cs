/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {
        return "pass";
    }
}