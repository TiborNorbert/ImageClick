using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageClick
{
    public partial class ImageStorage : Form
    {
        int Sorokszama = 2;
        int Oszlopokszama = 2;
        int ImageSize = 280;
        public ImageStorage()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Sorokszama; i++)
            {
                for (int j = 0; j < Oszlopokszama; j++)
                {
                    PictureBox picture= new PictureBox();
                    picture.SetBounds(j*ImageSize,i*ImageSize,ImageSize,ImageSize);
                    picture.Image = Image.FromFile("C:\\Users\\cisco\\Pictures\\monkey.jfif");
                    picture.Click += (o, ev) =>
                        {
                            PictureBox gomb = (PictureBox)o;
                            gomb.BackgroundImage= picture.Image;
                        };
                    imagestorgae.Controls.Add(picture);
                }
            }
        }
    }
}
