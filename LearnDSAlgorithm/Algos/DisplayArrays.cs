using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms.Algos
{
    public class DisplayArrays
    {
        public void Display(string msg, int[] A)
        {
            Console.WriteLine($"\n*- {msg}!");
            for (int i = 0; i < A.Length; i++) Console.Write(A[i] + " ");
            Console.WriteLine();
        }
    }
}
