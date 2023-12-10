using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MorozAD.Sprint6.Task5.V27.Lib;

namespace Tyuiu.MorozAD.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V27.txt";

        private void DoneClick_MAD(object sender, EventArgs e)
        {
            try
            {
                dataGridViewRes_MAD.ColumnCount = 2;
                dataGridViewRes_MAD.Columns[0].Width = 20;
                dataGridViewRes_MAD.Columns[1].Width = 50;

                this.chartFunc_MAD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_MAD.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunc_MAD.Series[0].Points.Clear();
                dataGridViewRes_MAD.Rows.Clear();
                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewRes_MAD.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartFunc_MAD.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Help_MADClick(object sender, EventArgs e)
        {
            MessageBox.Show("Task5 выполнил студент группы СМАРТб,-23-1 Мороз Артём Дмитриевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenFileClick_MAD(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void dataGridViewRes_MAD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
