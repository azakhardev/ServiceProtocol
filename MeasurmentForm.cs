using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servis_Protocol
{
    public partial class MeasurmentForm : Form
    {
        public Measurment Measurment { get; set; }

        public MeasurmentForm(Measurment measurment)
        {
            InitializeComponent();
            this.Measurment = measurment;

            this.ParameterTextBox.Text = Measurment.Parameter;
            this.ValueTextBox.Text = Measurment.Value.ToString();
            this.UnitTextBox.Text = Measurment.Unit;
            this.SuitsCheckBox.Checked = Measurment.Suits;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {            
            this.Measurment.Parameter = this.ParameterTextBox.Text;            
            this.Measurment.Value = decimal.Parse(this.ValueTextBox.Text);
            this.Measurment.Unit = this.UnitTextBox.Text;
            this.Measurment.Suits = this.SuitsCheckBox.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void ValueTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(this.ValueTextBox.Text, "^[0-9]+,?[0-9]*$"))
            {
                this.ErrorProvider.SetError(this.ValueTextBox, "Musí být celé nebo desetinné číslo");
                e.Cancel= true;
            }
            else 
            {
                e.Cancel = false;
            }

        }
    }
}
