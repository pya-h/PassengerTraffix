using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTraffix
{
    static class TraffixTools
    {
        public static string RemoveWhiteSpaces(string str)
        {
            for (string temp = str.Trim().Replace("  ", " ");
                temp != str;
                str = temp, temp = str.Replace("  ", " ")) ;
            return str;
        }



    }
}
