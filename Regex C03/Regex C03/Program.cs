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
                Regex pattern = new Regex(@"\$v_([\w\d])\$"); 
                string result = pattern.Replace(str, "v[$1]"); 
                Console.WriteLine(result); 
                str = Console.ReadLine();
            }
        }
    }
}