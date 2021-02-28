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

        public static bool VerificaCNP(string cnp_cuvant)
        {
            int[] constanta = new int[12] { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };

            if (string.IsNullOrEmpty(cnp_cuvant))
            {
                return false;
            }
            if (cnp_cuvant.Length != 13)
            {
                return false;
            }

            int suma = 0;
            int cifraControl = int.Parse(cnp_cuvant.Substring(12,1));
            int result;

            for (int i = 0; i < constanta.Length; i++)
            {
                suma += int.Parse(cnp_cuvant.Substring(i,1)) * constanta[i];
            }
            if (suma % 11 == 10)
            {
                result = 1;
            }
            else
            {
                result = suma % 11;
            }

            if (result == cifraControl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}