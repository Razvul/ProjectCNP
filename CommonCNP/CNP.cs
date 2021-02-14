using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCNP
{
    public  class CNP
    {
        public string SEX { get; set; }
        public string AN { get; set; }
        public string LUNA { get; set; }
        public string ZI { get; set; }
        public string JUDET { get; set; }
        public string NNN { get; set; }
        public string CC { get; set; }

        public static string GetLunaCNP(string luna)
        {
            string result;
            var numar = int.Parse(luna);

            if (numar >= 1 && numar < 10)
            {
                var temp = numar.ToString();
                result = $"0{temp}";
            }
            else if (numar == 11 || numar == 12)
            {
                result = numar.ToString();
            }
            else
            {
                result = null;
            }
            return result;
        }

    }
}