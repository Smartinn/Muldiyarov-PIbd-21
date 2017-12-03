using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int maxSound;
        int maxCountMusic;
        int weight;
        int powerUsilit;
        int countstrun;

        ClassShop <Interface> shop;
        private Interface inter;

        public Form1()
        {
            InitializeComponent();
            color = Color.White;
            dopColor = Color.Yellow;
            maxSound = 150;
            maxCountMusic = 4;
            weight = 1500;
            powerUsilit = 1;
            countstrun = 3;
            button1.BackColor = color;
            button2.BackColor = dopColor;
            shop = new ClassShop<Interface>(25, null);
            DrawShop();
        }

        private void DrawShop()
        {
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics gr = Graphics.FromImage(bmp);
            shop.Draw(gr, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = bmp;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var shlak = new Gitara(30, 2, 1500, 3,dialog.Color);
                int place = shop + shlak ;
                DrawShop();
                MessageBox.Show("Вашеместо: " + place);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var shlak= new Sounds(30, 2, 1500, 3,2,dialog.Color, dialogDop.Color);
                    int place = shop + shlak;
                    DrawShop();
                    MessageBox.Show("Вашеместо: " + place);
                 }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                Interface shlak = shop - Convert.ToInt32(maskedTextBox1.Text);
                if (shlak != null)
                {
                    Bitmap bmp = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    shlak.setPos(15, 40);
                    shlak.draw(gr);
                    pictureBox3.Image = bmp;
                    DrawShop();
                }
                else
                {
                    MessageBox.Show("Здесь пусто");
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
