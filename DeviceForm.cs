using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servis_Protocol
{
    public partial class DeviceForm : Form
    {
        public Device Device { get; set; }
        public DeviceForm(Device device)
        {
            InitializeComponent();
            this.Device = device;

            this.ManufacturerTextBox.Text = Device.Manufacturer;
            this.ModelTextBox.Text = Device.Model;
            this.NumberTextBox.Text = Device.SerialNumber;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Device.Manufacturer = this.ManufacturerTextBox.Text;
            this.Device.Model = this.ModelTextBox.Text;
            this.Device.SerialNumber = this.NumberTextBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Control_Validated(object sender, EventArgs e)
        {
            this.ErrorProvider.SetError(sender as Control, null);
        }

        private void Empty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Control).Text))
            {
                this.ErrorProvider.SetError(sender as Control, "Nesmí být prázdné");
                e.Cancel = true;
            }
            else             
            {
                e.Cancel = false;
            }
        }
    }
}
