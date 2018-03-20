namespace Algorithms
{
    public class BubbleSort
    {
        /// <summary>
        /// Bubble Sort
        /// </summary>
        public static void Sort(int[] array)
        {
            Sort(array, array.Length - 2);
        }

        private static void Sort(int[] array, int size)
        {
            if (size == 1) return;

            for (int j = 0; j <= array.Length - 2; j++)
            {
                if (array[j] > array[j + 1])
                {
                   Swap(array, j, j + 1);
                }
            }
            Sort(array, size - 1);
        }

        private static void Swap(int[] array, int left, int rigt)
        {
            int temp = array[left];

            array[left] = array[rigt];
            array[rigt] = temp;
        }
    }
}
