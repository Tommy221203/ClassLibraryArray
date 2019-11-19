using System;

namespace ClassLibraryArray
{
    public class ClassArray
    {
        public static void LeggiArray(int[]array)
        {
            Console.WriteLine("inserisci i valori dell'array");
            for(int i=0;i<array.Length;i++)
            {
                int n = int.Parse(Console.ReadLine());
                array[i] = n;
            }
        }
        public static void StampaArray(int[] array)
        {
            for(int i=0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]={array}");
            }
        }
        public static int[] CopiaArray(int[] array)
        {
            int[] nuovoarray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                nuovoarray[i] = array[i];
            return nuovoarray;
        }
        public static bool RicercaArray(int[] array, int elemento)
        {
            for (int i=0;i<array.Length;i++)
            {
                if (elemento == array[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SonoUguali(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;
            for(int i=0; i<a.Length;i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
        public static int CercaMax(int[] array)
        {
            int max = 0;
            for(int i=0; i<array.Length;i++)
            {
                if (array[i] > array[i + 1])
                {
                    max = array[i];
                }
                else
                    max = array[i + 1];
            }
            return max;
        }
        public static int CercaMin(int[] array)
        {
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[i + 1])
                {
                    min = array[i];
                }
                else
                    min = array[i + 1];
            }
            return min;
        }
       public static bool Crescente(int[] array)
        {
            for(int i=1; i<array.Length;i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }
            return true;
        }
        public static bool Decrescente(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                    return false;
            }
            return true;
        }
    }
}