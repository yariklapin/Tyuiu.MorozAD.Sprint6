using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MorozAD.Sprint6.Task2.V5.Lib;

namespace Tyuiu.MorozAD.Sprint6.Task2.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataService ds = new DataService();
        private void buttonDone_MAD_Click(object sender, EventArgs e)
        {

            try
            {
                int startStep = Convert.ToInt32(textBoxStart_MAD.Text);
                int stopStep = Convert.ToInt32(textBoxStop_MAD.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunc_MAD.Titles.Add("График функции");
                this.chartFunc_MAD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_MAD.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunc_MAD.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunc_MAD.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task2 выполнил студент группы СМАРТб,-23-1 Мороз Артём Дмитриевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
