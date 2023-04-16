using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsDev.GemsDev
{
    public class FileInputValidation
    {
        public static bool FileDataValidation(string str)
        {
            try
            {
                double num = Convert.ToDouble(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
