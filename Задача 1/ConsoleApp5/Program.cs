using System;
class Program
{
    static void Main()
    {
        int[] CreateArrRndInt(int size, int min, int max)
        {
            int[] arr = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(min, max + 1);
            }

            return arr;
        }

        void PrintOut(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write($"{arr[^1]}");
        }

        int CountOfNumbersInRange(int[] arr, int min, int max)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= min && arr[i] <= max) count++;
            }
            return count;
        }

        int[] randArr = CreateArrRndInt(100, -100, 100);
        PrintOut(randArr);
        int result = CountOfNumbersInRange(randArr, 20, 99);
        Console.WriteLine($" -> {result}");
    }
 }
