/*******************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
*******************************************************************************/
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume = new Resume();
        
        job1._jobTitle = "Software Developer";
        job1._company = "Healthy Bites Brigade";
        job1._startYear = 2023;
        job1._endYear = 2026;
        
        job2._company = "Elwood Staffing";
        job2._jobTitle = "Associate";
        job2._startYear = 2017;
        job2._endYear = 2027;
        
        resume._name = "Isaac Rochelle";
        
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.Display();
    }
}