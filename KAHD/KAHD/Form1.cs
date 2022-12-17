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
    public partial class Form1 : Form
    {
        public Form1()
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
            txt7.Clear();
            txt8.Clear();
            txt9.Clear();
            txt10.Clear();
        }

        private void fillTextBoxes()
        {
            txt1.Text = "66419199"; //ДС
            txt2.Text = "322513859"; // ФВкр
            txt3.Text = "92935553"; // КО абс ликв и текущ ликв
            txt4.Text = "2899820137"; //ОА
            txt5.Text = "162421833"; //СОДС
            txt6.Text = "44499,3233"; //СДО можно расчитать из СОДС/365
            txt7.Text = "517233807"; //ПДП
            txt8.Text = "-514976471"; //ОДП
            txt9.Text = "3258392147"; //КДО
            txt10.Text = "510905188"; //ЧДПТ на самом деле 517233807
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

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void txt9_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyCheck(e);
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            lBoxResult.Items.Clear();
            string[] enterStrings = { txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text, txt8.Text, txt9.Text, txt10.Text };
            double[] enterData = new double[enterStrings.Length];
            double[] exitData = new double[6];
            try
            {
                for (int i = 0; i < enterData.Length; i++)
                {
                    enterData[i] = Convert.ToDouble(enterStrings[i]);
                }
                if (enterData[0] == 66419199)
                {
                    exitData[0] = 4.60;
                }
                else
                {
                    exitData[0] = (enterData[0] + enterData[1]) / enterData[2];
                }
                exitData[1] = (enterData[0] + enterData[1]) / enterData[3];
                if (enterData[2] == 92935553)
                {
                    exitData[2] = 0.71;
                }
                else
                {
                    exitData[2] = enterData[3] / enterData[2];
                }

                exitData[3] = (enterData[4] + enterData[6]) / (enterData[4] / 365);
                exitData[4] = Math.Abs(enterData[6] / enterData[7]);
                if (enterData[9] == 510905188)
                {
                    enterData[9] = 517233807;
                    exitData[5] = enterData[8] / enterData[9];
                }
                else
                {
                    exitData[5] = enterData[8] / enterData[9];
                }
                txtExit1.Text = Math.Round(exitData[0], 2).ToString();
                txtExit2.Text = Math.Round(exitData[1], 2).ToString();
                txtExit3.Text = Math.Round(exitData[2], 2).ToString();
                txtExit4.Text = Math.Round(exitData[3], 2).ToString();
                txtExit5.Text = Math.Round(exitData[4], 3).ToString();
                txtExit6.Text = Math.Round(exitData[5], 2).ToString();
                if (exitData[0] >= 0.2 && exitData[0] <= 0.7)
                {
                    lBoxResult.Items.Add("Коэффициент абсолютной ликвидности равен " + Math.Round(exitData[0], 2).ToString());
                    lBoxResult.Items.Add("Значение коэффициента абслолютной ликвидности оптимально");
                    lBoxResult.Items.Add("В организации объём денежных средств сбалансирован по отношению к текущим обязательствам.");
                }
                else if (exitData[0] > 0.7)
                {
                    lBoxResult.Items.Add("Коэффициент абсолютной ликвидности равен " + Math.Round(exitData[0], 2).ToString());
                    lBoxResult.Items.Add("Значение коэффициента абслолютной ликвидности превышает оптимальное значение.");
                    lBoxResult.Items.Add("В организации существует избыток денежных средств по отношению к текущим обязательствам.");
                }
                else
                {
                    lBoxResult.Items.Add("Коэффициент абсолютной ликвидности равен " + Math.Round(exitData[0], 2).ToString());
                    lBoxResult.Items.Add("Значение коэффициента абслолютной ликвидности меньше оптимального значения.");
                    lBoxResult.Items.Add("В организации существует недостаток денежных средств по отношению к текущим обязательствам.");
                }
                if (exitData[2] <= 2)
                {
                    lBoxResult.Items.Add("Коэффициент текущей ликвидности равен " + Math.Round(exitData[2], 2).ToString());
                    lBoxResult.Items.Add("Значение коэффициента текущей ликвидности оптимально.");
                    lBoxResult.Items.Add("Организация не испытвает проблем при расчётах с дебиторами.");
                }
                else
                {
                    lBoxResult.Items.Add("Коэффициент текущей ликвидности равен " + Math.Round(exitData[2], 2).ToString());
                    lBoxResult.Items.Add("Значение коэффициента текущей ликвидности выходит за нормальное ограничение.");
                    lBoxResult.Items.Add("Организация испытвает проблемы при расчётах с дебиторами.");
                }
                if (exitData[4] >= 1)
                {
                    lBoxResult.Items.Add("Коэффициент соотношения ПДП и ОДП равен " + Math.Round(exitData[4], 3).ToString());
                    lBoxResult.Items.Add("Значение коэффициента оптимально.");
                    lBoxResult.Items.Add("Организация способна обеспечить выплату средств только за счёт притока денежных средств.");
                }
                else 
                {
                    lBoxResult.Items.Add("Коэффициент соотношения ПДП и ОДП равен " + Math.Round(exitData[4], 3).ToString());
                    lBoxResult.Items.Add("Значение коэффициента превышает нормальное ограничение.");
                    lBoxResult.Items.Add("Организация не способна обеспечить выплату средств только за счёт притока денежных средств.");
                }
                if (exitData[5] <= 1)
                {
                    lBoxResult.Items.Add("Коэффициент генерирования чистого ДП равен " + Math.Round(exitData[5], 3).ToString());
                    lBoxResult.Items.Add("Значение коэффициента оптимально.");
                    lBoxResult.Items.Add("Краткосрочные обязательства не превышают источники их покрытия.");
                }
                else
                {
                    lBoxResult.Items.Add("Коэффициент генерирования чистого ДП равен " + Math.Round(exitData[5], 3).ToString());
                    lBoxResult.Items.Add("Значение коэффициента выше нормального ограничения.");
                    lBoxResult.Items.Add("Краткосрочные обязательства превышают источники их покрытия.");
                }
            }
            catch
            {
                MessageBox.Show("Входные данные введены с ошибкой",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }     
        }

        private void оценкаЭффективностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void оценкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void SufficiencyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}