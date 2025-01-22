using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        var revealedWords = new List<Word>();

        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                revealedWords.Add(word);
            }
        }

        var random = new Random();
        var wordsToHide = new List<Word>();

       
    }
}