using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[] { 8, 4, 2, 0, 3, 1, 7, 9, 6, 5 };
            int[] tmp = new int[10];

            foreach (int i in table)
                Console.Write(i + " ");
            Console.WriteLine();

            //AllSort.SelectSort(table);
            //AllSort.InsertSort(table);
            //AllSort.BubleSort(table);
            //AllSort.MergeSort(table);
            AllSort.QuickSort(table);

            foreach (int i in table)
                Console.Write(i + " ");
            Console.WriteLine();
                
        }
    }
}
