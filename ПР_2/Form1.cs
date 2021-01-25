using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMas;
using Lib_8;
using System.IO;

namespace ПР_2
{
    public partial class Form1 : Form
    {
        double rez;
        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка о программе

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №2 - Разработка и оформление алгоритма работы с одномерным массивом\n" +
                "Болдаков Никита Евгеньевич\n" +
                "Группа ИСП-31\n" +
                "Вариант №8\n" +
                "Ввести n целых чисел. Вычислить косинус (cos) суммы чисел < 3. Результат" +
                "вывести на экран."); 
        }

        // Кнопка выход

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close(); // Выход из программы
        }

        // Кнопка сохранить

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Massiv.Save(table1);
        }

        // Кнопка открыть

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Massiv.Open(table1);
        }

        // Кнопка заполнить

        private void fill_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Massiv.Fill(table1);
        }

        // Кнопка расчитать

        private void calculate_Click(object sender, EventArgs e)
        {
            Rez.Calculate(out rez, table1);
            textBox1.Text = Convert.ToString(rez);
        }

        // Кнопка очистить

        private void clear_Click(object sender, EventArgs e)
        {
            Massiv.Clear(table1);
        }

        // Увелечение столбцов
        private void Form1_Load(object sender, EventArgs e)
        {
            table1.ColumnCount = 5;
            table1.RowCount = 1;
        }

        // Число столбцов

        private void columns_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            table1.ColumnCount = Convert.ToInt32(columns.Value);
        }

        private void table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
