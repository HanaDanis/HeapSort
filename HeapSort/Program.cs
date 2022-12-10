using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Sort ob = new Sort();
            ob.sort(arr);
            Console.WriteLine("Sorted array is");
            Console.WriteLine(String.Join(" ", arr));

            //Explanation:
            //Convert from array to list = o(n)
            //Heap sort = o(log(n))
            //Total = o((n)log(n))
        }
    }
}
