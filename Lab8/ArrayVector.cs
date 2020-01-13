using System;

namespace Lab9
{
    [Serializable]
    class ArrayVector : IVector, IComparable, ICloneable
    {
        private double[] coordinates;

        public ArrayVector(int length)
        {
            coordinates = new double[length];
        }

        public int Length
        {
            get
            {
                return coordinates.Length;
            }
        }

        public double this[int index]
        {
            get
            {
                return coordinates[index];
            }

            set
            {
                coordinates[index] = value;
            }
        }

        public double GetElement(int index)
        {
            return coordinates[index];
        }

        public void SetElement(int index, double element)
        {
            coordinates[index] = element;
        }

        public double GetNorm()
        {
            double sum = 0;

            foreach (double x in coordinates)
                sum += Math.Pow(x, 2);

            return Math.Sqrt(sum);
        }

        public double SumPosEvenIndex()
        {
            double sum = 0;

            for (int i = 0; i < Length; i = i + 2)
                if (coordinates[i] >= 0)
                    sum += coordinates[i];

            return sum;
        }

        public double SumLessOddIndex()
        {
            double temp = 0;
            foreach (double x in coordinates)
                temp += Math.Abs(x);

            double average = temp / Length;

            double sum = 0;
            for (int i = 1; i < Length; i = i + 2)
                if (coordinates[i] < average)
                    sum += coordinates[i];

            return sum;
        }

        public double MultiplyEven()
        {
            double mul = 1;

            foreach (double x in coordinates)
                if ((x > 0) && (x % 2 == 0))
                    mul *= x;

            return mul;
        }

        public double MultiplyOdd()
        {
            double mul = 1;

            foreach (double x in coordinates)
                if ((x % 2 != 0) && (x % 3 != 0))
                    mul *= x;

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
            ArrayVector arrVect = (ArrayVector)MemberwiseClone();
            arrVect.coordinates = (double[])coordinates.Clone();

            return arrVect;
        }
    }
}