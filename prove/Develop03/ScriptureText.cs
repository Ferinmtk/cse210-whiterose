using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptureText
{
    private List<Word> words;
    private readonly ScriptureReference reference;

    public ScriptureText(ScriptureReference reference, string text)
    {
        this.reference = reference;
        InitializeWords(text);
    }

    private void InitializeWords(string text)
    {
        // Split text into words and initialize Word objects
        var wordList = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        words = wordList.Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Scripture Reference: {reference}");
        Console.WriteLine();

        foreach (var word in words)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
    }

    public bool HideRandomWord()
    {
        var random = new Random();
        var visibleWords = words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count == 0)
        {
            return false; // All words are hidden
        }

        var randomIndex = random.Next(0, visibleWords.Count);
        visibleWords[randomIndex].Hide();
        return true;
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}
