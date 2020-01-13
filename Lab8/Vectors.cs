using System;

namespace Lab9
{
    public static class Vectors
    {
        public static IVector Sum(IVector v1, IVector v2)
        {
            ArrayVector v3 = new ArrayVector(v1.Length);

            if (v1.Length != v2.Length)
                throw new FormatException();

            for (int i = 0; i < v3.Length; i++)
                v3[i] = v1[i] + v2[i];

            return v3 as IVector;
        }

        public static double Scalar(IVector v1, IVector v2)
        {
            if (v1.Length != v2.Length)
                throw new FormatException();

            double scalar = 0;
            for (int i = 0; i < v1.Length; i++)
                scalar += v1[i] * v2[i];

            return scalar;
        }

        public static void MultiplyNumber(IVector v, double num)
        {
            for (int i = 0; i < v.Length; i++)
                v[i] *= num;
        }

        public static double GetNorm(IVector v)
        {
            double sum = 0;

            for (int i = 0; i < v.Length; i++)
                sum += Math.Pow(v[i], 2);

            return Math.Sqrt(sum);
        }
    }
}