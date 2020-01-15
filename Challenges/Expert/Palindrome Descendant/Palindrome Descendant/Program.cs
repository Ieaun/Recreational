using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Descendant
{
    // date: 15.01.202
    //Ieaun ROberts

    /// <summary>
    /// Link : https://edabit.com/challenge/PvCD5nSYy3Dnvnfcq
    /// Title : Palindrome Descendant
    /// 
    /// A number may not be a palindrome, but it's descendant
    /// can be. A number's direct child is created by summing
    /// each pair of adjacent digits to create the digits of 
    /// the next number.
    /// For instance, 123312 is not a palindrome, but it's next 
    /// child 363 is, where: 3 = 1 + 2; 6 = 3 + 3; 3 = 1 + 2.
    /// Create a function that returns true if the number itself 
    /// is a palindrome or any of its descendants down to 2 
    /// digits(a 1-digit number is trivially a palindrome).
    /// 
    /// PalindromeDescendant(11211230) ➞ false
    /// 11211230 ➞ 2333 ➞ 56
    /// palindromeDescendant(13001120) ➞ true
    /// 13001120 ➞ 4022 ➞ 44
    /// PalindromeDescendant(23336014) ➞ true
    /// 23336014 ➞ 5665
    /// PalindromeDescendant(11) ➞ true
    /// Number itself is a palindrome.
    /// 
    /// </summary>
    /// 

    class Program
    {
        static void Main(string[] args)
        {
            bool palen = IsPalendrome(11);
            Console.Write("Is the number or one of its decendants a palindrome : "+palen.ToString());
            Console.ReadLine();
        }

        static bool IsPalendrome(int Number)
        {
            string Values = Number.ToString();
            bool palen = false;
            while (Values.Length > 2 && palen == false)
            {
                palen = IsEqualPalen(Values); //is it already a palindrome
                if (!palen)
                {
                    Values = GetDescendant(Values);
                }  
            }

            if (palen == false && Values.Length == 2)
            {
                palen = IsEqualPalen(Values); //is it a palindrome
            }

            return palen;
        }

        static bool IsEqualPalen(string Values)
        {      
            bool Equal = true;
            for (int i = 0; i < Values.Length && Equal; i++)
            {
                if (i < Values.Length)
                {
                    if (Values[i] != Values[(Values.Length - 1) - i])
                    { Equal = false; }
                }
            }
            return Equal;
        }

        static string GetDescendant(string Values)
        {
            string Decendant = "";
            for (int i = 0; i < Values.Length-1; i+= 2)
            {
                int Value1 = int.Parse(Values[i].ToString());
                int Value2 = int.Parse(Values[i + 1].ToString());

                Decendant += Value1 + Value2;
            }
            return Decendant;
        }

    }
}
