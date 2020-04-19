using System;

namespace _1604
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {87, 76, 65, 54, 43};
        }
        static void ArrayAtAll <T> (T[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
    static class ArrayHelder
    {
        public static T Pop<T>(ref T[] array)
        {
            T newA = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return newA;
        }
        public static int Push<T> (ref T[] array, T newA)
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1] = newA;
            return array.Length;
        }
    }
}
