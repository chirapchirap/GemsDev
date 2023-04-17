using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsDev.GemsDev
{
    public static class StringSplit
    {
        public static void fileLinesSplit(ref string[][] ArrOfArr, ref string[] Arr, in int i)
        {
            ArrOfArr[i]= Arr[i].Replace("  ", " ").Split(delimiterChars);
        }
        static char[] delimiterChars = { ' ', ':', '\t' };
    }
}
