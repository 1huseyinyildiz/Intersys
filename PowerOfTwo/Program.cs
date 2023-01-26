using System;
using System.Collections.Generic;

class Program
{ 
    static void Main(string[] args)
    {
        var inputList = new List<uint>();
        var powerOfTwoSet = new HashSet<uint>();

        while (true)
        {
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;
            inputList.Add(uint.Parse(input));
        } 

        // Decomposing the integers in the list into powers of 2
        foreach (var num in inputList)
        {
            var temp = num;
            for (uint i = 0; i < 32; i++)
            {
                if ((temp & 1) == 1)
                    powerOfTwoSet.Add((uint)Math.Pow(2, i));
                temp >>= 1;
            }
        }

        // Sorting the set and printing the output
        var sortedSet = new SortedSet<uint>(powerOfTwoSet);
        if (sortedSet.Count == 0)
            Console.WriteLine("NA");
        else
            Console.WriteLine(string.Join(", ", sortedSet));
    }
}
