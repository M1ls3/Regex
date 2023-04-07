using System;
namespace Regex
{
    class Program
    {
        static String searchPatt = "a+b+b+c+"; 
        static String replacePatt = "QQQ"; 
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            while (str != null)
            {
                String newStr = System.Text.RegularExpressions.Regex.Replace(str, searchPatt, replacePatt);
                Console.WriteLine(newStr);
                str = Console.ReadLine();
            }
        }
    }
}