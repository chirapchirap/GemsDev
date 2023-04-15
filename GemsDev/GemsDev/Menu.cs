using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GemsDev.GemsDev
{
    static public class Menu
    {
        static public void ShowMenu()
        {
            Console.WriteLine("Solving Quadratic Equation:");
            Console.WriteLine("Choose How U Want To Enter Data:");
            Console.WriteLine("1) Using Console Input");
            Console.WriteLine("2) Using Another File");
            Console.WriteLine("Exit: n \n");
            Console.WriteLine("Enter Command Number: ");            
        }
        static public void MoveThroughCommands(in double num)
        {
            switch (num)
            {
                case 1:
                    {
                        string Input = "";
                        int Quantity = 0;
                        while (true)
                        {
                            Console.WriteLine("Enter How Many Quadratic Equation U Want To Solve: ");
                            if (!Validation.InputValidation(Program.SetInput(ref Input)))
                            {
                                Input = "";
                                continue;
                            }
                            else
                            {
                                Quantity = Convert.ToInt32(Input);
                                
                            }
                            Validation[] CoefsArr = new Validation[Quantity];
                            for (int i = 0; i < Quantity; i++)
                            {                               
                                CoefsArr[i] = new Validation(i);
                            }
                            break;
                            
                           
                        }
                        break;
                    }
                case 2:
                    {                        
                        
                       
                        break;
                    }
            default:
                    {
                        Console.WriteLine("Error. No such command.");
                        return;
                    }
            }

            }
        }
    }



    //public static  { }
    //static public int MenuNum; 



