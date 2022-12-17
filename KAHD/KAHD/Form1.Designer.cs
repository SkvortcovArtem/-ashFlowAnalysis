
namespace KAHD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btFill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оценкаЭффективностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEnter = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExit6 = new System.Windows.Forms.TextBox();
            this.txtExit5 = new System.Windows.Forms.TextBox();
            this.txtExit4 = new System.Windows.Forms.TextBox();
            this.txtExit3 = new System.Windows.Forms.TextBox();
            this.txtExit2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtExit1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btErase = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lBoxResult = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panelEnter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFill
            // 
            this.btFill.Location = new System.Drawing.Point(12, 320);
            this.btFill.Name = "btFill";
            this.btFill.Size = new System.Drawing.Size(106, 37);
            this.btFill.TabIndex = 0;
            this.btFill.Text = "Контрольный пример";
            this.btFill.UseVisualStyleBackColor = true;
            this.btFill.Click += new System.EventHandler(this.btFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Входные данные";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(205, 3);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(137, 20);
            this.txt1.TabIndex = 2;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оценкаЭффективностиToolStripMenuItem,
            this.оценкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оценкаЭффективностиToolStripMenuItem
            // 
            this.оценкаЭффективностиToolStripMenuItem.Name = "оценкаЭффективностиToolStripMenuItem";
            this.оценкаЭффективностиToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.оценкаЭффективностиToolStripMenuItem.Text = "Оценка эффективности";
            this.оценкаЭффективностиToolStripMenuItem.Click += new System.EventHandler(this.оценкаЭффективностиToolStripMenuItem_Click);
            // 
            // оценкаToolStripMenuItem
            // 
            this.оценкаToolStripMenuItem.Name = "оценкаToolStripMenuItem";
            this.оценкаToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.оценкаToolStripMenuItem.Text = "Оценка синхронности";
            this.оценкаToolStripMenuItem.Click += new System.EventHandler(this.оценкаToolStripMenuItem_Click);
            // 
            // panelEnter
            // 
            this.panelEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEnter.Controls.Add(this.label11);
            this.panelEnter.Controls.Add(this.label10);
            this.panelEnter.Controls.Add(this.label9);
            this.panelEnter.Controls.Add(this.label8);
            this.panelEnter.Controls.Add(this.label7);
            this.panelEnter.Controls.Add(this.label6);
            this.panelEnter.Controls.Add(this.label5);
            this.panelEnter.Controls.Add(this.label4);
            this.panelEnter.Controls.Add(this.label3);
            this.panelEnter.Controls.Add(this.label2);
            this.panelEnter.Controls.Add(this.txt10);
            this.panelEnter.Controls.Add(this.txt9);
            this.panelEnter.Controls.Add(this.txt8);
            this.panelEnter.Controls.Add(this.txt7);
            this.panelEnter.Controls.Add(this.txt6);
            this.panelEnter.Controls.Add(this.txt5);
            this.panelEnter.Controls.Add(this.txt4);
            this.panelEnter.Controls.Add(this.txt3);
            this.panelEnter.Controls.Add(this.txt2);
            this.panelEnter.Controls.Add(this.txt1);
            this.panelEnter.Location = new System.Drawing.Point(12, 47);
            this.panelEnter.Name = "panelEnter";
            this.panelEnter.Size = new System.Drawing.Size(347, 267);
            this.panelEnter.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "10. Чистый ден. поток по текущ. деят.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "9. Кракосрочные ден. обяз.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "8. Отрицательный ден. поток";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "7. Положительный ден. поток";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "6. Среднедневной остаток ден. ср.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "5. Средний остаток ден. ср.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "4. Оборотные активы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "3. Краткосрочные обязательства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2. Краткосрочные фин. вложения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1. Денежные средства";
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(205, 237);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(137, 20);
            this.txt10.TabIndex = 2;
            this.txt10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt10_KeyPress);
            // 
            // txt9
            // 
            this.txt9.Location = new System.Drawing.Point(205, 211);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(137, 20);
            this.txt9.TabIndex = 2;
            this.txt9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt9_KeyPress);
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(205, 185);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(137, 20);
            this.txt8.TabIndex = 2;
            this.txt8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt8_KeyPress);
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(205, 159);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(137, 20);
            this.txt7.TabIndex = 2;
            this.txt7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt7_KeyPress);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(205, 133);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(137, 20);
            this.txt6.TabIndex = 2;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt6_KeyPress);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(205, 107);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(137, 20);
            this.txt5.TabIndex = 2;
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt5_KeyPress);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(205, 81);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(137, 20);
            this.txt4.TabIndex = 2;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(205, 55);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(137, 20);
            this.txt3.TabIndex = 2;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(205, 29);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(137, 20);
            this.txt2.TabIndex = 2;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtExit6);
            this.panel1.Controls.Add(this.txtExit5);
            this.panel1.Controls.Add(this.txtExit4);
            this.panel1.Controls.Add(this.txtExit3);
            this.panel1.Controls.Add(this.txtExit2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtExit1);
            this.panel1.Location = new System.Drawing.Point(388, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 161);
            this.panel1.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(191, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "6. Коэф. генерирования чистого ДП";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(186, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "5. Коэф. соотн. полож. и отриц. ДП";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "4. Интервал самофинансирования";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "3. Коэф. текущей ликвидности";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "2. Коэф. мобильности";
            // 
            // txtExit6
            // 
            this.txtExit6.Enabled = false;
            this.txtExit6.Location = new System.Drawing.Point(205, 133);
            this.txtExit6.Name = "txtExit6";
            this.txtExit6.ReadOnly = true;
            this.txtExit6.Size = new System.Drawing.Size(137, 20);
            this.txtExit6.TabIndex = 6;
            // 
            // txtExit5
            // 
            this.txtExit5.Enabled = false;
            this.txtExit5.Location = new System.Drawing.Point(205, 107);
            this.txtExit5.Name = "txtExit5";
            this.txtExit5.ReadOnly = true;
            this.txtExit5.Size = new System.Drawing.Size(137, 20);
            this.txtExit5.TabIndex = 6;
            // 
            // txtExit4
            // 
            this.txtExit4.Enabled = false;
            this.txtExit4.Location = new System.Drawing.Point(205, 81);
            this.txtExit4.Name = "txtExit4";
            this.txtExit4.ReadOnly = true;
            this.txtExit4.Size = new System.Drawing.Size(137, 20);
            this.txtExit4.TabIndex = 6;
            // 
            // txtExit3
            // 
            this.txtExit3.Enabled = false;
            this.txtExit3.Location = new System.Drawing.Point(205, 55);
            this.txtExit3.Name = "txtExit3";
            this.txtExit3.ReadOnly = true;
            this.txtExit3.Size = new System.Drawing.Size(137, 20);
            this.txtExit3.TabIndex = 6;
            // 
            // txtExit2
            // 
            this.txtExit2.Enabled = false;
            this.txtExit2.Location = new System.Drawing.Point(205, 29);
            this.txtExit2.Name = "txtExit2";
            this.txtExit2.ReadOnly = true;
            this.txtExit2.Size = new System.Drawing.Size(137, 20);
            this.txtExit2.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "1. Коэф. абс. ликвидности";
            // 
            // txtExit1
            // 
            this.txtExit1.Enabled = false;
            this.txtExit1.Location = new System.Drawing.Point(205, 3);
            this.txtExit1.Name = "txtExit1";
            this.txtExit1.ReadOnly = true;
            this.txtExit1.Size = new System.Drawing.Size(137, 20);
            this.txtExit1.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(508, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Расчётные данные";
            // 
            // btErase
            // 
            this.btErase.Location = new System.Drawing.Point(253, 320);
            this.btErase.Name = "btErase";
            this.btErase.Size = new System.Drawing.Size(106, 37);
            this.btErase.TabIndex = 7;
            this.btErase.Text = "Очистить";
            this.btErase.UseVisualStyleBackColor = true;
            this.btErase.Click += new System.EventHandler(this.btErase_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(124, 320);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(123, 37);
            this.btCalculate.TabIndex = 8;
            this.btCalculate.Text = "Рассчитать";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lBoxResult
            // 
            this.lBoxResult.FormattingEnabled = true;
            this.lBoxResult.HorizontalScrollbar = true;
            this.lBoxResult.Location = new System.Drawing.Point(388, 223);
            this.lBoxResult.Name = "lBoxResult";
            this.lBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lBoxResult.Size = new System.Drawing.Size(347, 134);
            this.lBoxResult.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 370);
            this.Controls.Add(this.lBoxResult);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.btErase);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFill);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализ денежных потоков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SufficiencyForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelEnter.ResumeLayout(false);
            this.panelEnter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оценкаЭффективностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкаToolStripMenuItem;
        private System.Windows.Forms.Panel panelEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtExit2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtExit1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtExit6;
        private System.Windows.Forms.TextBox txtExit5;
        private System.Windows.Forms.TextBox txtExit4;
        private System.Windows.Forms.TextBox txtExit3;
        private System.Windows.Forms.Button btErase;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.ListBox lBoxResult;
    }
}

