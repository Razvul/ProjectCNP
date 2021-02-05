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

        public static int Zile(string luna)
        {
            int result = 0;
            switch (luna.ToLower())
            {
                case "ianuarie":
                case "martie":
                case "mai":
                case "iulie":
                case "august":
                case "octombrie":
                case "decembrie":
                    result = 31;
                    break;
                case "aprilie":
                case "iunie":
                case "septembrie":
                case "noiembrie":
                    result = 30;
                    break;
                case "februarie":
                    result = 28;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}