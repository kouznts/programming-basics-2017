using System;

namespace Lab9
{
    [Serializable]
    public class LinkedListVector : IVector, IComparable, ICloneable
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Length { get; private set; }

        public LinkedListVector(int length)
        {
            Length = length;
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    Node current = Head;

                    int i = 0;
                    while (i < index)
                    {
                        current = current.Next;
                        i++;
                    }

                    return current.Data;
                }
            }

            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    Node current = Head;

                    int i = 0;
                    while (i < index)
                    {
                        current = current.Next;
                        i++;
                    }

                    current.Data = value;
                }
            }
        }

        public void Push(double element)
        {
            Node node = new Node(element);

            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

            Length++;
        }

        public double GetNorm()
        {
            double sum = 0;

            Node current = Head;
            while (current != null)
            {
                sum += Math.Pow(current.Data, 2);
                current = current.Next;
            }

            return Math.Sqrt(sum);
        }

        public double SumPosEvenIndex()
        {
            double sum = 0;

            for (int i = 0; i < Length; i = i + 2)
                if (this[i] >= 0)
                    sum += this[i];

            return sum;
        }

        public double SumLessOddIndex()
        {
            double temp = 0;
            for (int i = 0; i < Length; i++)
                temp += Math.Abs(this[i]);

            double average = temp / Length;

            double sum = 0;
            for (int i = 1; i < Length; i = i + 2)
                if (this[i] < average)
                    sum += this[i];

            return sum;
        }

        public double MultiplyEven()
        {
            double mul = 1;

            for (int i = 0; i < Length; i++)
                if ((this[i] > 0) && (this[i] % 2 == 0))
                    mul *= this[i];

            return mul;
        }

        public double MultiplyOdd()
        {
            double mul = 1;

            for (int i = 0; i < Length; i++)
                if ((this[i] % 2 != 0) && (this[i] % 3 != 0))
                    mul *= this[i];

            return mul;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is IVector vector))
                return false;

            if (Length == vector.Length)
            {
                for (int i = 0; i < Length; i++)
                    if (this[i] != vector[i])
                        return false;

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            IVector vector = obj as IVector;

            if (Length < vector.Length)
                return -1;

            if (Length > vector.Length)
                return 1;

            return 0;
        }

        public object Clone()
        {
            LinkedListVector clone = new LinkedListVector(0);

            Node current = Head;
            while (current != null)
            {
                clone.Push(current.Data);
                current = current.Next;
            }

            return clone;
        }
    }
}