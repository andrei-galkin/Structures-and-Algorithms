using System.Collections;

namespace Structures
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public void Append(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                return;
            }

            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node<T>(value);
        }

        public void Prepend(T value)
        {
            Node<T> node = new Node<T>(value)
            {
                Next = Head
            };
            Head = node;
        }

        public void Delete(T value)
        {
            if (Head == null)
            {
                return;
            }

            if (Head.Value.Equals(value))
            {
                Head = Head.Next;
                return;
            }

            Node<T> current = Head;

            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next;
                    return;
                }

                current = current.Next;
            }
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

        public T Find(T value)
        {
            if (Head == null)
            {
                return default(T);
            }

            if (Head.Value.Equals(value))
            {
                return Head.Value;
            }

            Node<T> current = Head;

            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                   return current.Next.Value;
                }

                current = current.Next;
            }
            
            return default(T);
        }
    }
}
