/*
 * Appendix 3 - Exercise 1: Alphabetize a File
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_Assessment_Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deserialise words.txt and add to new list
            List<string> words = DeserialiseWords("./words.txt");

            //print current words list
            Console.WriteLine("READ INITIAL WORDS LIST");
            foreach (string w in words)
            {
                Console.WriteLine(w);
            }


            //sort words in alpha order
            words.Sort();

            //add line break and print final words list
            Console.WriteLine(" ");
            Console.WriteLine("FINAL WORDS LIST");
            foreach (string w in words)
            {
                Console.WriteLine(w);
            }

            //Write new text file with final words list
            Serialise("./output.txt", words);
        }

        static void Serialise(string filename, List<string> words)
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                for (int i = 0; i < words.Count; i++)
                {
                    sw.WriteLine(words[i]);
                }
            }
        }

        static string DeserialiseNumberOfWords(string filename)
        {
            string number;
            
            using (StreamReader sr = File.OpenText(filename))
            {
                number = sr.ReadLine();
            }

            return number;
        }

        static List<string> DeserialiseWords(string filename)
        {
            List<string> words = new List<string>();

            using (StreamReader sr = File.OpenText(filename))
            {
                string word;

                string expectedNumberOfWords = sr.ReadLine();

                while ((word = sr.ReadLine()) != null)
                {
                    words.Add(word);
                }
            }

            return words;
        }
    }
}
