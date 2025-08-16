using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Protocol
{
    public class ProtocolModel
    {
        public string ProductNumber { get; set; }

        public DateTime MeasurmentDate { get; set; } = DateTime.Now;

        public Customer Customer { get; set; } = new Customer();

        public Device Device { get; set; } = new Device();

        public BindingList<Measurment> Measurments { get; set; } = new BindingList<Measurment>();        
    }
}
