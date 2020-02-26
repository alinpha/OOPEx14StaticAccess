using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public static class CustomPrinter
    {
        public static string QuoteIt(string toQuote, string author) 
        {
            return $"\"{toQuote}\" - {author}";
        }

        public static int CountVowels(string phrase)
        {
            char[] vowels = {'a','e','u','i','o'};
            char[] charArr = phrase.ToLower().ToCharArray();

            int vowelsFound = 0;

            foreach(char v in vowels)
            {
                vowelsFound += charArr.Where(ch => ch == v).Count();
            }

            return vowelsFound;
        }

        public static string UpperLower(string phrase)
        {

            string ulPhrase = "";

            for (int i=0; i<phrase.Length; i++)
            {
                string s = phrase.Substring(i, 1);
                ulPhrase += i % 2 == 0 ? s.ToUpper() : s.ToLower();

            }

            return ulPhrase;

            //other solution with string builder
            //string concatenation is more expensive than sb
            StringBuilder sb = new StringBuilder(phrase);

            for (int i = 0; i < phrase.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb[i] = Char.ToUpper(sb[i]);
                }
                else
                {
                    sb[i] = Char.ToLower(sb[i]);
                }
            }

            return sb.ToString();
        }

        public enum StringBuildingType
        {
            Concatenation,
            StringBuilder
        }

        /// <summary>
        /// returns the time milliseconds spent on proccessing string creation
        /// </summary>
        /// <param name="countTo">the last munber to contatenate</param>
        /// <param name="type">type of string creation</param>
        /// <returns>time spent in milliseconds</returns>
        public static long StringBuildTest(long countTo, StringBuildingType type)
        {
            long millis = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (type == StringBuildingType.StringBuilder)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i< countTo; i++)
                {
                    sb.Append(i.ToString());
                }
            }
            else
            {
                string str = "";
                for (int i = 0; i < countTo; i++)
                {
                    str += i.ToString();
                }
            }

            sw.Stop();
            millis = sw.ElapsedMilliseconds;

            return millis;
        }
    }
}
