using System;

namespace Lab5
{
    public static class FractionMath
    {
        public static Fraction Sum(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = new Fraction(
                fract1.Numerator * fract2.Denominator + fract2.Numerator * fract1.Denominator,
                fract1.Denominator * fract2.Denominator);

            return fract3;
        }

        public static Fraction Subtract(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = new Fraction(
                fract1.Numerator * fract2.Denominator - fract2.Numerator * fract1.Denominator,
                fract1.Denominator * fract2.Denominator);

            return fract3;
        }

        public static Fraction Multiply(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = new Fraction(
                fract1.Numerator * fract2.Numerator,
                fract1.Denominator * fract2.Denominator);

            return fract3;
        }

        public static Fraction Divide(Fraction fract1, Fraction fract2)
        {
            Fraction fract3 = new Fraction(
                fract1.Numerator * fract2.Denominator,
                fract1.Denominator * fract2.Numerator);

            return fract3;
        }

        public static int GetGcd(int numerator, int denominator)
        {
            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);

            while (denominator != 0 && numerator != 0)
            {
                if (numerator % denominator > 0)
                {
                    int temp = numerator;
                    numerator = denominator;
                    denominator = temp % denominator;
                }
                else
                    break;
            }

            if (denominator != 0 && numerator != 0)
                return denominator;
            else
                return 0;
        }

        public static void Reduce(Fraction fract)
        {
            int gcd = GetGcd(fract.Numerator, fract.Denominator);

            if (gcd != 0)
            {
                fract.Numerator /= gcd;
                fract.Denominator /= gcd;
            }
        }
    }
}