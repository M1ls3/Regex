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
                Regex singleCharPattern = new Regex(@"\$v_([\w\d])\$");
                Regex multiCharPattern = new Regex(@"\$v_\{([\d\w]+)\}\$");
                string result = multiCharPattern.Replace(singleCharPattern.Replace(str, "v[$1]"), "v[$1]"); 
                Console.WriteLine(result); 
                str = Console.ReadLine();
            }
        }
    }
}