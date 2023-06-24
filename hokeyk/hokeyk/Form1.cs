using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hokeyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerx= 5;
        int yery = 5;
        int can = 3;
        int yenix = 100;
        int yeniy = 100;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
        }
        public void carpma()
        {
            if (topu.Top<= label1.Bottom)
            {
                yery = yery * -1;
            }
            if (topu.Bottom >= kontrol.Top && topu.Left >= kontrol.Left && topu.Right <= kontrol.Right)
            {
                yery = yery * -1;
            }
            else if (topu.Right >= label3.Left)
            {
                yerx = yerx * -1;
            }
            else if (topu.Left <= label2.Right)
            {
                yerx = yerx * -1;
            }
           
        }
        private void yanma(object sender, EventArgs e)
        {
            if (topu.Top >= label6.Bottom)
            {
                if (can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandınız. Kalan Canınız:" + can.ToString());
                    Form1_Load(sender, e);

                }
                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun Bitti", "", MessageBoxButtons.OK);
                }
                baslangıc();
                label5.Text = "";
                label5.Text = can.ToString();

            }
        }
        int sayac;
        public void baslangıc()
        {
            topu.Location = new Point(256, 156);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
             
            carpma();
            yanma(sender, e);
            sayac++;
            label8.Text = "";
            label8.Text = sayac.ToString();
           
            topu.Location = new Point(topu.Location.X + yerx, topu.Location.Y + yery);
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            timer1.Enabled = true;
          
        }
    }
}
