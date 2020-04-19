﻿using System;

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
            T newAE = array[array.Length-1];
            Array.Resize(ref array,array.Length-1);
            return newAE;
        }
        public static int Push<T> (ref T[] array, T newAE)
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1] = newAE;
            return array.Length;
        }
         public static T Shift<T> (ref T[] array)
        {
            T newAE = array[0];
            Array.Reverse(array);
            Array.Resize(ref array, array.Length-1);
            Array.Reverse(array);
            return newAE;
        }
        public static int UnShift<T>(ref T[] array, T newAE)
        {
            Array.Reverse(array);
            Array.Resize(ref array,array.Length+1);
            Array.Reverse(array);
            array[0] = newAE;
            return array.Length;
        }
    }
}
