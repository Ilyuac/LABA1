using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Consider1
{
    public class Elipse
    {
        int x=0, y=0;

        public Elipse(int x)
        {
            this.x = x-150;
        }

        public void Drow_Elipse(Graphics graphics, Color color,int dx, int dy)
        {
            graphics.FillEllipse(new SolidBrush(color), new Rectangle(x - dx * 100, y + dy * 200, 100, 150));
        }
    }
}
