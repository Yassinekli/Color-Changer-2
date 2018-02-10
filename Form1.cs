using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int A = 255, R = 255, G = 0, B = 0;
        public Form1()
        {
            InitializeComponent();
            Color_Controler.Value = 255;
            Color color = Color.FromArgb(A, R, G, B);
            richTextBox1.BackColor = color;
        }

        private void Color_Controler_Scroll(object sender, EventArgs e)
        {
            if (Color_Controler.Value < 255)
            {
                R = Color_Controler.Value;
                G = 0;
                B = 0;
                
                Color color = Color.FromArgb(A, R, G, B);
                richTextBox1.BackColor = color;
            }

            if (Color_Controler.Value > 255 && Color_Controler.Value < 510)
            {
                R = 255;
                G = Color_Controler.Value - 255;
                B = 0;
                
                Color color = Color.FromArgb(A, R, G, B);
                richTextBox1.BackColor = color;
            }

            if (Color_Controler.Value > 510 && Color_Controler.Value < 765 )
            {
                R = 765-Color_Controler.Value;
                //Condition****************************
                if(G > 126)
                G = 764 - Color_Controler.Value;

                if (G == 0)
                    G = 125;

                B = 0;
                
                Color color = Color.FromArgb(A, R, G, B);
                richTextBox1.BackColor = color;
            }

            if (Color_Controler.Value > 765 && Color_Controler.Value < 1020)
            {
                R = 0;

                if (Color_Controler.Value > 765 && Color_Controler.Value < 892)
                    G = 893 - Color_Controler.Value;
                
                B = Color_Controler.Value - 765;

                Color color = Color.FromArgb(A, R, G, B);
                richTextBox1.BackColor = color;
            }

            if (Color_Controler.Value > 1020 && Color_Controler.Value < 1275)
            {
                R = Color_Controler.Value - 1020;
                G = 0;
                B = 255;

                Color color = Color.FromArgb(A, R, G, B);
                richTextBox1.BackColor = color;
            }
            if (Color_Controler.Value > 1275 && Color_Controler.Value < 1530)
            {
                R = 255;
                G = Color_Controler.Value - 1275;
                B = 255;

                Color color = Color.FromArgb(A, R, G, B);
                richTextBox1.BackColor = color;
            }
        }

    }
}
