using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = ExtractWords(text);
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public string GetText()
    {
        return _text;
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, 6);
        for (int i = 0; i < wordsToHide; i++)
        {
            int wordIndex = random.Next(_words.Count);
            _words[wordIndex].Hide();
        }
    }


    public string GetRenderedDisplay()
    {
        StringBuilder display = new StringBuilder();
        foreach (Word word in _words)
        {
            display.Append(word.IsHidden ? new string('_', word.Text.Length) : word.Text);
            display.Append(" ");
        }
        return display.ToString().Trim();
    }

    private List<Word> ExtractWords(string text)
    {
        List<Word> words = new List<Word>();
        string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }
        return words;
    }
}

