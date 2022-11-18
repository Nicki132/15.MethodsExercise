using System;
using System.Linq;

namespace P02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read single string from Console
            string word = Console.ReadLine();

            //TODO: Creates method which return vowels count
            int vowelsCount = GetVowelsCount(word);

            //Print vowels count
            Console.WriteLine(vowelsCount);
        }

        static int GetVowelsCount(string word)
        {
            //Creates array with all vowels characters
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int vowelsCount = 0;
            foreach (char ch in word.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    //Current character is a vowel
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
