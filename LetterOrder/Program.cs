using System;
using System.IO;
using System.Collections.Generic;

namespace LetterOrder
{
    class Program
    {
        static void Main()
        {
            var file = File.ReadAllLines(@"C:\Users\Myke\source\repos\LetterOrder\words_alpha.txt");
            var list = new List<string>(file);
            
            var wordList = new List<string>();
            var addWord = false;

            foreach (var word in list)
            {
                for (var i = 0; i < word.Length - 1; i++)
                {
                    if (word[i] <= word[i + 1] && word.Length >= 5)
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
                    wordList.Add(word);
                }
            }

            foreach (var word in wordList)
            {
                Console.WriteLine(word + " - " + word.Length);
            }
        }
    }
}