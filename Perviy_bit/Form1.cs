using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perviy_bit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация массива
            int a = 0;
            Random r = new Random();
            int[] mas = new int[10];
            for (int q = 0; q < mas.Length; q++)
            {
                mas[q] = r.Next(-25, 25);
            }
            textBoxMas.Text = string.Join(" , ", mas);

            // Находим большее из N чисел
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] >= a)
                {
                    a = mas[i];
                }
            }
            textBoxBol.Text = Convert.ToString(a);

            // Сортируем массив по убыванию
            for (int j = 0; j < mas.Length; j++)
            {
                int c = 0;
                while (j > 0 && mas[j] > mas[j - 1])
                {
                    c = mas[j];
                    mas[j] = mas[j - 1];
                    mas[j - 1] = c;
                    j--;
                }
            }
            textBoxSort.Text = string.Join(" , ", mas);

            // Среднее по модулю
            int sum = 0;
            for (int n = 0; n < mas.Length; n++)
            {
                sum += mas[n];
            }
            int sredny = sum / 10;
            textBoxSR.Text = Convert.ToString(sredny);
        }

        //Разделить строку на слова
        public void Button()
        {
            if (textBoxFIO != null)
            {
                string FIO = textBoxFIO.Text;
                string[] words = FIO.Split(' ');
                foreach (string word in words)
                {
                    richTextBox1.Text += word + Environment.NewLine;
                }
                               
            }  
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            Button();
        }
    }
}
