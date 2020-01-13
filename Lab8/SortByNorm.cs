using System.Collections;

namespace Lab9
{
    class SortByNorm : IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            IVector vect1 = obj1 as IVector;
            IVector vect2 = obj2 as IVector;

            if (vect1.GetNorm() > vect2.GetNorm())
                return 1;

            if (vect1.GetNorm() < vect2.GetNorm())
                return -1;

            return 0;
        }
    }
}