using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Protocol
{
    public class Measurment
    {
        public string Parameter { get; set; }

        public decimal Value { get; set; }

        public string Unit { get; set; }

        public bool Suits { get; set; }
    }
}
