using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GemsDev.GemsDev
{
    internal class FileReader
    {
        public FileReader()
        {

        }
        public FileReader(in string path)
        {
            var fileLinesQuantity = 0;


            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                using (var sr = new StreamReader(file))
                {
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            fileLinesQuantity++;
                        }
                    }
                }
            }
            QuadraticEquation[] quadraticEquations = new QuadraticEquation[fileLinesQuantity];
            using (FileStream FileInput = new FileStream(path, FileMode.Open))
            {
                using (var sr = new StreamReader(FileInput))
                {
                    string[] sFileLinesArray = new string[fileLinesQuantity];
                    for (int i = 0; i < fileLinesQuantity; i++)
                    {
                        string line;
                        if ((line = sr.ReadLine()) == null)
                        {
                            break;
                        }
                        sFileLinesArray[i] = line;
                    }
                    double[][] ArraysInArray = new double[fileLinesQuantity][];
                    for (int i = 0; i < fileLinesQuantity; i++)
                    {
                        try
                        {
                            string[] sCoefsFromFileLine = sFileLinesArray[i].Split(delimiterChars);
                            if (sCoefsFromFileLine.Length > 3)
                            {
                                throw new IndexOutOfRangeException();
                            }
                            double[] dCoefs = new double[3];

                            for (int j = 0; j < sCoefsFromFileLine.Length; j++)
                            {
                                if (!FileInputValidation.FileDataValidation(sCoefsFromFileLine[j]))
                                {
                                    // В строке i сущность не яв-ся числом 

                                }
                                dCoefs[j] = Convert.ToDouble(sCoefsFromFileLine[j]);
                            }
                            ArraysInArray[i] = dCoefs;

                           
                            continue;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            //В строке больше 3 коэф
                            Console.WriteLine("There Are A Lot Of Coeficients For Quadratic Equation");
                        }
                        Setters.SetQuadEquationRootsForFileStream(ref quadraticEquations, ref ArraysInArray, in fileLinesQuantity);
                    }
                }
            }
            FileWriter.FileOutput(ref quadraticEquations, in fileLinesQuantity, in path);
        }
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
    }
}

