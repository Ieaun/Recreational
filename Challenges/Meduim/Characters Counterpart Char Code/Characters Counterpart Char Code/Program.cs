using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Characters_Counterpart_Char_Code
{
    /// <summary>
    /// Challenge: Meduim
    /// Title: Find the Characters Counterpart Char Code
    /// 
    /// Create a function that takes a single character as an
    /// argument and returns the char code of
    /// its lowercased / uppercased counterpart.
    /// 
    /// Example:
    /// Given that:
    ///  - "A" char code is: 65
    ///  - "a" char code is: 97
    ///
    ///  CounterpartCharCode("A") ➞ 97
    ///
    ///  CounterpartCharCode("a") ➞ 65
    /// 
    /// 
    /// The argument will always be a single character.
    /// Not all inputs will have a counterpart(e.g.numbers),
    /// in which case return the inputs char code.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a char to get its Uppercase Ascii counterpart");
            var GivenChar = Console.Read();
            try
            {
                Console.WriteLine(Ascii_Conversion((char)GivenChar));
            }
            catch
            {
                Console.WriteLine("Cannot convert to Ascii Code");
            }          
        }

        static int Ascii_Conversion(char GivenChar)
        {
            int AsciiRep = 0;
            AsciiRep = GivenChar;
            if (AsciiRep > 90 && AsciiRep <= 122)  //is a lower, turn to upper
            { AsciiRep = GivenChar.ToString().ToUpper()[0]; }
            else
            {
                if (AsciiRep >= 65 && AsciiRep <= 90) //is a upper, turn to lower
                { AsciiRep = GivenChar.ToString().ToLower()[0]; }
            }

            return AsciiRep;
        }
        
    }
}
