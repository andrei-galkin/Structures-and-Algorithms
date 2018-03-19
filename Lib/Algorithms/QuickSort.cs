namespace Algorithms
{
    public class QuickSort
    {
        /// <summary>
        /// Quick Sort
        /// </summary>
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

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

        private static void Swap(int[] array, int left, int rigt)
        {
            int temp = array[left];

            array[left] = array[rigt];
            array[rigt] = temp;
        }
    }
}
