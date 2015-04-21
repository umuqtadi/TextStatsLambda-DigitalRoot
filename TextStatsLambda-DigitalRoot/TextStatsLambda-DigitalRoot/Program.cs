using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot("31337"));
            Console.WriteLine(DigitalRoot("45734"));

            Console.ReadKey();
            
        }

        public static int DigitalRoot(string rootThisNumber)
        {
            //this variable will hold the sum of the numbers after it is looped through the string
            int rootSum = 0;
            //loops 1 by 1 through the characters in the string
            
            
            for (int i = 0; i < rootThisNumber.Length; i++)
            {
                //turns each individual character into a string and then uses parse to turn it into an int then adds them to var rootsum
                
                rootSum += int.Parse(rootThisNumber[i].ToString());

            }

            //takes rootSum and turns it into a string so we can get the sum. Coverts the sum into a string then back into an int and stores it in var input
            int input = rootSum.ToString().Sum(x => int.Parse(x.ToString()));
            
            
            //return the value of input
            return input;
        }

        public static int NumberOfWords(string inputString)
        {
            //splits string by spaces and turns them into a list. Counts the indexes in the list, which turns out to be the number of words
            return inputString.Split(' ').ToList().Count;
        }

        public static int NumberOfVowels(string inputString)
        {
            //making all the letters of input string to lower and then checking if they contain any vowels
            return inputString.ToLower().Count(x => ("aeiou".Contains(x)));
            
        }

        public static int NumberOfConsonants(string inputString)
        {
            //making all the letters of input string tolower and then checking if they contain any consonants
            return inputString.ToLower().Count(x => ("bcdfghjklmnpqrstvwxyz").Contains(x));
        }

        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            return inputString.Count(x => (" .,?;'!@#$%^&*()").Contains(x));
        }

        public static string LongestWord(string inputString)
        {
            //splitting the inputString by the spaces so it gets individual words, then orders from longest to shortest. Then pulls out the first which is the longest
            return inputString.Split(' ').ToList().OrderByDescending(x => x.Length).First();
        }

        public static string ShortestWord(string inputString)
        {
            //spliiting the string by spaces to get words. Order it by shortest to longest and then pulls out the first which is the shortest
            return inputString.Split(' ').ToList().OrderBy(x => x.Length).First();
        }


    }
}
