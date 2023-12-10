
namespace Tyuiu.MorozAD.Sprint6.Task5.V27
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHead_MAd = new System.Windows.Forms.Panel();
            this.panelOut_MAD = new System.Windows.Forms.Panel();
            this.panelChar_MAD = new System.Windows.Forms.Panel();
            this.groupBoxTask_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxOut_MAD = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_MAD = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chartFunc_MAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_MAD = new System.Windows.Forms.Button();
            this.buttonOpen_MAD = new System.Windows.Forms.Button();
            this.buttonHelp_MAD = new System.Windows.Forms.Button();
            this.panelHead_MAd.SuspendLayout();
            this.panelOut_MAD.SuspendLayout();
            this.panelChar_MAD.SuspendLayout();
            this.groupBoxTask_MAD.SuspendLayout();
            this.groupBoxOut_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead_MAd
            // 
            this.panelHead_MAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelHead_MAd.Controls.Add(this.buttonHelp_MAD);
            this.panelHead_MAd.Controls.Add(this.buttonOpen_MAD);
            this.panelHead_MAd.Controls.Add(this.buttonDone_MAD);
            this.panelHead_MAd.Controls.Add(this.splitter1);
            this.panelHead_MAd.Controls.Add(this.groupBoxTask_MAD);
            this.panelHead_MAd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead_MAd.Location = new System.Drawing.Point(0, 0);
            this.panelHead_MAd.Name = "panelHead_MAd";
            this.panelHead_MAd.Size = new System.Drawing.Size(800, 87);
            this.panelHead_MAd.TabIndex = 0;
            // 
            // panelOut_MAD
            // 
            this.panelOut_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelOut_MAD.Controls.Add(this.groupBoxOut_MAD);
            this.panelOut_MAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOut_MAD.Location = new System.Drawing.Point(0, 87);
            this.panelOut_MAD.Name = "panelOut_MAD";
            this.panelOut_MAD.Size = new System.Drawing.Size(121, 363);
            this.panelOut_MAD.TabIndex = 1;
            // 
            // panelChar_MAD
            // 
            this.panelChar_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelChar_MAD.Controls.Add(this.chartFunc_MAD);
            this.panelChar_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChar_MAD.Location = new System.Drawing.Point(121, 87);
            this.panelChar_MAD.Name = "panelChar_MAD";
            this.panelChar_MAD.Size = new System.Drawing.Size(679, 363);
            this.panelChar_MAD.TabIndex = 2;
            // 
            // groupBoxTask_MAD
            // 
            this.groupBoxTask_MAD.Controls.Add(this.textBoxTask_MAD);
            this.groupBoxTask_MAD.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_MAD.Name = "groupBoxTask_MAD";
            this.groupBoxTask_MAD.Size = new System.Drawing.Size(381, 78);
            this.groupBoxTask_MAD.TabIndex = 3;
            this.groupBoxTask_MAD.TabStop = false;
            this.groupBoxTask_MAD.Text = "Условие:";
            // 
            // textBoxTask_MAD
            // 
            this.textBoxTask_MAD.Location = new System.Drawing.Point(11, 19);
            this.textBoxTask_MAD.Multiline = true;
            this.textBoxTask_MAD.Name = "textBoxTask_MAD";
            this.textBoxTask_MAD.Size = new System.Drawing.Size(367, 34);
            this.textBoxTask_MAD.TabIndex = 0;
            this.textBoxTask_MAD.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView\r\nположительн" +
    "ые значения и построить диаграмму по этим значениям.\r\n";
            // 
            // groupBoxOut_MAD
            // 
            this.groupBoxOut_MAD.Controls.Add(this.dataGridViewRes_MAD);
            this.groupBoxOut_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_MAD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_MAD.Name = "groupBoxOut_MAD";
            this.groupBoxOut_MAD.Size = new System.Drawing.Size(121, 363);
            this.groupBoxOut_MAD.TabIndex = 0;
            this.groupBoxOut_MAD.TabStop = false;
            this.groupBoxOut_MAD.Text = "Вывод данных:";
            // 
            // dataGridViewRes_MAD
            // 
            this.dataGridViewRes_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_MAD.ColumnHeadersVisible = false;
            this.dataGridViewRes_MAD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num});
            this.dataGridViewRes_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRes_MAD.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRes_MAD.Name = "dataGridViewRes_MAD";
            this.dataGridViewRes_MAD.RowHeadersVisible = false;
            this.dataGridViewRes_MAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRes_MAD.Size = new System.Drawing.Size(115, 344);
            this.dataGridViewRes_MAD.TabIndex = 0;
            this.dataGridViewRes_MAD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_MAD_CellContentClick);
            // 
            // Num
            // 
            this.Num.HeaderText = "";
            this.Num.Name = "Num";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 87);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // chartFunc_MAD
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunc_MAD.ChartAreas.Add(chartArea3);
            this.chartFunc_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartFunc_MAD.Legends.Add(legend3);
            this.chartFunc_MAD.Location = new System.Drawing.Point(0, 0);
            this.chartFunc_MAD.Name = "chartFunc_MAD";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "func";
            this.chartFunc_MAD.Series.Add(series3);
            this.chartFunc_MAD.Size = new System.Drawing.Size(679, 363);
            this.chartFunc_MAD.TabIndex = 0;
            // 
            // buttonDone_MAD
            // 
            this.buttonDone_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_MAD.Location = new System.Drawing.Point(419, 16);
            this.buttonDone_MAD.Name = "buttonDone_MAD";
            this.buttonDone_MAD.Size = new System.Drawing.Size(112, 50);
            this.buttonDone_MAD.TabIndex = 5;
            this.buttonDone_MAD.Text = "Выполнить";
            this.buttonDone_MAD.UseVisualStyleBackColor = false;
            this.buttonDone_MAD.Click += new System.EventHandler(this.DoneClick_MAD);
            // 
            // buttonOpen_MAD
            // 
            this.buttonOpen_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpen_MAD.Location = new System.Drawing.Point(548, 16);
            this.buttonOpen_MAD.Name = "buttonOpen_MAD";
            this.buttonOpen_MAD.Size = new System.Drawing.Size(112, 50);
            this.buttonOpen_MAD.TabIndex = 6;
            this.buttonOpen_MAD.Text = "Открыть Файл";
            this.buttonOpen_MAD.UseVisualStyleBackColor = false;
            this.buttonOpen_MAD.Click += new System.EventHandler(this.OpenFileClick_MAD);
            // 
            // buttonHelp_MAD
            // 
            this.buttonHelp_MAD.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelp_MAD.Location = new System.Drawing.Point(685, 16);
            this.buttonHelp_MAD.Name = "buttonHelp_MAD";
            this.buttonHelp_MAD.Size = new System.Drawing.Size(112, 50);
            this.buttonHelp_MAD.TabIndex = 7;
            this.buttonHelp_MAD.Text = "Справка";
            this.buttonHelp_MAD.UseVisualStyleBackColor = false;
            this.buttonHelp_MAD.Click += new System.EventHandler(this.Help_MADClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChar_MAD);
            this.Controls.Add(this.panelOut_MAD);
            this.Controls.Add(this.panelHead_MAd);
            this.Name = "FormMain";
            this.Text = "Сприт6 | Таск5 | Вариант 27 | Мороз.А.Д.";
            this.panelHead_MAd.ResumeLayout(false);
            this.panelOut_MAD.ResumeLayout(false);
            this.panelChar_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.PerformLayout();
            this.groupBoxOut_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead_MAd;
        private System.Windows.Forms.Panel panelOut_MAD;
        private System.Windows.Forms.Panel panelChar_MAD;
        private System.Windows.Forms.GroupBox groupBoxTask_MAD;
        private System.Windows.Forms.TextBox textBoxTask_MAD;
        private System.Windows.Forms.GroupBox groupBoxOut_MAD;
        private System.Windows.Forms.DataGridView dataGridViewRes_MAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.Button buttonHelp_MAD;
        private System.Windows.Forms.Button buttonOpen_MAD;
        private System.Windows.Forms.Button buttonDone_MAD;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_MAD;
    }
}

