using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriTest
{
    public class AllSort
    {
        static private void Swap(int[] table, int i, int j)
        {
            int tmp;

            tmp = table[i];
            table[i] = table[j];
            table[j] = tmp;
        }

        static public void SelectSort(int[] table)
        {
            int idx;

            for (int i = 0; i < table.Length; i++)
            {
                idx = i;
                for (int j = i + 1; j < table.Length; j++)
                    if (table[j] < table[idx])
                        idx = j;
                Swap(table, i, idx);
            }
        }

        static public void InsertSort(int[] table)
        {
            int idx;
            int tmp;

            for (int i = 1; i < table.Length; i++)
            {
                tmp = table[i];
                for (idx = i - 1; idx >= 0 && tmp < table[idx]; idx--)
                    table[idx + 1] = table[idx];
                table[idx + 1] = tmp;
            }
        }

        static public void BubleSort(int[] table)
        {
            int tmp;

            for (int i = 0; i < table.Length; i++)
            {
                tmp = i;
                for (int j = 0; j != table.Length - 1; j++)
                {
                    if (table[j] > table[j + 1])
                        Swap(table, j, j + 1);
                }
            }
        }

        static private void DoMerge(int[] table, int[] left, int[] right)
        {
            int leftIdx = 0;
            int rightIdx = 0;
            int tableIdx = 0;
            int remaining = left.Length + right.Length;

            while (remaining > 0)
            {
                if (leftIdx >= left.Length)
                    table[tableIdx] = right[rightIdx++];
                else if (rightIdx >= right.Length)
                    table[tableIdx] = left[leftIdx++];
                else if (left[leftIdx] < right[rightIdx])
                    table[tableIdx] = left[leftIdx++];
                else
                    table[tableIdx] = right[rightIdx++];

                tableIdx++;
                remaining--;
            }
        }

        static public void MergeSort(int[] table)
        {
            int leftSize = table.Length / 2;
            int rightSize = table.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            Array.Copy(table, 0, left, 0, leftSize);
            Array.Copy(table, leftSize, right, 0, rightSize);

            if (table.Length > 1)
            {
                MergeSort(left);
                MergeSort(right);
                DoMerge(table, left, right);
            }
        }

        private static int partition(int[] table, int left, int right, int pivot)
        {
            int pivotValue = table[pivot];

            Swap(table, pivot, right);

            int storedIdx = left;

            for (int i = left; i < right; i++)
            {
                if (table[i] < pivotValue)
                {
                    Swap(table, i, storedIdx);
                    storedIdx++;
                }
            }

            Swap(table, storedIdx, right);
            return storedIdx;
        }

        static private void RecQS(int[] table, int left, int right)
        {

            if (left < right)
            {
                int pivot = (left + right) / 2;
                int newPivot = partition(table, left, right, pivot);

                RecQS(table, left, newPivot - 1);
                RecQS(table, newPivot + 1, right);
            }
        }

        static public void QuickSort(int[] table)
        {
            RecQS(table, 0, table.Length - 1);
        }
    }
}
