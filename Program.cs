using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 22, 44, 33, 55, 77, 12, 3, 7 };
            InsertionSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void InsertionSort(int[] array)
        {   
            for (int i = 1; i < array?.Length; i++)
            {
                int currentIndex = array[i];
                int previousIndex = i - 1;

                while (previousIndex >= 0 && array[previousIndex] > currentIndex)
                {
                    array[previousIndex + 1] = array[previousIndex];
                    previousIndex--;
                }
                array[previousIndex + 1] = currentIndex;
            }
        }
    }
}
