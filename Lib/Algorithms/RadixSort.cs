using System;

namespace Algorithms
{
    public class RadixSort
    {
        /// <summary>
        /// Radix Sort
        /// </summary>
        public static void Sort(int[] array)
        {
            int i;
            int j;

            int[] tmp = new int[array.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < array.Length; ++i)
                {
                    bool move = (array[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        array[i - j] = array[i];
                    else
                        tmp[j++] = array[i];
                }

                //Array.Copy(tmp, 0, array, array.Length - j, j);
                Copy(tmp, 0, array, array.Length - j, j);
            }
        }

        private static void Copy(int[] sourceArray, int sourceIndex, int[] destinationArray, int destinationIndex, int length)
        {
            int j = destinationIndex;

            for (var i = sourceIndex; i > length; i++)
            { 
                destinationArray[j] = sourceArray[i];
                j++;
            }
        }
    }
}
