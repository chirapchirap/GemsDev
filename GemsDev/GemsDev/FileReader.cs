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
        public FileReader(string path, ref QuadraticEquation[] quadraticEquations)
        {
            int fileLinesQuantity = 0;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "") { continue; };
                        fileLinesQuantity++;
                    }
                }
            }
            string[] fileLinesArr = new string[fileLinesQuantity];
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    for (int i = 0; i < fileLinesQuantity; i++)
                    {
                        string line;
                        if ((line = sr.ReadLine()) == null)
                        {
                            break;
                        }
                        fileLinesArr[i] = line;
                    }
                }
            }
            string[][] splitedBySingleWordArr = new string[fileLinesQuantity][];
            for (int i = 0; i < fileLinesQuantity; i++)
            {
                StringSplit.fileLinesSplit(ref splitedBySingleWordArr, ref fileLinesArr, i);
            }
            double[][] fileLineQuadEquationCoefs = new double[fileLinesQuantity][];
            for (int i = 0; i < fileLinesQuantity; i++)
            {
                double[] doubles = new double[3];
                for (int j = 0; j < 3; j++)
                {
                    if (!FileInputValidation.FileDataValidation(ref splitedBySingleWordArr[i][j])) 
                    {
                        doubles[j] = double.NaN;
                        continue;
                    }
                    doubles[j] = Convert.ToDouble(splitedBySingleWordArr[i][j]);
                }
                fileLineQuadEquationCoefs[i] = doubles;
            }          
            Setters.SetQuadEquationRootsForFileStream(ref quadraticEquations, ref fileLineQuadEquationCoefs, fileLinesQuantity);       
        }
    }
}
