using System;

namespace Binary_Search_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int BinarySearch(int[] array, int value)
        {
            int low = 0;
            int high = array.Length;

            while (low < high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == value)
                    return mid;
                if (array[mid] < value)
                    low = mid + 1;
                if (array[mid] > value)
                    high = mid;

            }
            return -1;

        }

        public static int RecursiveBinarySearch(int[] array, int value)
        {
            return internalRecursiveBinarySearch(0, array.Length);
            int internalRecursiveBinarySearch(int low, int high)
            {
                if (low >= high)
                    return -1;

                int mid = (high + low) / 2;
                if (array[mid] == value)
                    return mid;
                if (array[mid] < value)
                  return   internalRecursiveBinarySearch(mid + 1, high);
                return internalRecursiveBinarySearch(low, mid);

            }

        }
    }

}
