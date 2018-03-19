namespace Structures
{
    public class MinHeap<T>
    {
        private int capacity = 10;
        private int size = 0;
        private T[] items = new T[10];

        private int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;
        private int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;
        private int GetParentIndex(int childIndex) => (childIndex - 1) /2;

        private T LeftChild(int index) => items[GetLeftChildIndex(index)];
        private T RightChild(int index) => items[GetRightChildIndex(index)];
        private T Parent(int index) => items[GetLeftChildIndex(index)];

        private bool HasLeftChild(int index) => GetLeftChildIndex(index) < size;
        private bool HasRightChild(int index) => GetRightChildIndex(index) < size;
        private bool HasParent(int index) => GetLeftChildIndex(index) >= 0;

        private void Swap(int indexOne, int indexTwo)
        {
            T temp = items[indexOne];

            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }

        private void CheckCapacity()
        {
            if (size == capacity)
            {
                capacity *= 2;
                T[] newItems = new T[capacity];
            }
        }

        public T Peek()
        {
            if (size == 0) return default(T);

            return items[0];
        }

        public T Poll()
        {
            if (size == 0) return default(T);

            T item = items[0];
            items[0] = items[size - 1];
            size--;
            HeapifyDown();
            return item;
        }

        public void Add(T item)
        {
            CheckCapacity();
            items[size] = item;
            size++;
            HeapifyUp();
        }

        public void HeapifyUp()
        {
            int index = size - 1;

            while(HasParent(index) && Parent(index) > items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }           
        }

        public void HeapifyDown()
        {
            int index = 0;

            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index)  items[index])


                    Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }
    }
}
