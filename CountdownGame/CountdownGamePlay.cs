using CountdownGame;
using System;
using System.Collections.Generic;
using System.Linq;

public class CountdownGamePlay
{
    private readonly LetterBag _letterBag;
    private readonly Dictionary _dictionary;
    private int _totalScore;
    private int _currentRound;

    public CountdownGamePlay(Dictionary dictionary)
    {
        _letterBag = new LetterBag();
        _dictionary = dictionary;
        _totalScore = 0;
        _currentRound = 0;
    }

    public void PlayRound()
    {
        _currentRound++;
        Console.WriteLine($"Round {_currentRound}");

        List<char> letters = new List<char>();
        for (int i = 0; i < 9; i++)
        {
            Console.Write("Choose 'C' for Consonant or 'V' for Vowel: ");
            char choice = Console.ReadLine().ToUpper()[0];
            if (choice == 'C')
            {
                letters.Add(_letterBag.GetRandomConsonant());
            }
            else if (choice == 'V')
            {
                letters.Add(_letterBag.GetRandomVowel());
            }
            Console.WriteLine($"Chosen Letters: {string.Join(" ", letters)}");
        }

        string longestWord = _dictionary.GetLongestWord(new string(letters.ToArray()));
        if (longestWord == null)
        {
            Console.WriteLine("No valid word could be formed from the chosen letters.");
            return;
        }

        int roundScore = longestWord.Length;
        _totalScore += roundScore;

        Console.WriteLine($"Longest Word: {longestWord} ({roundScore} points)");
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public void PlayGame()
    {
        for (int i = 0; i < 4; i++)
        {
            PlayRound();
        }
        Console.WriteLine($"Game Over! Final Score: {_totalScore}");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(); // Wait for the user to press a key before closing the console
    }
}
