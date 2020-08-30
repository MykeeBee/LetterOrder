using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LetterOrder
{
    class Program
    {
        static void Main()
        {
            var wordListFile = File.ReadAllLines(@"C:\Users\Myke\source\repos\LetterOrder\words_alpha.txt");
            var currentWordList = new List<string>(wordListFile);
            
            var newWordList = new List<string>();
            var addWord = false;
            var minimumWordLength = 5;

            foreach (var word in currentWordList.Where(word => word.Length >= minimumWordLength))
            {
                for (var i = 0; i < word.Length - 1; i++)
                {
                    if (word[i] <= word[i + 1])
                    {
                        addWord = true;
                    }

                    else
                    {
                        addWord = false;
                        break;
                    }
                }

                if (addWord)
                {
                    newWordList.Add(word);
                }
            }

            foreach (var word in newWordList)
            {
                Console.WriteLine(word + " - " + word.Length);
            }
        }
    }
}