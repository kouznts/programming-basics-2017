using System;

namespace Lab9
{
    [Serializable]
    public class Node
    {
        public double Data { get; set; }
        public Node Next { get; set; }

        public Node()
        {
            Data = 0;
            Next = null;
        }

        public Node(double element)
        {
            Data = element;
            Next = null;
        }

        public Node(double element, Node node)
        {
            Data = element;
            Next = node;
        }
    }
}