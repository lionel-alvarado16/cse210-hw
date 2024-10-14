using System;
using System.Collections.Generic;

public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comments> _comments = new List<Comments>();

    public Video(string title, string author, int length, List<Comments> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    
    public int commentsNumber()
    {
        int number =_comments.Count;
        
        return number;
    }

    public void DisplayVideo()
    {
        int commentsNum = commentsNumber();

        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length}s | Number of comments: {commentsNum}");
        Console.WriteLine("Comments: ");

        foreach (Comments comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
    }
}