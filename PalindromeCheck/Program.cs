using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string cleanedString = Regex.Replace(input, "[^a-zA-Z]", "").ToLower();
        bool isPalindrome = cleanedString.SequenceEqual(cleanedString.Reverse());
        Console.WriteLine(isPalindrome ? "YES" : "NO");
    }
}
 