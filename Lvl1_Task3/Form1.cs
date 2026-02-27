using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lvl1_Task3
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int[] array = new int[15];
            listBoxArray.Items.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 51);
                listBoxArray.Items.Add($"array[{i}] = {array[i]}");
            }

            CountEvenOdd(array);
        }

        private void CountEvenOdd(int[] array)
        {
            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                    listBoxEven.Items.Add(num);
                }
                else
                {
                    oddCount++;
                    listBoxOdd.Items.Add(num);
                }
            }

            lblEvenCount.Text = $"Четных: {evenCount}";
            lblOddCount.Text = $"Нечетных: {oddCount}";
            lblTotal.Text = $"Всего чисел: {array.Length}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxArray.Items.Clear();
            listBoxEven.Items.Clear();
            listBoxOdd.Items.Clear();
            lblEvenCount.Text = "Четных:";
            lblOddCount.Text = "Нечетных:";
            lblTotal.Text = "Всего чисел:";
        }
    }
}
