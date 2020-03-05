using System;
using System.IO;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = Console.ReadLine();
            try 
            { 
                using (StreamReader sr = File.OpenText(fileName))
                {
                    WordCounter counter = new WordCounter();
                    string inputText = String.Empty;
                    int count = 0;
                    while ((inputText = sr.ReadLine()) != null)
                    {
                       count +=  counter.CountWordWithOnlyVowels(inputText);
                    }
                    Console.WriteLine(count);
                } 
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine($"Could not find file with name {fileName}");
            } 
        }
    }
}
