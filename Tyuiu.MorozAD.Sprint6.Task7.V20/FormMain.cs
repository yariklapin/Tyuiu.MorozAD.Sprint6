using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MorozAD.Sprint6.Task7.V20.Lib;
using System.IO;

namespace Tyuiu.MorozAD.Sprint6.Task7.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_MAD.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
            saveFileDialog_MAD.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
        }
        public string OpenFilePath;

        
        DataService ds = new DataService();

        private void ClickSave_MAD(object sender, EventArgs e)
        {

        }

        private void ClickDone_MAD(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(OpenFilePath));
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_MAD.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            buttonSave_MAD.Enabled = true;
        }
        static int rows;
        static int columns;
        public static int[,] LoadFromFileData(string FilePath)
        {
            string fileDta = File.ReadAllText(FilePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);

                }
            }
            return arrayValues;
        }
        private void ClickOpenFile_MAD(object sender, EventArgs e)
        {
            openFileDialogTask_MAD.ShowDialog();
            OpenFilePath = openFileDialogTask_MAD.FileName;

            int[,] arrayValues = LoadFromFileData(OpenFilePath);
            dataGridViewIn_MAD.ColumnCount = columns;
            dataGridViewIn_MAD.RowCount = rows;
            dataGridViewRes_MAD.ColumnCount = columns;
            dataGridViewRes_MAD.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_MAD.Columns[i].Width = 25;
                dataGridViewRes_MAD.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn_MAD.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            arrayValues = ds.GetMatrix(LoadFromFileData(OpenFilePath));
            buttonDone_MAD.Enabled = true;
        }
        private void ClickHelp_MAD(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

       

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_MAD.ColumnCount = 50;
            dataGridViewRes_MAD.ColumnCount = 50;
            dataGridViewIn_MAD.RowCount = 50;
            dataGridViewRes_MAD.RowCount = 50;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_MAD.Columns[i].Width = 25;
                dataGridViewRes_MAD.Columns[i].Width = 25;

            }
        }

        private void groupBoxTask_MAD_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
