using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Zero_and_One_to_1_and_0
{
    //15.01.2020
    //Ieaun ROberts


    /// <summary>
    /// Level: Hard 
    /// Title: Convert "Zero" and "One" to "1" and "0"
    /// Link: https://edabit.com/challenge/yrL3zkSECbde2Dc8i
    /// 
    /// Create a function that takes a string as an argument.
    /// The function must return a string containing 1s and 0s
    /// based on the string argument's words. If any word in the 
    /// argument is not equal to "zero" or "one" (case insensitive),
    /// you should ignore it. The returned string's length 
    /// should be a multiple of 8, if the string is not a multiple
    /// of 8 you should remove the numbers in excess.
    ///
    /// examples
    /// TextToNumberBinary("zero one zero one zero one zero one") ➞ "01010101"
    /// TextToNumberBinary("Zero one zero ONE zero one zero one") ➞ "01010101"
    /// TextToNumberBinary("zero one zero one zero one zero one one two") ➞ "01010101"
    /// TextToNumberBinary("zero one zero one zero one zero three") ➞ ""
    /// TextToNumberBinary("one one") ➞ "
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word representation of a binary sequence to get its number rep");
            string StringRep = Console.ReadLine();
            try
            {
                Console.WriteLine("'"+TextToNumberBinary(StringRep)+"'");
            }
            catch
            {
                Console.WriteLine("Conversion failed");
            }   
        }

        static string TextToNumberBinary(string StringRep)
        {
            string BinaryNumericalVersion = null;
            int invalidpos = 0;
            int counter = 0;

            string[] Values = StringRep.Split();
            foreach (string Value in Values)
            {
                if (Value.ToUpper() == "ONE")
                { BinaryNumericalVersion += "1"; }
                else
                {
                    if (Value.ToUpper() == "ZERO")
                    { BinaryNumericalVersion += "0"; }
                    else
                    {                      
                        invalidpos = counter;
                    }
                }
                counter++;
            }

            if (invalidpos < 7 && invalidpos!= 0) // contains illegal value and cannot create a full sequence
            {
                BinaryNumericalVersion = "";
            }
            else
            {
                BinaryNumericalVersion = CheckLength(BinaryNumericalVersion); // truncate if too many values
            }
            return BinaryNumericalVersion;
        }


        // truncate if too many values
        static string CheckLength(string BinaryNumericalVersion)
        {
            int Leng = BinaryNumericalVersion.Length;
            int NoSequences = Leng / 8;
            int x = 0;
            if (NoSequences > 0)
            {
                for (int J = 1; J <= NoSequences; J++)
                {
                    string tempholder = BinaryNumericalVersion;
                    BinaryNumericalVersion = "";
                    for (int i = 0; i < 8; i++)
                    {
                        BinaryNumericalVersion += tempholder[i + x];
                    }
                    x += 8;
                }
            }
            else
            {
                BinaryNumericalVersion = "";
            }

            return BinaryNumericalVersion;
        }

    }
}
