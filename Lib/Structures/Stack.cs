using System.Collections;

namespace DataStructures
{
    
    public class Stack<T>
    {
        public Stack()
        {
            Head = null;
        }

        public bool IsEmpty => Head == null;

        private Node<T> Head { get; set; }

        public Node<T> Peek()
        {
            return Head;
        }

        public void Push(T value)
        {
            if (IsEmpty)
            {
                Head = new Node<T>(value);
            }
            else
            {
                Node<T> nextNode = new Node<T>(value)
                {
                    Next = Head
                };
                Head = nextNode;
            }
        }

        public void Pop()
        {
            if (IsEmpty)
            {
                return;
            }

            Node<T> swapNode = Head;
            Head = swapNode.Next;
            swapNode = null;
        }

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
