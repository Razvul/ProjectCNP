using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCNP
{
    public class User
    {
        public string Id { get; set; } // de tip GUID
        public string DisplayValue { get; set; }
        public Person Person { get; set; }
        public AddressClass Address { get; set; }
    }
}