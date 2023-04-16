﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsDev.GemsDev
{
    public class QuadraticEquation 
    {
        public QuadraticEquation(double a, double b, double c)
        {
            this.Coef1 = a;
            this.Coef2 = b;
            this.Coef3 = c;
        }
        public QuadraticEquation()
        {
            Coef1 = Coef2 = Coef3 = 0;
        }

        public QuadraticEquation(int num)
        {
            string Input = "";
            while (true)
            {
                Console.Clear();
                Console.Write($"Quadratic Equation № {num + 1}: ");
                Console.Write("ax^2 + bx + c = 0\na = ");
                if (!Validation.InputValidation(Setters.SetInput(ref Input)))
                {
                    Input = "";
                    continue;
                }
                else
                {
                    Coef1 = Convert.ToDouble(Input);
                    break;
                }
            }
            while (true)
            {
                Console.Clear();
                Console.Write($"Quadratic Equation № {num + 1}: ");
                Console.Write($"ax^2 + bx + c = 0\na = {Coef1}\nb = ");
                if (!Validation.InputValidation(Setters.SetInput(ref Input)))
                {
                    Input = "";
                    continue;
                }
                else
                {
                    Coef2 = Convert.ToDouble(Input);
                    break;
                }
            }
            while (true)
            {
                Console.Clear();
                Console.Write($"Quadratic Equation № {num + 1}: ");
                Console.Write($"ax^2 + bx + c = 0\na = {Coef1}\nb = {Coef2} \nc = ");
                if (!Validation.InputValidation(Setters.SetInput(ref Input)))
                {
                    Input = "";
                    continue;
                }
                else
                {
                    Coef3 = Convert.ToDouble(Input);
                    break;
                }
            }
        }
        protected internal readonly double Coef1, Coef2, Coef3;
        protected internal double FirstRoot = double.NaN, SecondRoot = double.NaN;
    }
}
