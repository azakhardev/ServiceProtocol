using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servis_Protocol
{
    public partial class ServisProtocolForm : Form
    {
        public ProtocolModel Protocol { get; set; } = new ProtocolModel();

        public DataSource DataSource { get; set; }
        public ServisProtocolForm()
        {
            InitializeComponent();
            this.DataSource = new DataSource(this.Protocol);
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.DataSource = DataSource.GetList();
        }

        private void EditDefualtInfoButton_Click(object sender, EventArgs e)
        {
            DefaultInfoForm form = new DefaultInfoForm(this.Protocol.ProductNumber, this.Protocol.MeasurmentDate);

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Protocol.ProductNumber = form.ProtNumber;
                this.Protocol.MeasurmentDate = form.ProtDate;
                RefreshDefaultInfo();
            }
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm(this.Protocol.Customer);

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Protocol.Customer = form.Customer;
                RefreshCutomer();
            }
        }

        private void EditDeviceButton_Click(object sender, EventArgs e)
        {
            DeviceForm form = new DeviceForm(this.Protocol.Device);

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Protocol.Device = form.Device;
                RefreshDevice();
            }
        }

        private void MeasurmentAddButton_Click(object sender, EventArgs e)
        {
            MeasurmentForm form = new MeasurmentForm(new Measurment());

            if (form.ShowDialog() == DialogResult.OK)
            {
                Measurment me = form.Measurment;
                this.DataSource.AddMeasurment(form.Measurment);                
            }
        }

        private void MeasurmentEditButton_Click(object sender, EventArgs e)
        {
            if (this.DataGrid.CurrentRow == null)
            {
                MessageBox.Show("Pro úpravu nejprve vyberte řádek");
                return;
            }

            Measurment m = this.DataGrid.CurrentRow.DataBoundItem as Measurment;
            MeasurmentForm form = new MeasurmentForm(m);

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.DataSource.EditMeasurment(form.Measurment);
            }
        }

        private void MeasurmentDeleteButton_Click(object sender, EventArgs e)
        {
            if (this.DataGrid.CurrentRow == null)
            {
                MessageBox.Show("Pro smazání nejprve vyberte řádek");
                return;
            }

            Measurment m = this.DataGrid.CurrentRow.DataBoundItem as Measurment;

            this.DataSource.DeleteMeasurment(m);
        }

        private void SaveProtocolButton_Click(object sender, EventArgs e)
        {            
            FolderBrowserDialog fileBrowser = new FolderBrowserDialog();

            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                string path = fileBrowser.SelectedPath;

                FileNameForm form = new FileNameForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    path += $@"\{form.FileName}.txt";
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        string jsonProtocol = JsonConvert.SerializeObject(this.Protocol);
                        sw.Write(jsonProtocol);
                    }
                }
            }

            fileBrowser.Dispose();
        }

        private void LoadProtocolButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fileBrowser = new System.Windows.Forms.OpenFileDialog();
            fileBrowser.DefaultExt = "txt";

            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                string path = fileBrowser.FileName;

                using (StreamReader sr = new StreamReader(path))
                {
                    string jsonProtocol = sr.ReadToEnd();
                    this.Protocol = JsonConvert.DeserializeObject<ProtocolModel>(jsonProtocol);
                    RefreshAll();
                    DataSource.RefreshSource(this.Protocol);         
                    this.DataGrid.DataSource = this.DataSource.GetList();
                }
            }
        }

        private void ViewProtocolButton_Click(object sender, EventArgs e)
        {
            ProtocolOverviewForm form = new ProtocolOverviewForm(this.Protocol);

            form.ShowDialog();
        }

        private void RefreshDefaultInfo()
        {
            this.ProtocolNumberValue.Text = this.Protocol.ProductNumber ?? "?";
            this.ProtocolDateValue.Text = this.Protocol.MeasurmentDate.ToString().Substring(0, 10);
        }

        private void RefreshCutomer()
        {
            this.CustomerNameValue.Text = this.Protocol.Customer.Name ?? "?";
            this.CustomerAddressValue.Text = this.Protocol.Customer.Address ?? "?";
            this.CustomerPSCValue.Text = this.Protocol.Customer.PostalCode ?? "?";
            this.CustomerICValue.Text = this.Protocol.Customer.IdentificationNumber.ToString() ?? "?";
        }

        private void RefreshDevice()
        {
            this.DeviceManufacturerValue.Text = this.Protocol.Device.Manufacturer ?? "?";
            this.DeviceModelValue.Text = this.Protocol.Device.Model ?? "?";
            this.DeviceNumberValue.Text = this.Protocol.Device.SerialNumber ?? "?";
        }

        private void RefreshAll()
        {
            RefreshDefaultInfo();
            RefreshCutomer();
            RefreshDevice();
        }
    }
}
