using System;
using System.Drawing;
using System.Windows.Forms;

namespace Consider1
{
    public partial class Form_Space : System.Windows.Forms.Form
    {
        Graphics graphics;
        Elipse elipse;
        int k = 1,n=0;

        public Form_Space()
        {
            InitializeComponent();
            elipse = new Elipse(this.Size.Width);
            timer.Start();
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (k == 10)
            { n++; k = 0; }
            else
                k++;

            Invalidate();

            if (n == 2) timer.Stop();
        }

        public void Drow(object s, PaintEventArgs e)
        {
            graphics = e.Graphics;
            int i = 0;
            for(int j=0;j<=n;j++)
            {
                for (i = 0; i < k; i++)
                {
                    elipse.Drow_Elipse(graphics, Color.Yellow, i, 0);
                }
                if(j!=0) elipse.Drow_Elipse(graphics, Color.Black, j-1, 1);
            }
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Drow(sender, e);
        }
    }
}
