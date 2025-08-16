using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis_Protocol
{
    public class DrawnString
    {
        public DrawnString(int left, int top, string str, Font font, bool @static)
        {
            this.Left = left;
            this.Top = top;
            this.String = str;
            this.Font = font;
            this.Static = @static;
        }

        public int Left {  get; set; }

        public int Top { get; set; }

        public string String { get; set; }

        //public float Width { get; set; }

        //public float Height { get; set; }
        public bool Static { get; set; }

        public Font Font { get; set; }

        public Brush Brush { get; set; } = new SolidBrush(Color.Black);
    }
}
