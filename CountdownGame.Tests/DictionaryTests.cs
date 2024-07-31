using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CountdownGame.Tests
{
    public class DictionaryTests
    {
        [Fact]
        public void IsValidWord_ShouldReturnTrue_ForValidWord()
        {
            // Arrange
            string[] words = { "example", "words", "dictionary" };
            Dictionary dictionary = new Dictionary(words);

            // Act
            bool result = dictionary.IsValidWord("example");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidWord_ShouldReturnFalse_ForInvalidWord()
        {
            // Arrange
            string[] words = { "example", "words", "dictionary" };
            Dictionary dictionary = new Dictionary(words);

            // Act
            bool result = dictionary.IsValidWord("invalid");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetLongestWord_ShouldReturnLongestWord()
        {
            // Arrange
            string[] words = { "example", "words", "dictionary", "word" };
            Dictionary dictionary = new Dictionary(words);
            string letters = "EXAMPLEDICTIONARY";

            // Act
            string longestWord = dictionary.GetLongestWord(letters);

            // Assert
            Assert.Equal("dictionary", longestWord, ignoreCase: true);
        }

        [Fact]
        public void GetLongestWord_ShouldReturnNull_WhenNoValidWord()
        {
            // Arrange
            string[] words = { "example", "words" };
            Dictionary dictionary = new Dictionary(words);
            string letters = "XYZ";

            // Act
            string longestWord = dictionary.GetLongestWord(letters);

            // Assert
            Assert.Null(longestWord);
        }
    }
}
