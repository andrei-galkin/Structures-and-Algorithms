using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Algorithms
{
    public class QuickSort
    {
        /// <summary>
        /// Quick Sort
        /// </summary>
        public static void Sort(int[] array)
        {
            SortI(array, 0, array.Length - 1);
        }

        
        private static void Sort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
                return;

            int pivotElement = array[(rightIndex + leftIndex) / 2];

            int partitionIndex = Partition(array, pivotElement, leftIndex, rightIndex);

            Sort(array, leftIndex, partitionIndex - 1);
            Sort(array, partitionIndex, rightIndex);
        }

        private static int Partition(int[] array, int pivotElement, int leftIndex, int rightIndex)
        {            
            while (leftIndex <= rightIndex)
            {
                while (array[leftIndex] < pivotElement)
                {
                    leftIndex++;
                }

                while (array[rightIndex] > pivotElement)
                {
                    rightIndex--;
                }

                if (leftIndex <= rightIndex)
                {
                    Swap(array, leftIndex, rightIndex);
                    leftIndex++;
                    rightIndex--;
                }
            }

            return leftIndex;
        }


        public static void SortI(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            var partitionElement = array[(leftIndex + rightIndex) / 2];

            int partitionIndex = Partitioning(array, partitionElement, leftIndex, rightIndex);

            SortI(array, leftIndex, partitionIndex - 1);

            SortI(array, partitionIndex, rightIndex);
            
        }

        private static int Partitioning(int[] array, int partitionElement, int startIndex, int endIndex)
        {
            while (startIndex <= endIndex)
            {
                while (array[startIndex] < partitionElement)
                {
                    startIndex++;
                }

                while (array[endIndex] > partitionElement)
                {
                    endIndex--;
                }

                if (startIndex <= endIndex)
                {
                    Swap(array, startIndex, endIndex);
                    startIndex++;
                    endIndex--;
                }
            }

            return startIndex;
        }

    private static void Swap(int[] array, int left, int rigt)
        {
            int temp = array[left];

            array[left] = array[rigt];
            array[rigt] = temp;
        }
    }
}
