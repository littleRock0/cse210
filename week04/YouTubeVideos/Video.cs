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
    
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
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
    
    public string FormatLength()
    {
        int hours;
        int minutes;
        int seconds;
        string time = "";
        
        if (_length >= 3600)
        {
            hours = (int)(_length / 3600);
            minutes = (int)((_length % 3600) / 60);
            seconds = (int)(_length % 60);
            
            time = $"{hours}:{minutes}:{seconds} hours";
        }
        else if (_length >= 60)
        {
            minutes = (int)(_length / 60);
            seconds = (int)(_length % 60);
            
            time = $"{minutes}:{seconds} minutes";
        }
        else if (_length < 60)
        {
            seconds = _length;
            
            time = $"{seconds} seconds";
        }
        
        return time;
    }
    
    public string GetDisplayText()
    {
        string comments = "";
        string time = FormatLength();
        
        foreach (Comment comment in _comments)
        {
            comments += comment.GetDisplayText();
        }
        
        return $"{_title} by {_author} Duration({time}) {CommentCount()}" +
        $"\n\n Comments:\n{comments} \n\n";
    }
}