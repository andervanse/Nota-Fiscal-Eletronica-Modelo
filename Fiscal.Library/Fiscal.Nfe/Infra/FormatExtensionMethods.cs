using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fiscal.Nfe.Util
{
    public static class FormatExtensionMethods
    {
        public static string CnpjFormat(this string str)
        {
            if (!String.IsNullOrEmpty(str) && str.Length == 14)
                return str.Substring(0, 2) + "." + str.Substring(3, 3) + "." + str.Substring(5, 3) + "/" + str.Substring(8, 4) + "-" + str.Substring(12, 2);
            else
                return str;
        }

        public static string CpfFormat(this string str)
        {
            if (!String.IsNullOrEmpty(str) && str.Length == 11)
                return str.Substring(0, 3) + "." + str.Substring(3, 3) + "." + str.Substring(6, 3) + "-" + str.Substring(9, 2);
            else
                return str;
        }
    }
}
