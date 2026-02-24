using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lvl1_Task3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnGenerate;
        private Button btnClear;
        private ListBox listBoxArray;
        private ListBox listBoxEven;
        private ListBox listBoxOdd;
        private Label lblEvenCount;
        private Label lblOddCount;
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGenerate = new Button();
            this.btnClear = new Button();
            this.listBoxArray = new ListBox();
            this.listBoxEven = new ListBox();
            this.listBoxOdd = new ListBox();
            this.lblEvenCount = new Label();
            this.lblOddCount = new Label();
            this.lblTotal = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(283, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подсчет четных и нечетных";

            this.btnGenerate.Location = new Point(15, 40);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new Size(100, 30);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new EventHandler(this.btnGenerate_Click);

            this.btnClear.Location = new Point(130, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(100, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            this.label2.AutoSize = true;
            this.label2.Location = new Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Исходный массив:";

            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.Location = new Point(15, 100);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new Size(200, 160);
            this.listBoxArray.TabIndex = 4;

            this.label3.AutoSize = true;
            this.label3.ForeColor = Color.Blue;
            this.label3.Location = new Point(230, 80);
            this.label3.Name = "label3";
            this.label3.Size = new Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Четные:";

            this.listBoxEven.FormattingEnabled = true;
            this.listBoxEven.Location = new Point(230, 100);
            this.listBoxEven.Name = "listBoxEven";
            this.listBoxEven.Size = new Size(100, 160);
            this.listBoxEven.TabIndex = 6;

            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.Red;
            this.label4.Location = new Point(345, 80);
            this.label4.Name = "label4";
            this.label4.Size = new Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Нечетные:";

            this.listBoxOdd.FormattingEnabled = true;
            this.listBoxOdd.Location = new Point(345, 100);
            this.listBoxOdd.Name = "listBoxOdd";
            this.listBoxOdd.Size = new Size(100, 160);
            this.listBoxOdd.TabIndex = 8;

            this.lblEvenCount.AutoSize = true;
            this.lblEvenCount.ForeColor = Color.Blue;
            this.lblEvenCount.Location = new Point(230, 270);
            this.lblEvenCount.Name = "lblEvenCount";
            this.lblEvenCount.Size = new Size(46, 13);
            this.lblEvenCount.TabIndex = 9;
            this.lblEvenCount.Text = "Четных:";

            this.lblOddCount.AutoSize = true;
            this.lblOddCount.ForeColor = Color.Red;
            this.lblOddCount.Location = new Point(345, 270);
            this.lblOddCount.Name = "lblOddCount";
            this.lblOddCount.Size = new Size(54, 13);
            this.lblOddCount.TabIndex = 10;
            this.lblOddCount.Text = "Нечетных:";

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            this.lblTotal.Location = new Point(15, 270);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(74, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Всего чисел:";

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(464, 311);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOddCount);
            this.Controls.Add(this.lblEvenCount);
            this.Controls.Add(this.listBoxOdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxEven);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Подсчет четных и нечетных";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


