using System;

namespace Structures
{
    public class MaxHeap<T> where T : IComparable
    {
        private int _capacity = 10;
        private int _count = 0;
        private  T[] _items = new T[10];

        private int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;
        private int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;
        private int GetParentIndex(int childIndex) => (childIndex - 1) /2;

        private T LeftChild(int index) => _items[GetLeftChildIndex(index)];
        private T RightChild(int index) => _items[GetRightChildIndex(index)];
        private T Parent(int index) => _items[GetParentIndex(index)];

        private bool HasLeftChild(int index) => GetLeftChildIndex(index) < _count;
        private bool HasRightChild(int index) => GetRightChildIndex(index) < _count;
        private bool HasParent(int index) => GetLeftChildIndex(index) >= 0;

        private void Swap(int indexOne, int indexTwo)
        {
            T temp = _items[indexOne];

            _items[indexOne] = _items[indexTwo];
            _items[indexTwo] = temp;
        }

        private void CheckCapacity()
        {
            if (_count == _capacity)
            {
                _capacity *= 2;
                T[] newItems = new T[_capacity];
            }
        }

        public T Peek()
        {
            if (_count == 0) return default(T);

            return _items[0];
        }

        public T Poll()
        {
            if (_count == 0) return default(T);

            T item = _items[0];
            _items[0] = _items[_count - 1];
            _count--;
            HeapifyDown();
            return item;
        }

        public void Add(T item)
        {
            CheckCapacity();
            _items[_count] = item;
            _count++;
            HeapifyUp();
        }

        private void HeapifyUp()
        {
            int index = _count - 1;

            while(HasParent(index) && Parent(index).CompareTo(_items[index]) < 0)
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }           
        }

        private void HeapifyDown()
        {
            int index = 0;

            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index).CompareTo(LeftChild(index)) > 0)
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if(_items[index].CompareTo(_items[smallerChildIndex]) > 0)
                {
                    break;
                }
                else
                {
                    Swap(index, smallerChildIndex);
                }

                index = smallerChildIndex;
            }
        }
    }
}
