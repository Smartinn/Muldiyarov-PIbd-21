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
    public partial class FormSelect : Form
    {
        Interface git = null;

        public Interface getGit { get { return git; } }

        private void DrawGit()
        {
            if (git != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxGit.Width, pictureBoxGit.Height);
                Graphics gr = Graphics.FromImage(bmp);
                git.setPos(40, 10);
                git.draw(gr);
                pictureBoxGit.Image = bmp;
            }
        }

        private event myDel eventAddGit;

        public void AddEvent(myDel ev)
        {
            if (eventAddGit == null)
            {
                eventAddGit = new myDel(ev);
            }
            else
            {
                eventAddGit += ev;
            }
        }

        private void LabelGit_MouseDown(object sender, MouseEventArgs e)
        {
            LabelGit.DoDragDrop(LabelGit.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void LabelGitElect_MouseDown(object sender, MouseEventArgs e)
        {
            LabelGitElect.DoDragDrop(LabelGitElect.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void LabelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void LabelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (git != null)
            {
                git.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawGit();
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {     
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        public FormSelect()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelFray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { git = null; Close(); };
        }

        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (git != null)
            {
                if (git is Sounds)
                {
                    (git as Sounds).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawGit();
                }
            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (eventAddGit != null)
            {
                eventAddGit(git);
            }
            Close();

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Гитара":
                    git = new Gitara(30, 2, 1500, 3, Color.White);
                    break;
                case "Электрогитара":
                    git = new Sounds(30, 2, 1500, 3, 2, Color.White, Color.Red);
                    break;
            }
            DrawGit();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

    }
}
