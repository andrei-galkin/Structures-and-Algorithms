﻿namespace Structures
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Value { get; set; }
        public Node()
        {
            Next = null;
        }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
