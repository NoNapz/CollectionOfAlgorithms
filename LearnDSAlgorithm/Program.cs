
using CSharpAlgorithms.Algos;

namespace LearnDSAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            // Several Array declarations

            DisplayArrays displayArray = new DisplayArrays();

            int[] A = { 84, 21, 47, 96, 15 };
            int[] B = { 2, 5, 6, 14, 82, 96 };
            int[] C = { 0, 2, 4, 6, 8, 10, 14, 15, 17, 20, 22, 25 };
            int[] D = { 5, 2, 10, 20, 35, 14, 7, 28 };
            int[] E = { 9, 4, 31, 22, 5, 1, 15, 8 };
            int[] F = { 19, 14, 1, 2, 25, 11, 5, 18 };
            int[] G = { 17, 1, 12, 2, 25, 31, 50, 23 };

            /**
             * End of Array declarations
             * ~~~~~~~~~~~~~~~~~~~~~~~~
             * Start of search Algortihms
            **/

            Console.WriteLine(" -- Search Algorithms -- ");

            SearchAlgos searchAlgos = new SearchAlgos();

            displayArray.Display("Now Using", A);
            int linearFound = searchAlgos.LinearSearch(A, A.Length, 96);
            Console.WriteLine($"96 found at index : {linearFound} (Linear Search)");

            displayArray.Display("Now Using", B);
            int binaryFound = searchAlgos.BinarySearch(B, B.Length, 82);
            Console.WriteLine($"82 found at index : {binaryFound} (Binary Search)");

            displayArray.Display("Now Using", C);
            int binaryRecursiveFound = searchAlgos.BinaryRecSearch(C, 15, 0, C.Length);
            Console.WriteLine($"15 found at index : {binaryRecursiveFound} (Binary Rec Search)");

            /**
             * End of search Algorithms
             * ~~~~~~~~~~~~~~~~~~~~~~~~
             * Start of sort Algortihms
            **/

            Console.WriteLine("\n -- Search Algorithms -- ");

            SortAlgos sortAlgos = new SortAlgos();

            displayArray.Display("Now Using", A);
            int[] sortedSelectionSortArray = sortAlgos.SelectionSort(A);
            displayArray.Display("Displaying Sorted Selection Array", sortedSelectionSortArray);

            displayArray.Display("Now Using", D);
            int[] insertSortArray = sortAlgos.InsertSort(D);
            displayArray.Display("Displaying Insert Sort Array", insertSortArray);

            displayArray.Display("Now Using", E);
            int[] bubbleSortArray = sortAlgos.BubbleSort(E);
            displayArray.Display("Displaying Bubble Sorted Array", bubbleSortArray);

            displayArray.Display("Now Using", F);
            int[] shellSortArray = sortAlgos.ShellSort(F);
            displayArray.Display("Displaying Shell Sorted Array", shellSortArray);

            displayArray.Display("Now Using", G);
            int[] mergeSortArray = sortAlgos.MergeSort(G, 0, G.Length - 1);
            displayArray.Display("Displaying Merge Sorted Array", mergeSortArray);

            // End of sort algorithms

            Console.ReadKey();
        }
    }
}