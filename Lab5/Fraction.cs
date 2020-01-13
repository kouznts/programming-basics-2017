namespace Lab5
{
    public class Fraction
    {
        public int Numerator { get; set; }
        private int denominator;

        public int Denominator
        {
            get
            {
                return denominator;
            }

            set
            {
                if (value == 0)
                    denominator = 1;
                else
                    denominator = value;
            }
        }

        public Fraction()
        {
            Numerator = 1;
            denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;

            if (denominator == 0)
                this.denominator = 1;
            else
                this.denominator = denominator;
        }

        public void Sum(Fraction fraction)
        {
            Numerator = Numerator * fraction.denominator + fraction.Numerator * denominator;
            denominator = denominator * fraction.denominator;
        }

        public void Subtract(Fraction fraction)
        {
            Numerator = Numerator * fraction.denominator - fraction.Numerator * denominator;
            denominator = denominator * fraction.denominator;
        }

        public void Multiply(Fraction fraction)
        {
            Numerator = Numerator * fraction.Numerator;
            denominator = denominator * fraction.denominator;
        }

        public void Divide(Fraction fraction)
        {
            Numerator = Numerator * fraction.denominator;
            denominator = denominator * fraction.Numerator;
        }
    }
}