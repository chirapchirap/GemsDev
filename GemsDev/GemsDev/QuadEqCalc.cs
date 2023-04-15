﻿namespace GemsDev.GemsDev
{
    public  class QuadEqCalc
    {
        public QuadEqCalc()
        {
            
        }
        public QuadEqCalc(in int num)
        {
            
        }
        public static double SolveDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
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