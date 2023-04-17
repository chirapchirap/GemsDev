using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsDev.GemsDev
{
    internal class FileWriter
    {
        public FileWriter() { }

        public static void FileOutput(ref QuadraticEquation[] quadraticEquations, in int Quantity, in string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("\n\n");
                    for (int i = 0; i < Quantity; i++)
                    {
                        sw.WriteLine($"* {i + 1} Quadratic Equation: ({quadraticEquations[i].Coef1})*x^2 + ({quadraticEquations[i].Coef2})*x + ({quadraticEquations[i].Coef3}) = 0");
                        if (quadraticEquations[i].FirstRoot is double.NaN && quadraticEquations[i].SecondRoot is double.NaN)
                        {
                            sw.WriteLine($"\t\t Roots: There Are No Roots\n");
                            continue;
                        }
                        sw.WriteLine($"\t\t Roots: x1 = {quadraticEquations[i].FirstRoot}\tx2 = {quadraticEquations[i].SecondRoot}\n");
                    }
                }
            }

        }

    }
}
