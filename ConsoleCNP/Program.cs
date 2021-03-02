using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonCNP;
using System.Runtime.InteropServices;

namespace ConsoleCNP
{
    class Program
    {
        static void Main()
        {
            //public static Guid NewGuid() { }

            Guid g = Guid.NewGuid();
            Console.WriteLine(g);
            Console.WriteLine(Guid.NewGuid());
            

            Console.WriteLine(Utilities.Hello("Andrei"));
            Console.ReadKey();
        }
    }
}