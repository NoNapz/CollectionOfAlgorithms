using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms.Algos
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

        // Insertion Sort, a good way to see this algorithm is like sorting playing cards by hand.
        public int[] InsertSort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int temp = A[i];
                int pos = i;
                while(pos > 0 && A[pos - 1] > temp)
                {
                    A[pos] = A[pos - 1];
                    pos--;
                }
                A[pos] = temp;
            }
            return A;
        }

        // Bubble Sort, goes thro array if index at any position is less than the previous, swap them, repeat.
        public int[] BubbleSort(int[] A)
        {
            for (int pass = A.Length - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (A[i] > A[i+1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
            return A;
        }

        // Shell Sort, similar to insertion except it works with gaps.
        public int[] ShellSort(int[] A)
        {
            int gap = A.Length / 2;
            while(gap > 0)
            {
                int i = gap;
                while(i < A.Length)
                {
                    int temp = A[i];
                    int j = i - gap;
                    while(j >= 0 && A[j] > temp)
                    {
                        A[j + gap] = A[j];
                        j = j - gap;
                    }
                    A[j + gap] = temp;
                    i++;
                }
                gap /= 2;
            }
            return A;
        }

        // Merge Sort

        // Quick Sort
    }
}
