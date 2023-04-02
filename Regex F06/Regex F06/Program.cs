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
                string pattern = @"\\texttt\{([\p{L}\d]+)\}";
                string result = Regex.Replace(str, pattern, @"\begin{ttfamily}$1\end{ttfamily}");
                Console.WriteLine(result);
                str = Console.ReadLine();
            }
        }
    }
}