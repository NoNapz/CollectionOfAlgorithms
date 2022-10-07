using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithm.Algos
{
    public class SortAlgos
    {
        // Selection sort
        public int[] SelectionSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                int pos = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[pos]) pos = j;
                }
                int temp = A[i];
                A[i] = A[pos];
                A[pos] = temp;
            }
            return A;
        }

        // För att skriva ut arrayen
        public void Display(string msg, int[] A)
        {
            Console.WriteLine($"*- {msg}!");
            for (int i = 0; i < A.Length; i++) Console.Write(A[i] + " ");
            Console.WriteLine();
        }
    }
}
