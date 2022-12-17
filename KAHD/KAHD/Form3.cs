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
    public partial class Form3 : Form
    {
        public Form3()
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
            txt1.Text = "819912217"; //Пч
            txt2.Text = "672847437"; // ДСср
            txt3.Text = "517233807"; // ПДП
            txt4.Text = "-800839207"; //ОДП
            txt5.Text = "-743515475"; //ОДПТ по тек деят
            txt6.Text = "-514976471"; //Q выручка
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
            lBoxResult.Items.Clear();
            string[] enterStrings = { txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text };
            double[] enterData = new double[enterStrings.Length];
            double[] exitData = new double[3];
            try
            {
                
                for (int i = 0; i < enterData.Length; i++)
                {
                    enterData[i] = Convert.ToDouble(enterStrings[i]);
                }
                double midincX1 = (enterData[0] + enterData[1]) / 2;
                double midincX2 = (enterData[1] + enterData[2]) / 2;
                double raznX1 = enterData[1] - midincX1;
                double raznX2 = enterData[2] - midincX2;
                double sqrX1 = Math.Pow(raznX1, 2);
                double sqrX2 = Math.Pow(raznX2, 2);
                double midsqr_poloj = Math.Sqrt((0.5) * (sqrX1 + sqrX2));
                double midincY1 = (enterData[3] + enterData[4]) / 2;
                double midincY2 = (enterData[4] + enterData[5]) / 2;
                double raznY1 = enterData[4] - midincY1;
                double raznY2 = enterData[5] - midincY2;
                double sqrY1 = Math.Pow(raznY1, 2);
                double sqrY2 = Math.Pow(raznY2, 2);
                double midsqr_otric = Math.Sqrt((0.5) * (sqrY1 + sqrY2));
                double raz1 = raznX1 * raznY1;
                double raz2 = raznX2 * raznY2;
                double final = Math.Sqrt((0.5) * Math.Abs(raz1 + raz2)) / (midsqr_poloj + midsqr_otric);
                exitData[0] = midsqr_poloj;
                exitData[1] = midsqr_otric;
                exitData[2] = final;
                txtExit1.Text = Math.Round(exitData[0], 4).ToString();
                txtExit2.Text = Math.Round(exitData[1], 4).ToString();
                txtExit3.Text = Math.Round(exitData[2], 4).ToString();
                string result;
                if (final > 0.5)
                {
                    result = "больше 0.5, значит разброс положиетльных и отрицаетльных потоков незначителен.";
                }
                else
                {
                    result = "меньше 0.5, значит разброс положительных и отрицаетльных потоков существеннен.";
                }
                lBoxResult.Items.Add("Коэффициент корреляции положительных и отрицательных денежных потоков равен " +
                   Math.Round(exitData[2], 4).ToString() + " .");
                lBoxResult.Items.Add("Коэффициент " + result);
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

        private void оценкаДостаточностиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
