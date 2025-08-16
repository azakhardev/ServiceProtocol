using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Protocol
{
    public class DataSource : IListSource
    {
        private BindingList<Measurment> Measurments { get; set; }

        private ProtocolModel ProtocolModel { get; set; }

        public DataSource(ProtocolModel p)
        {
            this.ProtocolModel = p;

            this.Measurments = p.Measurments;
        }

        public bool ContainsListCollection => true;

        public IList GetList()
        {
            return this.Measurments;
        }

        public void RefreshSource(ProtocolModel p) 
        {
            this.ProtocolModel = p;
            this.Measurments = new BindingList<Measurment>(this.ProtocolModel.Measurments);
        }

        public void AddMeasurment(Measurment m) 
        {
            this.ProtocolModel.Measurments.Add(m);                   
        }

        public void EditMeasurment(Measurment m) 
        {
            this.ProtocolModel.Measurments.IndexOf(this.ProtocolModel.Measurments.Where(x => x == m).First());
        }

        public void DeleteMeasurment(Measurment m) 
        {
            this.ProtocolModel.Measurments.Remove(m);
        }
    }
}
