/*******************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
*******************************************************************************/
using System;
using static System.Console;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
    public void Display()
    {
        WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}