using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RegExLab_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while (str != null)
            { 
                Regex patterns = new Regex(@"\\circle\{\((\d+),(\d+)\)");
                string result = patterns.Replace(str, "\\circle{($2,$1)");
                Console.WriteLine(result);
                str = Console.ReadLine();
            }
        }
    }
}