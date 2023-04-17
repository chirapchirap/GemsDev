using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsDev.GemsDev
{
    public class Setters
    {
        public static string SetConsoleInput(ref string value)
        {
            return value = Console.ReadLine();
        }
      
        public static void SetQuadEquationRoots(ref QuadraticEquation[] quadraticEquations, in int Quantity)
        {
            double Discrim;
            for (int i = 0; i < Quantity; i++)
            {
                quadraticEquations[i] = new QuadraticEquation(i);     
                Discrim = QuadEqCalc.SolveDiscriminant(ref quadraticEquations[i]);
                if (Discrim < 0)
                {
                    quadraticEquations[i].FirstRoot = double.NaN;
                    quadraticEquations[i].SecondRoot = double.NaN;
                    continue;
                }
                if (Discrim == 0)
                {
                    quadraticEquations[i].FirstRoot = QuadEqCalc.SolveQEqFirstRootNegSqrtDiscrim(ref quadraticEquations[i]);
                    quadraticEquations[i].SecondRoot = double.NaN;
                    continue;
                }
                quadraticEquations[i].FirstRoot = QuadEqCalc.SolveQEqFirstRootNegSqrtDiscrim(ref quadraticEquations[i]);
                quadraticEquations[i].SecondRoot = QuadEqCalc.SolveQEqSecondRootPosSqrtDiscrim(ref quadraticEquations[i]);
            }
        }
        public static void SetQuadEquationRootsForFileStream(ref QuadraticEquation[] quadraticEquations, ref double[][] Arr, in int Quantity)
        {
            double Discrim;
            for (int i = 0; i < Quantity; i++)
            {
                try
                {
                    quadraticEquations[i] = new QuadraticEquation(Arr[i]);
                    if (quadraticEquations[i].Coef1 == double.NaN || quadraticEquations[i].Coef2 == double.NaN || quadraticEquations[i].Coef3 == double.NaN)
                    {
                        throw new Exception("One of the coefficients is not a number");
                    }
                    Discrim = QuadEqCalc.SolveDiscriminant(ref quadraticEquations[i]);
                    if (Discrim < 0)
                    {
                        quadraticEquations[i].FirstRoot = double.NaN;
                        quadraticEquations[i].SecondRoot = double.NaN;
                        continue;
                    }
                    if (Discrim == 0)
                    {
                        quadraticEquations[i].FirstRoot = QuadEqCalc.SolveQEqFirstRootNegSqrtDiscrim(ref quadraticEquations[i]);
                        quadraticEquations[i].SecondRoot = double.NaN;
                        continue;
                    }
                    quadraticEquations[i].FirstRoot = QuadEqCalc.SolveQEqFirstRootNegSqrtDiscrim(ref quadraticEquations[i]);
                    quadraticEquations[i].SecondRoot = QuadEqCalc.SolveQEqSecondRootPosSqrtDiscrim(ref quadraticEquations[i]);
                }
                catch (Exception ex) 
                {
                    quadraticEquations[i].Message = ex.Message;
                    quadraticEquations[i].CoefIsNotANumberErrorFlag = true;
                    continue;
                }
            }
        }

        public static void SetPathToFile(ref string path)
        {
            path = Console.ReadLine();
        }
    }
}
