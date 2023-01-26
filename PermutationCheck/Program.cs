using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] firstArray = new int[11];
        int[] secondArray = new int[11];

        // Reading input arrays
        for (int i = 0; i < 11; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 11; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine()); 
        }

        // Sorting the arrays
        Array.Sort(firstArray);
        Array.Sort(secondArray);

        // Checking for permutation
        if (firstArray.SequenceEqual(secondArray))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
