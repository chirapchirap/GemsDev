using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsDev.GemsDev
{
    public class Setters
    {
        public static string SetInput(ref string value)
        {
            return value = Console.ReadLine();
        }
        public static void SetQuadEquationRoots(ref QuadraticEquation[] CoefsArr, in int Quantity)
        {
            double Discrim;
            for (int i = 0; i < Quantity; i++)
            {
                CoefsArr[i] = new QuadraticEquation(i);     
                Discrim = QuadEqCalc.SolveDiscriminant(ref CoefsArr[i]);
                if (Discrim < 0)
                {
                    CoefsArr[i].FirstRoot = double.NaN;
                    CoefsArr[i].SecondRoot = double.NaN;
                    continue;
                }
                if (Discrim == 0)
                {
                    CoefsArr[i].FirstRoot = QuadEqCalc.SolveQEqFirstRootNegSqrtDiscrim(ref CoefsArr[i]);
                    CoefsArr[i].SecondRoot = double.NaN;
                    continue;
                }
                CoefsArr[i].FirstRoot = QuadEqCalc.SolveQEqFirstRootNegSqrtDiscrim(ref CoefsArr[i]);
                CoefsArr[i].SecondRoot = QuadEqCalc.SolveQEqSecondRootPosSqrtDiscrim(ref CoefsArr[i]);
            }
        }
    }
}
