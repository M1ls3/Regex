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
                Regex pattern = new Regex(@"([a-z])([A-Z])");
                string result = pattern.Replace(str, "_?_$1$2_?_");
                Console.WriteLine(result);
                str = Console.ReadLine();
            }
        }
    }
}