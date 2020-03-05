using System;
using TestTask;
using Xunit;

namespace WordCounterTest
{
    public class CounterTest
    {
        [Fact]
        public void StringWithOneWordOnlyWithVowels_CountWord_ReturnOne()
        {
            // Arrange
            string insertString = "Lisa like you";
            WordCounter counter = new WordCounter();
            // Act
            int count = counter.CountWordWithOnlyVowels(insertString);
            // Assert
            Assert.Equal(1, count);
        }
        [Fact]
        public void StringWithoutWordOnlyWithVowels_CountWord_ReturnZero()
        {
            // Arrange
            string insertString = "Mama loves her children";
            WordCounter counter = new WordCounter();
            // Act
            int count = counter.CountWordWithOnlyVowels(insertString);
            // Assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void EmptyString_TryToCount_ThrowArgumentNullException()
        {
            string insertString = null;
            WordCounter counter = new WordCounter();
            Assert.Throws<ArgumentNullException>(() => counter.CountWordWithOnlyVowels(insertString));
        }
    }
}
