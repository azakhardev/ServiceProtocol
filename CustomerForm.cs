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
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }
        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            this.Customer = customer;

            this.NameTextBox.Text = Customer.Name;
            this.AddressTextBox.Text = Customer.Address;
            this.PSCTextBox.Text = Customer.PostalCode;
            this.ICTextBox.Text = Customer.IdentificationNumber.ToString() ?? null;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Customer.Name = this.NameTextBox.Text;
            this.Customer.Address = this.AddressTextBox.Text;
            this.Customer.PostalCode = this.PSCTextBox.Text;
            this.Customer.IdentificationNumber = Convert.ToInt32(this.ICTextBox.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Empty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                this.ErrorProvider.SetError(sender as Control, "Nesmí být prázdné");
                e.Cancel = true;
            }
            else 
            {
                e.Cancel = false;
            }
        }

        private void PSCTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(this.PSCTextBox.Text, "^[0-9]{3} [0-9]{2}$"))
            {
                this.ErrorProvider.SetError(this.PSCTextBox, "Musí být ve tvaru 130 00");
                e.Cancel = true;
            }
            else 
            {
                e.Cancel = false;
            }
        }

        private void ICTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(this.ICTextBox.Text, "^[0-9]{6}$"))
            {
                this.ErrorProvider.SetError(this.ICTextBox, "Musí být z 6 čísel");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void Control_Validated(object sender, EventArgs e)
        {
            this.ErrorProvider.SetError(sender as Control, null);
        }

    }
}
