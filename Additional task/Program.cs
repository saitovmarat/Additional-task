using System;

namespace Additional_task
{
    class Program
    {
        public static void printArray(int[] arr)
        {
            foreach(int number in arr)
            {
                Console.Write($"{number} ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1 Task");
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int k = 7;
            Console.Write("[ ");
            printArray(arr);
            Console.Write("]");
            Console.Write($", k = {k} -> ");

            for (int i = 0; i < arr.Length; i++)
            {
                int low = 0;
                int high = arr.Length - 1;
                int middleNum = 0;
                int numToFind = k - arr[i];
                int currentLength = arr.Length;
                while (currentLength > 0)
                {
                    middleNum = arr[currentLength / 2];
                    if (middleNum == numToFind)
                    {
                        Console.Write($"[{arr[i]}, {middleNum}]");
                        return;
                    }
                    if (numToFind < middleNum)
                    {
                        high -= currentLength / 2;
                    }
                    else if (numToFind > middleNum)
                    {
                        low += currentLength / 2;
                    }
                    currentLength /= 2;
                }

            }
        }
    }
}
