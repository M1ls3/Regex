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
                string pattern = @"\\texttt\{([a-zA-Z]+)\}|\\texttt\{([0-9]+)\}|\\texttt\{(\s)\}";
                string result = Regex.Replace(str, pattern, @"\begin{ttfamily}$1$2$3\end{ttfamily}");
                Console.WriteLine(result);
                str = Console.ReadLine();
            }
        }
    }
}