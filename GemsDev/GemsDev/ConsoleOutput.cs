using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsDev.GemsDev
{
    internal class ConsoleOutput
    {
        public ConsoleOutput()
        {            
        }
        public ConsoleOutput(in int num)
        {
            string Input = "";
            int Quantity = 0;
            while (true)
            {
                Console.Write(sAskQuantityOfQuadEquationsToSolveMessage);
                if (!Validation.InputValidation(Setters.SetInput(ref Input)))
                {
                    Input = "";
                    Console.Clear();
                    Menu.ShowMenu();
                    Console.WriteLine($"{num}");
                    continue;
                }
                else
                {
                    Quantity = Convert.ToInt32(Input);
                }
                QuadraticEquation[] CoefsArr = new QuadraticEquation[Quantity];
                Setters.SetQuadEquationRoots(ref CoefsArr, Quantity);
                Console.Clear();
                for (int i = 0; i < Quantity; i++)
                {
                    Console.WriteLine($"* {i + 1} Quadratic Equation: ({CoefsArr[i].Coef1})*x^2 + ({CoefsArr[i].Coef2})*x + ({CoefsArr[i].Coef3}) = 0");
                    if (CoefsArr[i].FirstRoot is double.NaN && CoefsArr[i].SecondRoot is double.NaN)
                    {
                        Console.WriteLine($"\t\t Roots: There Are No Roots\n");
                        continue;
                    }
                    Console.WriteLine($"\t\t Roots: x1 = {CoefsArr[i].FirstRoot}\tx2 = {CoefsArr[i].SecondRoot}\n");
                }
                break;
            }            
        }
        static string sAskQuantityOfQuadEquationsToSolveMessage { get { return "\nEnter How Many Quadratic Equation U Want To Solve: "; } }

    }
}
