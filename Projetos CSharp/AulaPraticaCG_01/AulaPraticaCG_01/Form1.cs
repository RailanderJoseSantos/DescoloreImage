using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaPraticaCG_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Converter_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox_catioro.BackgroundImage);
            for( int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color corPixel = bmp.GetPixel(x, y);
                    var cinza = (corPixel.R + corPixel.G + corPixel.B) / 3;
                    corPixel = Color.FromArgb(cinza, cinza, cinza);
                    bmp.SetPixel(x, y, corPixel);
                   
                }
            }
            pictureBox_catioro2.BackgroundImage = bmp;
        }

        private void pictureBox_catioro_Click(object sender, EventArgs e)
        {

        }
    }
}
