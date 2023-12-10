using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MorozAD.Sprint6.Task6.V5.Lib;
namespace Tyuiu.MorozAD.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        public string str = " ";
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_MAD_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput_MAD.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_MAD.Text = groupBoxInPut_MAD.Text + " " + openFileDialogTask.FileName;
            buttonDone_MAD.Enabled = true;
        }

        private void buttonDone_MAD_Click(object sender, EventArgs e)
        {
            textBoxOut_MAD.Text = ds.CollectTextFromFile(str,openFilePath);
        }

        private void buttonHelp_MAD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
