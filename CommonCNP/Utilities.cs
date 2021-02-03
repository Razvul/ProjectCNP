using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCNP
{
    public static class Utilities
    {
        public static bool IsInteger(string a)
        {
            var result = int.TryParse(a, out int cifra);
            return result;
        }

        public static string Hello(string name)
        {
            return $"Hello {name}";
        }
    }
}