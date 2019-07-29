using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApiFacturaElectronica
{
    public static class Utilities
    {
        public static bool IsValidIdFactura(string description)
        {
            return false;
        }

        public static bool IsValidNIT(string description)
        {
            if (string.IsNullOrEmpty(description))
                return false;

            string compare = description;
            Regex regex = new Regex(@"[\d]");

            if (regex.IsMatch(compare))
                return true;

            regex = new Regex("[0-9]");

            if (regex.IsMatch(compare))
                return true;


            return false;
        }

        public static bool IsValidIVA(int IVA)
        {
            if (IVA >= 0 && IVA <= 100)
                return true;
            return false;
        }
    }
}
