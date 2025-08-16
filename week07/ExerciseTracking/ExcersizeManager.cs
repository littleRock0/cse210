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
        Write("");
    }
}