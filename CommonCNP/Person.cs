using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCNP
{
    public class Person
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Enums.Sex Sex { get; set; }
        public double CNP { get; set; }
    }
}
