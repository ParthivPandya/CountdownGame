using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "words.txt"; // Path to your .txt file
            string[] words = LoadWordsFromFile(filePath);

            if (words.Length == 0)
            {
                Console.WriteLine("No words loaded from the file.");
                return;
            }

            Dictionary dictionary = new Dictionary(words);
            CountdownGamePlay game = new CountdownGamePlay(dictionary);
            game.PlayGame();
            Console.ReadKey();
        }

        static string[] LoadWordsFromFile(string filePath)
        {
            try
            {
                return File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return new string[0];
            }
        }
    }
}
