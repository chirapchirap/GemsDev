namespace GemsDev.Tests
{
    public static class QuadEqCalc
    {
        public static double SolveQEqNegRoot(double a, double b, double c)
        {
            return ((-b - Math.Sqrt(b*b - 4*a*c))/(2*a));
        }
        public static double SolveQEqPosRoot(double a, double b, double c)
        {
            return ((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
        }

    }
}