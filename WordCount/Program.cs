using System.Collections.Generic;
using System;
using System.IO;
using System.Net;

namespace WordCount {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter your txt file path!");
            string filepath = Console.ReadLine();
            string document;
            if (filepath == "default")
            {
                document = File.ReadAllText("C:/Users/heroh/Desktop/draft2.txt");
            }
            else
            {
                document = File.ReadAllText(filepath);
            }
            string[] docdataraw = document.Split(' ');
            Dictionary<string, int> wordcounts = new Dictionary<string,int>();
            for (int i = 0; i < docdataraw.Length; i++)
            {
                    if (!wordcounts.ContainsKey(docdataraw[i]))
                    {
                        wordcounts.Add(docdataraw[i], 1);
                    }
                    else
                    {
                        wordcounts[docdataraw[i]] = wordcounts[docdataraw[i]] + 1;
                    }
            }

            Console.WriteLine("Here are some words to consider changing.");
            foreach (var word in wordcounts)
            {
                if (word.Value > 1)
                {
                    Console.WriteLine(word.Key + ": " + word.Value);
                }
            }

            Console.ReadKey();
        }
    }
}