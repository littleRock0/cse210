/*******************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
*******************************************************************************/
using System;
using System.Security.Cryptography.X509Certificates; // where did this come from
using static System.Console;

public class Resume
{  
    public string _name;
    public List<Job> _jobs = new List<Job>();
    
    public void Display()
    {
        WriteLine($"Name: {_name}");
        WriteLine("Jobs:");
        
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}