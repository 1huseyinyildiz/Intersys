class ReverseArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        // Reading input array
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(input[i]);
        }
 
        // Reversing the array
        Array.Reverse(arr);

        // Printing the reversed array
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
