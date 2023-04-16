using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsDev.GemsDev
{
    public class Validation
    {
        public static bool InputValidation(string str)
        {
            if (str == "cls") { Console.Clear(); Environment.Exit(0); };
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
