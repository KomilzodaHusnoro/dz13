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

}
