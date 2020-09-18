using System;

namespace Repeating_Elements
{
    class Program
    {

        public static void Main()
        {
            int[] arr = { 4, 2, 4, 5, 2, 3, 1 };
            
            int[] count = new int[arr.Length];
            int i;

            Console.Write("Repeated elements are: ");
            for (i = 0; i < arr.Length; i++)
            {
                if (count[arr[i]] == 1)
                    Console.Write(arr[i] + " ");
                else
                    count[arr[i]]++;
            }
            Console.ReadKey();
        }

    }
}
