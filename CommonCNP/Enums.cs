using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CommonCNP
{
    public static class Enums
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Sex
        {
            Masculin,
            Feminin
        }

    }
}
