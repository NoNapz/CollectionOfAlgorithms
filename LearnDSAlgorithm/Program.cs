
using CSharpAlgorithms.Algos;

namespace LearnDSAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start of search algorithms

            SearchAlgos searchAlgos = new SearchAlgos();
            
            int[] A = { 84, 21, 47, 96, 15 };
            int linearFound = searchAlgos.LinearSearch(A, A.Length, 96);
            Console.WriteLine($"Result found at index : {linearFound} (Linear Search)");

            int[] B = { 2, 5, 6, 14, 82, 96 };
            int binaryFound = searchAlgos.BinarySearch(B, B.Length, 82);
            Console.WriteLine($"Result found at index : {binaryFound} (Binary Search)");

            int[] C = { 0, 2, 4, 6, 8, 10, 14, 15, 17, 20, 22, 25 };
            int binaryRecursiveFound = searchAlgos.BinaryRecSearch(C, 15, 0, C.Length);
            Console.WriteLine($"Result found at index : {binaryRecursiveFound} (Binary Rec Search)");

            /**
             * End of search Algorithms
             * ~~~~~~~~~~~~~~~~~~~~~~~~
             * Start of sort Algortihms
            **/

            SortAlgos sortAlgos = new SortAlgos();

            int[] D = { 5, 2, 10, 20, 35, 14, 7, 28 };
            sortAlgos.Display("Displaying Array -- Unsorted", D);

            int[] sortedSelectionSortArray = sortAlgos.SelectionSort(D);
            sortAlgos.Display("Displaying Sorted Selection Array", sortedSelectionSortArray);

            // End of sort algorithms

            Console.ReadKey();
        }
    }
}