using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CustomPrinter.QuoteIt("ho ho ho","santa"));
            
            Console.WriteLine("vowels count: " + CustomPrinter.CountVowels("ho ho ho ha hu"));
            
            Console.WriteLine(CustomPrinter.UpperLower("loremipsumdolor"));
            
            Console.WriteLine("concatenation 10000: "+CustomPrinter.StringBuildTest(10000,CustomPrinter.StringBuildingType.Concatenation));
            Console.WriteLine("string builder 10000: "+CustomPrinter.StringBuildTest(10000,CustomPrinter.StringBuildingType.StringBuilder));
            
            Console.ReadLine();
        }
    }
}
