using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public static class Validate
    {
        static Validate() { }

        public static bool ValidateDecimal(string value)
        {
            return Decimal.TryParse(value, out decimal d);
        }

        public static bool ValidateInteger(string value)
        {
            return int.TryParse(value, out int i);
        }

        public static bool ValidateLength(int lenght, string value)
        {
            return value.Length == lenght;
        }

        public static bool ValidateMaxLength(int lenght, string value)
        {
            return value.Length <= lenght;
        }

        public static bool ValidateMinLength(int lenght, string value)
        {
            return value.Length >= lenght;
        }

    }
}
