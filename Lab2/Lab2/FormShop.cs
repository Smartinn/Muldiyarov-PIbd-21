using NLog;
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
    public partial class FormShop : Form
    {
        Shop shoping;

        FormSelect form;
        private Logger log;
        public FormShop()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
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

        private void addGit(Interface git)
        {
            if (git != null)
            {
                try
                {
                    int place = shoping.PutGitInShoping(git);
                    if (place > -1)
                    {
                        DrawShop();
                        MessageBox.Show("Ваше место " + place);
                        log.Info("Добавили Гитару на место " + place);
                    }
                }
                catch (ShopOverFlow ex)
                {
                    MessageBox.Show(ex.Message, "Гитару поставить не удалось", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Warn("Ошибка добавления гитары");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    try
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
                    }
                    catch (ShopIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Warn("Ошибка ввода номера гитары");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            shoping.LevelDown();
            listBox1.SelectedIndex = shoping.getCurrentLevel;
            DrawShop();
            log.Info("Спустились на уровень ниже, сечас мы на " + shoping.getCurrentLevel);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            shoping.LevelUp();
            listBox1.SelectedIndex = shoping.getCurrentLevel;
            DrawShop();
            log.Info("Поднялись на уровень выше, сечас мы на " + shoping.getCurrentLevel);
        }

        private void buttonSetGit_Click(object sender, EventArgs e)
        {
            form = new FormSelect();
            form.AddEvent(addGit);
            form.ShowDialog();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (shoping.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (shoping.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DrawShop();
            }
        }

    }
}
