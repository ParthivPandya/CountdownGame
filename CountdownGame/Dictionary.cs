using System;
using System.Collections.Generic;
using System.Linq;

public class Dictionary
{
    private HashSet<string> _wordSet;

    public Dictionary(string[] words)
    {
        _wordSet = new HashSet<string>(words, StringComparer.OrdinalIgnoreCase);
    }

    public bool IsValidWord(string word)
    {
        return _wordSet.Contains(word);
    }

    public string GetLongestWord(string letters)
    {
        Console.WriteLine($"Available letters: {letters}");
        var letterCounts = letters.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        string longestWord = _wordSet
            .Where(word => CanFormWord(word, letterCounts))
            .OrderByDescending(word => word.Length)
            .FirstOrDefault();

        if (longestWord == null)
        {
            Console.WriteLine("No valid word found.");
        }
        else
        {
            Console.WriteLine($"Longest valid word found: {longestWord}");
        }

        return longestWord;
    }

    private bool CanFormWord(string word, Dictionary<char, int> letterCounts)
    {
        var tempLetterCounts = new Dictionary<char, int>(letterCounts);

        foreach (var c in word)
        {
            char upperC = char.ToUpper(c); // Ensure case insensitivity
            if (!tempLetterCounts.ContainsKey(upperC) || tempLetterCounts[upperC] == 0)
            {
                return false;
            }

            tempLetterCounts[upperC]--;
        }

        return true;
    }
}
