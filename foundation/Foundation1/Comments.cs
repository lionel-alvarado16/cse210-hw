using System;

public class Comments
{
    string _name;
    string _text;

    public Comments(string name, string text)
    {
        _name = name;
        _text = text;
    }
    
    public string DisplayComment()
    {
        string comment = $"- {_name} // {_text}";
        
        return comment;
    }
}