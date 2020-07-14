using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram_String_in_Another_String
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter 2 strings to see if an anagram of the first string is contained within the second string");
                string Word1 = "bag";
                string Word2 = "grab";

                bool Result = AnagramStrStr(Word1, Word2);
                Console.WriteLine(Result);

                Console.Read();
            }
       
        }

        private static bool AnagramStrStr(string word1, string word2)
        {
            string TempWord1 = word1;
            int SequenceLength = 0;


            for (int i = 0; i < word2.Length ; i++)
            {
                if (TempWord1.Contains(word2[i]))
                {
                    SequenceLength++;
                    //remove the letter
                    TempWord1.Remove(TempWord1.IndexOf(word2[i]));

                    //check if done
                    if (SequenceLength == word1.Count())
                    {
                        return true;
                    }
                }
                else 
                {
                    SequenceLength = 0;
                }
            }       
            return false;
        }

    }
}
