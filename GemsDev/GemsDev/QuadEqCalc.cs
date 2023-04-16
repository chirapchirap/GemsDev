namespace GemsDev.GemsDev
{
    public  class QuadEqCalc : QuadraticEquation
    {
        public QuadEqCalc()
        {            
        }
        public static double SolveDiscriminant(ref QuadraticEquation obj)
        {
            return obj.Coef2 * obj.Coef2- 4 * obj.Coef1 * obj.Coef3;
        }
        public static double SolveQEqFirstRootNegSqrtDiscrim(ref QuadraticEquation obj)
        {
            return ((-obj.Coef2 - Math.Sqrt(obj.Coef2 * obj.Coef2 - 4* obj.Coef1* obj.Coef3))/(2*obj.Coef1));
        }
        public static double SolveQEqSecondRootPosSqrtDiscrim(ref QuadraticEquation obj)
        {
            return ((-obj.Coef2 + Math.Sqrt(obj.Coef2 * obj.Coef2 - 4 * obj.Coef1 * obj.Coef3)) / (2 * obj.Coef1));
        }

    }
}