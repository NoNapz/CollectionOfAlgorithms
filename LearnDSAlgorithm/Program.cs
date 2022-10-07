namespace LearnDSAlgorithm
{
    class Program
    {
        // Letar efter en matching i en array, linjärt-
        public int LinearSearch(int[] A, int n, int key)
        {
            int i = 0;
            while(i < n)
            {
                if (A[i] == key) return i;
                i++;
            }
            return -1;
        }

        // Binär sökning, har en start om inskickade nummret är större sök efter matching i korrekt direktion.
        public int BinarySearch(int[] A, int n, int key)
        {
            int leftIdx = 0;
            int rightIdx = n - 1;
            while(leftIdx <= rightIdx)
            {
                int mid = (leftIdx + rightIdx) / 2;
                if (A[mid] == key) return mid;
                else if (A[mid] > key) rightIdx = mid - 1;
                else if (A[mid] < key) leftIdx = mid + 1;
            }
            return -1;
        }

        // Binär rec sökning, samma funktuon körs flera gånger, splitter arrayen tills rätt index hittas och sedan skrivs ut.
        public int BinaryRecSearch(int[] A, int key, int leftIdx, int rightIdx)
        {
            if (leftIdx > rightIdx) return -1;
            else
            {
                int mid = (leftIdx + rightIdx) / 2;
                if (key == A[mid]) return mid;
                else if (A[mid] > key) return BinaryRecSearch(A, key, leftIdx, mid - 1);
                else if (A[mid] < key) return BinaryRecSearch(A, key, mid + 1, rightIdx);
            }
            return -1;
        }


        static void Main(string[] args)
        {
            Program s = new Program();

            // START OF SEARCH ALGORITHMS

            int[] A = { 84, 21, 47, 96, 15 };
            int linearFound = s.LinearSearch(A, A.Length, 96);
            Console.WriteLine($"Result found at index : {linearFound} --> (Linear Search)");

            int[] B = { 2, 5, 6, 14, 82, 96 };
            int binaryFound = s.BinarySearch(B, B.Length, 82);
            Console.WriteLine($"Result found at index : {binaryFound} --> (Binary Search)");

            int[] C = { 0, 2, 4, 6, 8, 10, 14, 15, 17, 20, 22, 25 };
            int binaryRecursiveFound = s.BinaryRecSearch(C, 15, 0, C.Length);
            Console.WriteLine($"Result found at index : {binaryRecursiveFound} --> (Binary Rec Search)");

            // END OF SEARCH ALGORITHMS

            Console.ReadKey();
        }
    }
}