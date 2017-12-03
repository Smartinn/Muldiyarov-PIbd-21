using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormKitchen : Form
    {

        private egg[] eggs;
        private salt salt;
        private milk milk;
        private maslo maslo;
        private knife knife;
        private skovoroda skov;
        private stove stove;
        private bool ambrella = false;
        private bool ambrella2 = false;

        public FormKitchen()
        {
            InitializeComponent();
        }

        private void FormKitchen_Load(object sender, EventArgs e)
        {
            knife = new knife();
            skov = new skovoroda();
            stove = new stove();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ambrella2 != false)
            {
                maslo = new maslo();
                maslo.Count = Convert.ToInt32(numericUpDown4.Value);
                if (maslo.Count > 0)
                {
                    skov.AddMaslo(maslo);
                    MessageBox.Show("масло+", "кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("чёт трабла масло -", "там трабла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else MessageBox.Show("сковороду поставь", "там трабла", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ambrella2 != false)
            {
                salt = new salt();
            salt.Count = Convert.ToInt32(numericUpDown3.Value);
            if (salt.Count > 0)
            {
                skov.AddSalt(salt);
                MessageBox.Show("соль+", "кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("чёт трабла соль -", "там трабла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }else MessageBox.Show("сковороду поставь", "там трабла", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = checkBox1.Checked;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            stove.Skov = skov;
            MessageBox.Show("Тут короч на плите", "ЕЕЕЕ-БОЙЙ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (ambrella2 != false)
            {
                milk = new milk();
            milk.Count = Convert.ToInt32(numericUpDown2.Value);
            if (milk.Count > 0)
            {
                skov.AddMilk(milk);
                MessageBox.Show("молоко+", "кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("чёт трабла молоко -", "там трабла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }else MessageBox.Show("сковороду поставь", "там трабла", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (ambrella2 != false)
            {
                if (numericUpDown1.Value > 0 && ambrella== false)
            {
                eggs = new egg[Convert.ToInt32(numericUpDown1.Value)];
                skov.Init(Convert.ToInt32(numericUpDown1.Value));
                for (int i = 0; i < eggs.Length; i++)
                {
                    eggs[i] = new egg();
                }
                for (int i = 0; i < eggs.Length; ++i)
                {
                    eggs[i].Have_skin = true;
                }
                ambrella = true;
            }
            if (eggs == null)
            {
                MessageBox.Show("чё там по яйцам?", "там трабла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Have_skin)
                {
                    MessageBox.Show("а яица кто колоть будет??", "там трабла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                skov.AddEggs(eggs[i]);
            }
            MessageBox.Show("яица+", "еебой", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("сковороду поставь", "там трабла", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (eggs == null)
                {
                    MessageBox.Show("яиц нет", "но ты держись", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            for (int i = 0; i < eggs.Length; ++i)
            {
                    knife.Break(eggs[i]);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ambrella2 = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && milk != null && eggs != null && salt != null && maslo != null)
            {
                stove.Skov = skov;
                stove.Cook();
                if (skov.IsReady())
                {
                    MessageBox.Show("Готово", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (checkBox1.Checked == false) { MessageBox.Show("плиту вруби!", "но ты держись", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else MessageBox.Show("Ретард! ты чёт, забыл добавить", "но ты держись", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!skov.IsReady())
            {
                MessageBox.Show("НЕГотово", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else Close();
        }
    }
}
