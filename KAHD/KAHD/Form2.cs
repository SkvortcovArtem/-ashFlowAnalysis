using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAHD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void eraseTestBoxes()
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
        }

        private void fillTextBoxes()
        {
            txt1.Text = "1220948"; //Пч
            txt2.Text = "162421833"; // ДСср
            txt3.Text = "517233807"; // ПДП
            txt4.Text = "514976471"; //ОДП
            txt5.Text = "59857480"; //ОДПТ по тек деят
            txt6.Text = "93819993"; //Q выручка
        }

        private void btErase_Click(object sender, EventArgs e)
        {
            eraseTestBoxes();
        }

        private void btFill_Click(object sender, EventArgs e)
        {
            fillTextBoxes();
        }

        private void keyCheck(KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 44 && number != 8 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            string[] enterStrings = { txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text };
            double[] enterData = new double[enterStrings.Length];
            double[] exitData = new double[6];
            try
            {
                for (int i = 0; i < enterData.Length; i++)
                {
                    enterData[i] = Convert.ToDouble(enterStrings[i]);
                }
                exitData[0] = enterData[0] / enterData[1];
                exitData[1] = enterData[0] / enterData[2];
                exitData[2] = enterData[0] / enterData[3];
                exitData[3] = enterData[0] / enterData[4];
                exitData[4] = enterData[5] / enterData[1];
                exitData[5] = (enterData[1] * 365) / enterData[5];
                txtExit1.Text = Math.Round(exitData[0], 4).ToString();
                txtExit2.Text = Math.Round(exitData[1], 4).ToString();
                txtExit3.Text = Math.Round(exitData[2], 4).ToString();
                txtExit4.Text = Math.Round(exitData[3], 4).ToString();
                txtExit5.Text = Math.Round(exitData[4], 2).ToString();
                txtExit6.Text = Math.Round(exitData[5], 2).ToString();
                
            }
            catch
            {
                MessageBox.Show("Входные данные введены с ошибкой",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }                 
        }

        private void оценкаДостаточностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void оценкаСинхронностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
