using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();
        string[] wordArray = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
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
        string renderedText = _text;
        foreach (Word word in _words)
        {
            if (word.IsHidden)
        {
            string underscore = new string('_', word.Text.Length);
            renderedText = renderedText.Replace(word.Text, underscore);
        }
        }
        return renderedText;
    }

    public string GetText()
    {
        return _text;
    }
}