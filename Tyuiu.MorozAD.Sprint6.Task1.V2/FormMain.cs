using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MorozAD.Sprint6.Task1.V2.Lib;

namespace Tyuiu.MorozAD.Sprint6.Task1.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_MAD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startstep = Convert.ToInt32(textBoxStart_MAD.Text);
                int stopstep = Convert.ToInt32(textBoxStop_MAD.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;

                double[] func = new double[len];

                func = ds.GetMassFunction(startstep, stopstep);
                textBoxResult_MAD.Text = "";
                textBoxResult_MAD.AppendText("+---------------------------- +" + Environment.NewLine);
                textBoxResult_MAD.AppendText("|    x     |     f(x)    |" + Environment.NewLine);
                textBoxResult_MAD.AppendText("+-----------------------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 8:f2}    |", startstep, func[i]);
                    textBoxResult_MAD.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_MAD.AppendText("+----------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-23-1 Мороз Артём Дмитриевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
