using System;
public class Program
{
    static void Main()
    {
        double[] CreateArrarRndDouble(int size, int min, int max)
        {
            double[] arr = new double[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.NextDouble() * (max - min) + min;
            }

            return arr;
        }


        void PrintArrayDouble(double[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1) Console.Write($"{arr[i]:F1} | ");
                else Console.Write($"{arr[i]:F1}");
            }
            Console.Write("]");
        }

        double MaxElementDoubleArr(double[] arr)
        {

            double max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];

                }
            }
            return max;
        }

        double MinElementDoubleArr(double[] arr)
        {

            double min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];

                }
            }
            return min;
        }

        double DoubleArrDiferents(double num1, double num2)
        {
            return num1 - num2;
        }


        double[] array = CreateArrarRndDouble(5, 0, 100);
        PrintArrayDouble(array);
        Console.Write(" => ");
        double maxDoubleArr = MaxElementDoubleArr(array);
        double minDoubleArr = MinElementDoubleArr(array);

        Console.Write($"{maxDoubleArr:F1} - {minDoubleArr:F1} = {DoubleArrDiferents(maxDoubleArr, minDoubleArr):F1}");
    }
}