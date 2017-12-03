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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {   
                color = cd.Color;
                button1.BackColor = color;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                button2.BackColor = dopColor;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Gitara(maxSound, maxCountMusic, weight, countstrun, color);
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.draw(gr);
                pictureBox2.Image = bmp;
            }
        }

        private bool checkFields()
        {
            if (!int.TryParse(textBox1.Text, out maxSound))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out maxCountMusic))
            {
                return false;
            }
            if (!int.TryParse(textBox3.Text, out powerUsilit))
            {
                return false;
            }
            if (!int.TryParse(textBox4.Text, out weight))
            {
                return false;
            }
            if (!int.TryParse(textBox5.Text, out countstrun))
            {
                return false;
            }
            return true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Sounds(maxSound, maxCountMusic, weight, countstrun, powerUsilit,color,dopColor);
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.draw(gr);
                pictureBox2.Image = bmp;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.makesound(gr);
                pictureBox2.Image = bmp;
                pictureBox2.Refresh();
            }
        }
    }
}
