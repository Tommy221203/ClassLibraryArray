using ClassLibraryArray;
using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quanti valori ha l'array?");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"array[{i}]={v}");
            }
        }
    }
}
