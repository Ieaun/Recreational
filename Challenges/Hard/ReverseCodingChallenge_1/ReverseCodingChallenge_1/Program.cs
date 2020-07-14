using System;
using System.Linq;

namespace ReverseCodingChallenge_1
{
    class Program
    {
        /// <summary>
        /// This is a reverse coding challenge. Normally you're given explicit directions with how to create a function. 
        /// Here, you must generate your own function to satisfy the relationship between the inputs and outputs.
        /// Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
        /// "A4B5C2" ➞ "AAAABBBBBCC"
        /// "C2F1E5" ➞ "CCFEEEEE"
        /// "T4S2V2" ➞ "TTTTSSVV"
        /// "A1B2C3D4" ➞ "ABBCCCDDDD"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string Code = "C2F11E5";

            char Letter = 'Z';
            int Multiple = 0;

            while (true)
            {
                for (int i = 0; i < Code.Count(); i++)
                {
                    try
                    {
                        //check if number 
                        var TempMultiple = (int)Char.GetNumericValue(Code[i]);
                        if (TempMultiple == -1) throw new System.Exception("Not a number");        
                        

                        Multiple = TempMultiple;

                        bool Loop = true;
                        int K = 0;
                        //determine if single digit or multiple digits 
                        while (Loop)
                        {
                            K++;
                            if (i + K < Code.Count())
                            {
                                if (-1 == (int)Char.GetNumericValue(Code[i + K]))
                                {
                                    Loop = false;
                                }
                                else
                                {
                                    Multiple *= 10;
                                }
                            }
                            else { Loop = false; }                                          
                        }



                        for (int j = 0; j < Multiple; j++)
                        {
                            Console.Write(Letter);
                        }
                    }
                    catch (Exception)
                    {
                        Letter = Code[i];
                    }

                }
                Console.WriteLine("press enter to restart");
                Console.ReadLine();
            }
            
        }

       
    }
}
