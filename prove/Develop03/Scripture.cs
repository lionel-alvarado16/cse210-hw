using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split();

        foreach (string word in parts)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {        
        Random hideWords = new Random();
    
        for (int i = 0; i < numberToHide; i++)
        {
            int index = hideWords.Next(_words.Count);

            while (_words[index].IsHidden() == true)
            {
                index = hideWords.Next(_words.Count);
            }

            _words[index].Hide();

            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        Console.Clear();
        string scrip = "";
        
        foreach (Word word in _words)
        {
            scrip += word.GetDisplayText() + " ";
        }
        
        string scripture = $"{_reference.GetDisplayText()} {scrip}";
        
        return scripture;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        
        return true;
    }
}