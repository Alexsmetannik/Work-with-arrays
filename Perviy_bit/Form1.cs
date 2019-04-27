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
            Random r = new Random();
            int[] mas = new int[10];
            for (int q = 0; q < mas.Length; q++)
            {
                mas[q] = r.Next(0, 55);
            }
            textBoxMas.Text = string.Join(" , ", mas);

            // Находим большее из N чисел
            int a = 0;
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


            // 3 массива: Часы-день; в будние дни кэф=1, сб=1,5, вс=2; в будни добавляется разница между количеством часов и 8
            double [] mas2 = new double [7];
            for (int w = 0; w < mas2.Length; w++)
            {
                mas2[w] = r.Next(0, 24);
            }
            richTextBoxmas2.Text = string.Join(Environment.NewLine, mas2);
            string [] mas3 = new string [7]{"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            richTextBoxmas3.Text = string.Join(Environment.NewLine, mas3);
            double [] mas4 = new double[7];
            for (int y = 0; y < 7; y++)
            {
                if (y == 5)
                {
                    mas4[y] = mas2[5] * 1.5;
                }
                    if (y == 6)
                    {
                        mas4[y] = mas2[6] * 2;
                    }    
                else mas4[y] = mas2[y] + (mas2[y] - 8);
            }
            richTextBoxmas4.Text = string.Join(Environment.NewLine, mas4);
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


        // Обработчик кнопки
        private void buttonWord_Click(object sender, EventArgs e)
        {
            Button();
        }
    }
}
