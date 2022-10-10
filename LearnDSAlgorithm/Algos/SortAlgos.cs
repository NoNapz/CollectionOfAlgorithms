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

        // Merge Sort, split into subsets and sort then, then add elements from said subsets one by one into a complete sort
        public int[] MergeSort(int[] A, int left, int right)
        {
            if(left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(A, left, mid);
                MergeSort(A, mid+1, right);
                Merge(A, left, mid, right);
            }
            return A;
        }
        public void Merge(int[] A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] B = new int[right + 1];
            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i = i + 1;
                }
                else
                {
                    B[k] = A[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            while (i <= mid)
            {
                B[k] = A[i];
                i = i + 1;
                k = k + 1;
            }
            while (j <= right)
            {
                B[k] = A[j];
                j = j + 1;
                k = k + 1;
            }
            for (int x = left; x < right + 1; x++)
                A[x] = B[x];
        }

        // Quick Sort -- very efficent sorting method, besides when the array is close to sorted already.
        public int[] QuickSort(int[] A, int low, int high)
        {
            if(low < high)
            {
                int partitionNum = Partition(A, low, high);
                // Recursive call
                QuickSort(A, low, partitionNum - 1);
                QuickSort(A, partitionNum + 1, high);
            }
            return A;
        }
        public int Partition(int[] A, int low, int high)
        {
            int pivot = A[low];
            int i = low + 1;
            int j = high;
            do
            {
                while (i <= j && A[i] <= pivot)
                {
                    i++;
                }
                while (i <= j && A[i] > pivot)
                {
                    j--;
                }
                if(i <= j)
                {
                    Swap(A, i, j);
                }
            } while (i < j);
            Swap(A, low, j);
            return j;
        }
        public void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
}
