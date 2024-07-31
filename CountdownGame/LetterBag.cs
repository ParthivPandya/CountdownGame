using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownGame
{
    public class LetterBag
    {
        private static readonly Random _random = new Random();
        private const string Vowels = "AEIOU";
        private const string Consonants = "BCDFGHJKLMNPQRSTVWXYZ";

        public char GetRandomVowel()
        {
            return Vowels[_random.Next(Vowels.Length)];
        }

        public char GetRandomConsonant()
        {
            return Consonants[_random.Next(Consonants.Length)];
        }
    }
}
