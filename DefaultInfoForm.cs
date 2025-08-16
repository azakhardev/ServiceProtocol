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
    public partial class DefaultInfoForm : Form
    {
        public string ProtNumber { get; set; }
        public DateTime ProtDate { get; set; }

        public DefaultInfoForm(string number, DateTime date)
        {
            InitializeComponent();

            this.ProtNumber = number;
            this.ProtDate = date;

            this.NumberTextBox.Text = this.ProtNumber;
            this.DateTimePicker.Value = this.ProtDate;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.ProtNumber = this.NumberTextBox.Text;
            this.ProtDate = this.DateTimePicker.Value;           
            this.DialogResult = DialogResult.OK;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void NumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.NumberTextBox.Text))
            {
                this.ErrorProvider.SetError(this.NumberTextBox, "Musí být vyplněno");
                e.Cancel = true;
            }
            else 
            {
                e.Cancel = false;
            }
        }

        private void NumberTextBox_Validated(object sender, EventArgs e)
        {
            this.ErrorProvider.SetError(sender as Control, null);                        
        }
    }
}
