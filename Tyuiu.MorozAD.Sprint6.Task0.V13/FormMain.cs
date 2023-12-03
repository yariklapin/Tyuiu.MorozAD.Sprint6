using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MorozAD.Sprint6.Task0.V13.Lib;
namespace Tyuiu.MorozAD.Sprint6.Task0.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonHelp_MAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-23-1 Мороз Артём Дмитриевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_MAD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                Result_MAD.Text = ds.Calculate(Convert.ToInt32(VarBoxX_MAD.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        private void buttonResult_MAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void GroupBoxResult_MAD_Enter(object sender, EventArgs e)
        {

        }

        private void VarGroupBox_MAD_Enter(object sender, EventArgs e)
        {

        }

        private void VarBoxX_MAD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
