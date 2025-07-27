/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Video
{
    private List<Comment> _comments = new List<Comment>();
    private string _title;
    private string _author;
    private int _length;
    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        
        
    }
    
    public int CommentCount()
    {
        int count = 0;
        
        foreach (Comment comment in _comments)
        {
            count++;
        }
        
        return count;
    }
    
    public string GetDisplayText()
    {
        return "";
    }
}