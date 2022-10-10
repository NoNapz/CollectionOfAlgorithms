
using CSharpAlgorithms.Algos;

namespace LearnDSAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            // Several Array declarations

            DisplayArrays displayArrays = new DisplayArrays();

            int[] A = { 84, 21, 47, 96, 15 };
            int[] B = { 2, 5, 6, 14, 82, 96 };
            int[] C = { 0, 2, 4, 6, 8, 10, 14, 15, 17, 20, 22, 25 };
            int[] D = { 5, 2, 10, 20, 35, 14, 7, 28 };
            int[] E = { 9, 4, 31, 22, 5, 1, 15, 8 };


            /**
             * End of Array declarations
             * ~~~~~~~~~~~~~~~~~~~~~~~~
             * Start of search Algortihms
            **/

            Console.WriteLine(" -- Search Algorithms -- ");

            SearchAlgos searchAlgos = new SearchAlgos();
            
            int linearFound = searchAlgos.LinearSearch(A, A.Length, 96);
            Console.WriteLine($"Result found at index : {linearFound} (Linear Search)");

            int binaryFound = searchAlgos.BinarySearch(B, B.Length, 82);
            Console.WriteLine($"Result found at index : {binaryFound} (Binary Search)");

            int binaryRecursiveFound = searchAlgos.BinaryRecSearch(C, 15, 0, C.Length);
            Console.WriteLine($"Result found at index : {binaryRecursiveFound} (Binary Rec Search)");

            /**
             * End of search Algorithms
             * ~~~~~~~~~~~~~~~~~~~~~~~~
             * Start of sort Algortihms
            **/

            Console.WriteLine(" -- Search Algorithms -- ");

            SortAlgos sortAlgos = new SortAlgos();

            displayArrays.Display("Now Using", A);
            int[] sortedSelectionSortArray = sortAlgos.SelectionSort(A);
            displayArrays.Display("Displaying Sorted Selection Array", sortedSelectionSortArray);

            displayArrays.Display("Now Using", D);
            int[] insertSortArray = sortAlgos.InsertSort(D);
            displayArrays.Display("Displaying Insert Sort Array", insertSortArray);

            displayArrays.Display("Now Using", E);
            int[] bubbleSortArray = sortAlgos.BubbleSort(E);
            displayArrays.Display("Displaying Bubble Sorted Array", bubbleSortArray);

            // End of sort algorithms

            Console.ReadKey();
        }
    }
}