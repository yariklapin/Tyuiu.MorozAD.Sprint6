using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MorozAD.Sprint6.Task4.V13.Lib;

namespace Tyuiu.MorozAD.Sprint6.Task4.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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

                //this.chartFunc_MAD.Titles.Add("График функции");
                this.chartFunc_MAD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_MAD.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxRes_MAD.Text = "";
                chartFunc_MAD.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {


                    this.chartFunc_MAD.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRes_MAD.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Halp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task4 выполнил студент группы СМАРТб,-23-1 Мороз Артём Дмитриевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveClick_MAD(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V13.txt";
                File.WriteAllText(path, textBoxRes_MAD.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
