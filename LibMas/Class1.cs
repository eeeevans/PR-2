using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibMas
{
    public class Massiv
    {
        // Сохранения массива в документ
        public static void Save(DataGridView table)
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.WriteLine(table.ColumnCount);
                for (int i = 0; i < table.ColumnCount; i++)
                {
                    file.WriteLine(table[i, 0].Value);
                }
                file.Close();
            }
        }

        // Открытие документа с массивом

        public static void Open(DataGridView table)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            open.FilterIndex = 2;
            open.Title = "Сохранение таблицы";
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);
                table.ColumnCount = Convert.ToInt32(file.ReadLine());
                for (int i = 0; i < table.ColumnCount; i++)
                {
                    table[i, 0].Value = Convert.ToInt32(file.ReadLine());
                }
                file.Close();
            }
        }

        // Заполнение массива

        public static void Fill(DataGridView table)
        {
            Random rnd = new Random();

            for (int i = 0; i < table.ColumnCount; i++)
            {
                table[i, 0].Value = rnd.Next(0, 10);
            }
        }

        // Очистка массива

        public static void Clear(DataGridView table)
        {
            table.ColumnCount = 5;
            table.RowCount = 1;
            for (int i = 0; i < table.ColumnCount; i++)
            {
                table[i, 0].Value = " ";
            }
        }
    }
}
