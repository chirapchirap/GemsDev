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
                if (!ConsoleInputValidation.InputValidation(Setters.SetConsoleInput(ref Input)))
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
                QuadraticEquation[] quadraticEquations = new QuadraticEquation[Quantity];
                Setters.SetQuadEquationRoots(ref quadraticEquations, Quantity);
                Console.Clear();
                for (int i = 0; i < Quantity; i++)
                {
                    Console.WriteLine($"* {i + 1} Quadratic Equation: ({quadraticEquations[i].Coef1})*x^2 + ({quadraticEquations[i].Coef2})*x + ({quadraticEquations[i].Coef3}) = 0");
                    if (quadraticEquations[i].FirstRoot is double.NaN && quadraticEquations[i].SecondRoot is double.NaN)
                    {
                        Console.WriteLine($"\t\t Roots: There Are No Roots\n");
                        continue;
                    }
                    Console.WriteLine($"\t\t Roots: x1 = {quadraticEquations[i].FirstRoot}\tx2 = {quadraticEquations[i].SecondRoot}\n");
                }
                break;
            }            
        }
        static string sAskQuantityOfQuadEquationsToSolveMessage { get { return "\nEnter How Many Quadratic Equation U Want To Solve: "; } }

    }
}
