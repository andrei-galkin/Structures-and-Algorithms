using System.Collections;

namespace Structures
{
    public class Queue<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }

        public void Enqueue(T val)
        {
            if (Head == null)
            {
                Head = Tail = new Node<T>() { Value = val };
            }
            else
            {
                Tail = Tail.Next = new Node<T>() { Value = val };
            }
        }

        public void Dequeue()
        {
            var Node = Head;
            Head = Node.Next;
            if (Head == null)
                Tail = null;
        }

        public Node<T> Peek()
        {
            return Head;
        }

        public bool IsEmpty
        {
            get { return Head == null; }
        }

        public object Current => throw new System.NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
