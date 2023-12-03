using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MorozAD.Sprint6.Task3.V16.Lib;

namespace Tyuiu.MorozAD.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { {14, 1, -3, 1, 10 },
                                         {7, -3,  5, -4, 0  },
                                         {-10, -19, -18, -9, 19 },
                                         {-2, -2, -16, -2, -17 },
                                         {-16, 9, 5, -10, 16 } };


        private void buttonDoneClick_MAD(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewRes_MAD.ColumnCount = columns;
            dataGridViewRes_MAD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes_MAD.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_MAD.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
            int rows1 = matrix.GetUpperBound(0) + 1;
            int columns1 = matrix.Length / rows1;

            dataGridViewAns_MAD.ColumnCount = columns1;
            dataGridViewAns_MAD.RowCount = rows1;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewAns_MAD.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewAns_MAD.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelpCLick_MAD(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Мороз Артём Дмитриевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_MAD_CLick(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewAns_MAD.ColumnCount = columns;
            dataGridViewAns_MAD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewAns_MAD.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewAns_MAD.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }
    }
}
