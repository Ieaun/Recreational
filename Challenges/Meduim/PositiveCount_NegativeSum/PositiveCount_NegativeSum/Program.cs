using System;
using System.Linq;

namespace PositiveCount_NegativeSum
{
    class Program
    {

        /// <summary>
        /// Create a function that takes an array of positive and negative numbers. 
        /// Return an array where the first element is the count of positive numbers
        /// and the second element is the sum of negative numbers.
        /// 
        /// CountPosSumNeg([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]) ➞ [10, -65]
        /// There are a total of 10 positive numbers.
        /// The sum of all negative numbers equals -65.
        ///CountPosSumNeg([92, 6, 73, -77, 81, -90, 99, 8, -85, 34]) ➞ [7, -252]
        ///CountPosSumNeg([91, -4, 80, -73, -28]) ➞ [2, -105]
        ///CountPosSumNeg([]) ➞ []
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //enter data to test here
            int[] TestArray = new int[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };

            int[] ResultsArray = CountPosSumNeg(TestArray);

            Console.WriteLine(ResultsArray[0].ToString()+ " , "+ ResultsArray[1].ToString());


          
        }

        private static int[]  CountPosSumNeg(int[] testArray)
        {
            if (testArray.Count() != 0)
            {
                int[] ResultsArray = new int[2] { 0, 0 };
                foreach (var item in testArray)
                {
                    if (item > 0)
                    {
                        ResultsArray[0] += 1;
                    }
                    else
                    {
                        ResultsArray[1] += item;
                    }
                }
                return ResultsArray;
            }
            return testArray;
        }
    }
}
