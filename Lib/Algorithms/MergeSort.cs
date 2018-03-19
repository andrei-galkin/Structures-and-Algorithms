using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MergeSort
    {
        public static void Sort(int[] array)
        {
            int[] temp = new int[array.Length];
            Sort(array, temp, 0, array.Length - 1);
        }

        static public void Sort(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
                return;

            int midle = (rightEnd + leftStart) / 2;

            Sort(array, temp, leftStart, midle);
            Sort(array, temp, midle + 1, rightEnd);
            Merge(array, temp, midle, leftStart, rightEnd);
        }

        static public void Merge (int[] array, int[] temp, int midle, int leftStart, int rightEnd)
        {
            int leftEnd = midle;            
            int rightStart = leftEnd + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            int size = rightEnd - leftStart + 1;            

            while (left <= leftEnd && right <= rightEnd)
            {
                if (array[left] <= array[right])
                {
                    temp[index] = array[left];
                    left++;
                }
                else
                {
                    temp[index] = array[right];
                    right++;
                }

                index++;
            }

            for (int i = index; i <= leftEnd - left + 1; i++)
            {
                temp[i] = array[left];
                left++;
            }

            for (int i = index; i <= rightEnd - right + 1; i++)
            {
                temp[i] = array[right];
                right++;
            }

            for (int i = leftStart; i <= size; i++)
            {
                array[i] = temp[i];
            }
        }
    }
}
