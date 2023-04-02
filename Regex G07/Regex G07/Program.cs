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
                Regex patterns = new Regex(@"\b[A-Z][a-zA-Z]*\b(\s+[A-Z][a-zA-Z]*){2,}");
                string result = patterns.Replace(str, "\"$&\"");
                Console.WriteLine(result);
                str = Console.ReadLine();
            }
        }
    }
}