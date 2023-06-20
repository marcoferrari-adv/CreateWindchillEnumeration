using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CreateWindchillEnumeration
{
    internal class ValidationHelper
    {

        public static Boolean isInternalValueValid(string internalValue)
        {
            return internalValue != null && Regex.IsMatch(internalValue, "^[a-zA-Z0-9_-]+$");
        }
    }
}
