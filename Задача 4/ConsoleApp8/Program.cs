using System;
    public class Program
    {
        public const int MIN = 1;
        public const int MAX = 100000;

        public static void Main(string[] args)
        {
            System.Console.Write("Введите число: ");
            int number = GetNumberFromConsole();

            int arraySize = GetCopacityArray(number);

            while (arraySize < 0)
            {
                arraySize = GetNumberFromConsole();
            }

            int[] array = GetArrayFromIntValue(number, new int[arraySize]);

            System.Console.WriteLine($"Оригинальное число: {number}");

            System.Console.WriteLine("Итоговый массив: ");
            System.Console.WriteLine(PrintArray(array));


            // System.Console.WriteLine(PrintArray(array));
        }

        public static int GetNumberFromConsole()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                System.Console.WriteLine("Введеное значение не ядляется числом. Попробуйте снова.");
            }
            return -1;
        }

        public static int[] GetArrayFromIntValue(int number, int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = number % 10;
                number /= 10;
            }
            return array;
        }

        public static int GetCopacityArray(int number)
        {
            int count = 0;
            if (number < MIN) return count;
            while (number > 0)
            {
                count++;
                number = number / 10;
            }
            return count;
        }

        public static string PrintArray(int[] array)
        {
            string result = "[";
            foreach (int item in array)
            {
                result = result + item + " ";
            }
            return result.Trim() + "]";
        }
    }
