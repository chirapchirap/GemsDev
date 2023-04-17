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
            Console.WriteLine("Solving Quadratic Equation:\n");
            Console.WriteLine("Choose How U Want To Enter Data:");
            Console.WriteLine("1) Using Console Input");
            Console.WriteLine("2) Using Another File\n");
            Console.WriteLine("cls - Close Programm \n");
            Console.Write("Enter Command Number: ");
        }
        static public void MoveThroughCommands(in int num)
        {
            switch (num)
            {
                case 1:
                    {
                        new ConsoleOutput(num);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        string path = "";
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Specify Path to File U Want To Read: ");
                            Setters.SetPathToFile(ref path);
                            int fileLinesQuantity = 0;
                            using (StreamReader sr = new StreamReader(path))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    if (line == "") { continue; };
                                    fileLinesQuantity++;
                                }
                            }
                            QuadraticEquation[] quadraticEquations = new QuadraticEquation[fileLinesQuantity];                           
                            try
                            {
                                if (File.Exists(path) == false) { throw new Exception(); }
                                new FileReader(path, ref quadraticEquations);
                                Console.WriteLine("\nThe File Was Read...");
                                Console.Write("\nSpecify Path to The File U Want To Save The Results : ");
                                string fileResPath = "";
                                Setters.SetPathToFile(ref fileResPath);
                                FileWriter.FileOutput(ref quadraticEquations, fileLinesQuantity, fileResPath);
                                Console.WriteLine("\nResults Were Successfully Written To A File.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine(sErrorPathDoesNotExists);
                                Console.ReadLine();
                                Console.Clear();
                                ShowMenu();
                                Console.WriteLine($"{num}");
                                continue;
                            }
                        }
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine(sErrorWrongCommandMessage);
                        Console.ReadLine();
                        Console.Clear();
                        return;
                    }
            }
        }
        static string sErrorWrongCommandMessage { get { return "Error. No such command."; } }
        static string sErrorPathDoesNotExists { get { return "This File Path doesn't exists."; } }
    }
}