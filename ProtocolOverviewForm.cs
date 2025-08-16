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
    public partial class ProtocolOverviewForm : Form
    {
        public ProtocolModel Protocol { get; set; }

        //public List<DrawnString> ProtocolStrings { get; set; }

        public ProtocolOverviewForm(ProtocolModel p)
        {
            InitializeComponent();
            this.Protocol = p;
            this.PictureBox.Left = 10;
            this.PictureBox.Top = 10;
            this.PictureBox.Width = this.Width - 40;
            this.PictureBox.Height = this.Height - 100;

            Font title = new Font("Arial", 20, FontStyle.Bold);
            Font obj = new Font("Arial", 16, FontStyle.Italic);
            Font property = new Font("Arial", 11, FontStyle.Regular);


            //this.ProtocolStrings = new List<DrawnString>() {
            //    new DrawnString(0,60,"Potvrzení o provedení měření",title, false),
            //    new DrawnString(230,100,$"Datum měření: {this.Protocol.MeasurmentDate.ToString().Substring(0,10)}",property, true)
            //}; 
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {            
            Graphics g = e.Graphics;
            Draw(g);
        }


        private void Draw(Graphics g) 
        {
            Pen p = new Pen(Color.Black);

            Font title = new Font("Arial", 20, FontStyle.Bold);
            Font obj = new Font("Arial", 16, FontStyle.Italic);
            Font property = new Font("Arial", 11, FontStyle.Regular);

            //g.DrawRectangle(p, 10, 10, this.PictureBox.Width - 20, this.PictureBox.Height - 20);

            //foreach (DrawnString item in ProtocolStrings)
            //{
            //    float stringWidth = g.MeasureString(item.String, item.Font).Width;
            //    float stringHeight = g.MeasureString(item.String, item.Font).Height;
            //    if(!item.Static)
            //        g.DrawString(item.String, item.Font, item.Brush, this.PictureBox.Width / 2 - stringWidth / 2, item.Top - stringHeight / 2);
            //    else
            //        g.DrawString(item.String, item.Font, item.Brush, item.Left, item.Top - stringHeight / 2);
            //}

            float stringWidth = g.MeasureString("Potvrzení o provedení měření", title).Width;
            float stringHeight = g.MeasureString("Potvrzení o provedení měření", title).Height;            
            g.DrawString("Potvrzení o provedení měření", title, Brushes.Black, this.PictureBox.Width / 2 - stringWidth / 2, 60 - stringHeight / 2);

            //stringWidth = g.MeasureString($"Datum měření: {this.Protocol.MeasurmentDate.ToString().Substring(0,10)}", property).Width;
            //stringHeight = g.MeasureString($"Datum měření: {this.Protocol.MeasurmentDate.ToString().Substring(0, 10)}", property).Height;
            g.DrawString($"Datum měření: {this.Protocol.MeasurmentDate.ToString().Substring(0, 10)}", property, Brushes.Black, 25, 100);

            stringWidth = g.MeasureString($"Čislo protokolu: {this.Protocol.ProductNumber}", property).Width;
            stringHeight = g.MeasureString($"Čislo protokolu: {this.Protocol.ProductNumber}", property).Height;
            g.DrawString($"Čislo protokolu: {this.Protocol.ProductNumber}", property, Brushes.Black, this.PictureBox.Width - stringWidth - 20, 100);

            g.DrawRectangle(p, 25,120, this.PictureBox.Width/2 - 50, 120);
            g.DrawRectangle(p, this.PictureBox.Width/2 + 25,120, this.PictureBox.Width/2 - 50, 120);

            
            g.DrawString("Zákazník", obj, Brushes.Black, 35, 130);
            g.DrawString($"Název: {this.Protocol.Customer.Name}", property, Brushes.Black, 35, 155);
            g.DrawString($"Adresa: {this.Protocol.Customer.Address}", property, Brushes.Black, 35, 175);
            g.DrawString($"PSČ: {this.Protocol.Customer.PostalCode}", property, Brushes.Black, 35, 195);
            g.DrawString($"IČ: {this.Protocol.Customer.IdentificationNumber}", property, Brushes.Black, 35, 215);

            g.DrawString("Zařízení", obj, Brushes.Black, this.PictureBox.Width / 2 + 30, 130);
            g.DrawString($"Výrobce: {this.Protocol.Device.Manufacturer}", property, Brushes.Black, this.PictureBox.Width/2 + 30, 160);
            g.DrawString($"Model: {this.Protocol.Device.Model}", property, Brushes.Black, this.PictureBox.Width / 2 + 30, 177);
            g.DrawString($"Sériové číslo: {this.Protocol.Device.SerialNumber}", property, Brushes.Black, this.PictureBox.Width / 2 + 30, 194);


            int height = 0;
            bool suits = true;


            g.DrawString("Parametr", obj, Brushes.Black, 25, 290 - stringHeight / 2);
            stringWidth = g.MeasureString("Naměřená hodnota", obj).Width;
            stringHeight = g.MeasureString("Naměřená hodnota", obj).Height;
            g.DrawString("Naměřená hodnota", obj, Brushes.Black, this.PictureBox.Width/2 - stringWidth/2, 290 - stringHeight / 2);
            stringWidth = g.MeasureString("Vyhovuje", obj).Width;
            stringHeight = g.MeasureString("Vyhovuje", obj).Height;
            g.DrawString("Vyhovuje", obj, Brushes.Black, this.PictureBox.Width - stringWidth - 25, 290 - stringHeight / 2);

            foreach (Measurment measurment in this.Protocol.Measurments)
            {
                stringHeight = g.MeasureString($"{measurment.Parameter}", property).Height;
                g.DrawString($"{measurment.Parameter}", property, Brushes.Black, 25 , 320 + height - stringHeight/2);

                stringWidth = g.MeasureString($"{measurment.Value} {measurment.Unit}", property).Width;
                stringHeight = g.MeasureString($"{measurment.Value} {measurment.Unit}", property).Height;
                g.DrawString($"{measurment.Value} {measurment.Unit}", property, Brushes.Black, this.PictureBox.Width/2 - stringWidth/2 , 320 + height - stringHeight/2);

                stringWidth = g.MeasureString($"{measurment.Suits}", property).Width;
                stringHeight = g.MeasureString($"{measurment.Suits}", property).Height;
                g.DrawString($"{measurment.Suits}", property, Brushes.Black, this.PictureBox.Width - stringWidth - 40 , 320 + height - stringHeight/2);

                height += 17;
                if (!measurment.Suits )                                 
                    suits = false;                
            }

            string conclusion = "";

            if (suits)
                conclusion = "Zařízení je schopné dalšího provozu";
            else
                conclusion = "Zařízení není schopné dalšího provozu";

            stringWidth = g.MeasureString(conclusion, title).Width;
            g.DrawString(conclusion, title, Brushes.Black, this.PictureBox.Width / 2 - stringWidth/2, 335 + height);
            
            //stringWidth = g.MeasureString("",).Width;
            //stringHeight = g.MeasureString("", ).Height;
            //g.DrawString("", , Brushes.Black, this.PictureBox.Width / 2 - stringWidth / 2, 60 - stringHeight / 2);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProtocolOverviewForm_Resize(object sender, EventArgs e)
        {
            this.PictureBox.Refresh();
            this.PictureBox.Left = 10;
            this.PictureBox.Top = 10;
            this.PictureBox.Width = this.Width - 40;
            this.PictureBox.Height= this.Height - 100;
            this.CloseButton.Left = this.Width - (this.CloseButton.Width + 20);
            this.CloseButton.Top = this.Height - (this.CloseButton.Height + 50);
        }
    }
}
