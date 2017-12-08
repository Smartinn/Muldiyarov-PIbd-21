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
        Shop shoping;

        public Form1()
        {
            InitializeComponent();
            shoping = new Shop(5);
            for(int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("Уровень " + i);
            }
            listBox1.SelectedIndex = shoping.getCurrentLevel;
            DrawShop();
        }

        private void DrawShop()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                shoping.Draw(gr);
                pictureBox2.Image = bmp;
            }
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
                int place = shoping.PutGitInShoping(shlak);
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
                    int place = shoping.PutGitInShoping(shlak);
                    DrawShop();
                    MessageBox.Show("Вашеместо: " + place);
                 }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex > -1)
            {
                //string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    Interface git = shoping.GetGitInShoping(Convert.ToInt32(maskedTextBox1.Text));
                    if (git != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        git.setPos(5, 15);
                        git.draw(gr);
                        pictureBox3.Image = bmp;
                        DrawShop();
                    }
                    else
                    {
                        MessageBox.Show("Извинте, на этом месте нет");
                    }
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            shoping.LevelDown();
            listBox1.SelectedIndex = shoping.getCurrentLevel;
            DrawShop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shoping.LevelUp();
            listBox1.SelectedIndex = shoping.getCurrentLevel;
            DrawShop();
        }
    }
}
