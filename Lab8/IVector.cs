namespace Lab9
{
    public interface IVector
    {
        double this[int index] { get; set; }

        int Length { get; }

        double GetNorm();

        double SumPosEvenIndex();

        double SumLessOddIndex();

        double MultiplyEven();

        double MultiplyOdd();

        object Clone();
    }
}