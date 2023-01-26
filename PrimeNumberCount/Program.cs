using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;
        if (num == 2 || num == 3)
            return true;
        if (num % 2 == 0 || num % 3 == 0)
            return false;
        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }
        return true; 
    }

    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]), n = int.Parse(input[1]);
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                if (IsPrime(i))
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
