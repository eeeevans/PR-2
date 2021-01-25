using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_8
{
    public class Rez
    {

        // Расчёт
        public static void Calculate(out double rez, DataGridView table1)
        {
            rez = 0;
            int sum = 0;
            for (int i = 0; i < table1.ColumnCount; i++)
            {
                if (Convert.ToInt32(table1[i, 0].Value) < 3) sum += Convert.ToInt32(table1[i, 0].Value);
            }
            rez = Math.Cos(sum);
        }
    


    }
}
