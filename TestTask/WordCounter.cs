using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTask
{
    public class WordCounter
    {
        const string vowels = "aeyouiAEYOUI";
        public int CountWordWithOnlyVowels(string input)
        {
            if(input == null)
            {
                throw new ArgumentNullException();
            }
            int count = 0;
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.All(x => vowels.Contains(x)))
                    count++;
            }
            return count;
        }
    }
}
