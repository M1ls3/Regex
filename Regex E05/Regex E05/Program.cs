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
                Regex singleCharPattern = new Regex(@"\$v_([a-zA-Z0-9])\$|\$v_{([a-zA-Z0-9]*)}\$");
                string result = singleCharPattern.Replace(str, "v[$1$2]");
                Console.WriteLine(result); 
                str = Console.ReadLine();
            }
        }
    }
}