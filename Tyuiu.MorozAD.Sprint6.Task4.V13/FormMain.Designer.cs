
namespace Tyuiu.MorozAD.Sprint6.Task4.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelHead_MAD = new System.Windows.Forms.Panel();
            this.panelOut_MAD = new System.Windows.Forms.Panel();
            this.panelChar_MAD = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRes_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxTask_MAD = new System.Windows.Forms.GroupBox();
            this.buttonHelp_MAD = new System.Windows.Forms.Button();
            this.chartFunc_MAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxTask_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxEnter_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxStart_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxStop_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxStart_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStop_MAD = new System.Windows.Forms.TextBox();
            this.buttonDone_MAD = new System.Windows.Forms.Button();
            this.buttonSave_MAD = new System.Windows.Forms.Button();
            this.panelHead_MAD.SuspendLayout();
            this.panelOut_MAD.SuspendLayout();
            this.panelChar_MAD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTask_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).BeginInit();
            this.groupBoxEnter_MAD.SuspendLayout();
            this.groupBoxStart_MAD.SuspendLayout();
            this.groupBoxStop_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead_MAD
            // 
            this.panelHead_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelHead_MAD.Controls.Add(this.buttonSave_MAD);
            this.panelHead_MAD.Controls.Add(this.buttonDone_MAD);
            this.panelHead_MAD.Controls.Add(this.groupBoxEnter_MAD);
            this.panelHead_MAD.Controls.Add(this.buttonHelp_MAD);
            this.panelHead_MAD.Controls.Add(this.groupBoxTask_MAD);
            this.panelHead_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelHead_MAD.Name = "panelHead_MAD";
            this.panelHead_MAD.Size = new System.Drawing.Size(995, 67);
            this.panelHead_MAD.TabIndex = 0;
            this.panelHead_MAD.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelOut_MAD
            // 
            this.panelOut_MAD.BackColor = System.Drawing.Color.Blue;
            this.panelOut_MAD.Controls.Add(this.groupBox1);
            this.panelOut_MAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOut_MAD.Location = new System.Drawing.Point(0, 67);
            this.panelOut_MAD.Name = "panelOut_MAD";
            this.panelOut_MAD.Size = new System.Drawing.Size(188, 469);
            this.panelOut_MAD.TabIndex = 1;
            // 
            // panelChar_MAD
            // 
            this.panelChar_MAD.BackColor = System.Drawing.Color.ForestGreen;
            this.panelChar_MAD.Controls.Add(this.chartFunc_MAD);
            this.panelChar_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChar_MAD.Location = new System.Drawing.Point(188, 67);
            this.panelChar_MAD.Name = "panelChar_MAD";
            this.panelChar_MAD.Size = new System.Drawing.Size(807, 469);
            this.panelChar_MAD.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(188, 67);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 469);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRes_MAD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(188, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод:";
            // 
            // textBoxRes_MAD
            // 
            this.textBoxRes_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRes_MAD.Location = new System.Drawing.Point(5, 18);
            this.textBoxRes_MAD.Multiline = true;
            this.textBoxRes_MAD.Name = "textBoxRes_MAD";
            this.textBoxRes_MAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_MAD.Size = new System.Drawing.Size(178, 446);
            this.textBoxRes_MAD.TabIndex = 0;
            // 
            // groupBoxTask_MAD
            // 
            this.groupBoxTask_MAD.Controls.Add(this.textBoxTask_MAD);
            this.groupBoxTask_MAD.Location = new System.Drawing.Point(5, 3);
            this.groupBoxTask_MAD.Name = "groupBoxTask_MAD";
            this.groupBoxTask_MAD.Size = new System.Drawing.Size(403, 64);
            this.groupBoxTask_MAD.TabIndex = 0;
            this.groupBoxTask_MAD.TabStop = false;
            this.groupBoxTask_MAD.Text = "Условие:";
            // 
            // buttonHelp_MAD
            // 
            this.buttonHelp_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MAD.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelp_MAD.Location = new System.Drawing.Point(923, 7);
            this.buttonHelp_MAD.Name = "buttonHelp_MAD";
            this.buttonHelp_MAD.Size = new System.Drawing.Size(60, 54);
            this.buttonHelp_MAD.TabIndex = 1;
            this.buttonHelp_MAD.Text = "Справка";
            this.buttonHelp_MAD.UseVisualStyleBackColor = false;
            this.buttonHelp_MAD.Click += new System.EventHandler(this.Halp_Click);
            // 
            // chartFunc_MAD
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunc_MAD.ChartAreas.Add(chartArea4);
            this.chartFunc_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartFunc_MAD.Legends.Add(legend4);
            this.chartFunc_MAD.Location = new System.Drawing.Point(0, 0);
            this.chartFunc_MAD.Name = "chartFunc_MAD";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Cos(x)";
            this.chartFunc_MAD.Series.Add(series4);
            this.chartFunc_MAD.Size = new System.Drawing.Size(807, 469);
            this.chartFunc_MAD.TabIndex = 0;
            this.chartFunc_MAD.Text = "chart1";
            title4.Name = "Cos(x)";
            title4.Text = "График функции cos(x)";
            this.chartFunc_MAD.Titles.Add(title4);
            this.chartFunc_MAD.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBoxTask_MAD
            // 
            this.textBoxTask_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_MAD.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_MAD.Multiline = true;
            this.textBoxTask_MAD.Name = "textBoxTask_MAD";
            this.textBoxTask_MAD.Size = new System.Drawing.Size(397, 45);
            this.textBoxTask_MAD.TabIndex = 0;
            this.textBoxTask_MAD.Text = "Протабулировать функцию Cos(x) на заданном диапозоне от -5 до 5.\r\nРезультат вывес" +
    "ти в textBox, построить график функции и сохранить в файл\r\nOutPutFile Task.txt п" +
    "о нажатию кнопки.\r\n";
            // 
            // groupBoxEnter_MAD
            // 
            this.groupBoxEnter_MAD.Controls.Add(this.groupBoxStop_MAD);
            this.groupBoxEnter_MAD.Controls.Add(this.groupBoxStart_MAD);
            this.groupBoxEnter_MAD.Location = new System.Drawing.Point(425, 3);
            this.groupBoxEnter_MAD.Name = "groupBoxEnter_MAD";
            this.groupBoxEnter_MAD.Size = new System.Drawing.Size(262, 60);
            this.groupBoxEnter_MAD.TabIndex = 2;
            this.groupBoxEnter_MAD.TabStop = false;
            this.groupBoxEnter_MAD.Text = "Ввод данных";
            // 
            // groupBoxStart_MAD
            // 
            this.groupBoxStart_MAD.Controls.Add(this.textBoxStart_MAD);
            this.groupBoxStart_MAD.Location = new System.Drawing.Point(6, 14);
            this.groupBoxStart_MAD.Name = "groupBoxStart_MAD";
            this.groupBoxStart_MAD.Size = new System.Drawing.Size(96, 40);
            this.groupBoxStart_MAD.TabIndex = 0;
            this.groupBoxStart_MAD.TabStop = false;
            this.groupBoxStart_MAD.Text = "Старт Шага:";
            // 
            // groupBoxStop_MAD
            // 
            this.groupBoxStop_MAD.Controls.Add(this.textBoxStop_MAD);
            this.groupBoxStop_MAD.Location = new System.Drawing.Point(135, 14);
            this.groupBoxStop_MAD.Name = "groupBoxStop_MAD";
            this.groupBoxStop_MAD.Size = new System.Drawing.Size(96, 40);
            this.groupBoxStop_MAD.TabIndex = 1;
            this.groupBoxStop_MAD.TabStop = false;
            this.groupBoxStop_MAD.Text = "Конец шага:";
            // 
            // textBoxStart_MAD
            // 
            this.textBoxStart_MAD.Location = new System.Drawing.Point(6, 14);
            this.textBoxStart_MAD.Name = "textBoxStart_MAD";
            this.textBoxStart_MAD.Size = new System.Drawing.Size(73, 20);
            this.textBoxStart_MAD.TabIndex = 0;
            this.textBoxStart_MAD.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxStop_MAD
            // 
            this.textBoxStop_MAD.Location = new System.Drawing.Point(6, 13);
            this.textBoxStop_MAD.Name = "textBoxStop_MAD";
            this.textBoxStop_MAD.Size = new System.Drawing.Size(73, 20);
            this.textBoxStop_MAD.TabIndex = 1;
            // 
            // buttonDone_MAD
            // 
            this.buttonDone_MAD.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_MAD.Location = new System.Drawing.Point(708, 10);
            this.buttonDone_MAD.Name = "buttonDone_MAD";
            this.buttonDone_MAD.Size = new System.Drawing.Size(87, 50);
            this.buttonDone_MAD.TabIndex = 3;
            this.buttonDone_MAD.Text = "Выполнить";
            this.buttonDone_MAD.UseVisualStyleBackColor = false;
            this.buttonDone_MAD.Click += new System.EventHandler(this.buttonDone_MAD_Click);
            // 
            // buttonSave_MAD
            // 
            this.buttonSave_MAD.BackColor = System.Drawing.Color.Blue;
            this.buttonSave_MAD.Location = new System.Drawing.Point(801, 11);
            this.buttonSave_MAD.Name = "buttonSave_MAD";
            this.buttonSave_MAD.Size = new System.Drawing.Size(87, 50);
            this.buttonSave_MAD.TabIndex = 4;
            this.buttonSave_MAD.Text = "Сохранить";
            this.buttonSave_MAD.UseVisualStyleBackColor = false;
            this.buttonSave_MAD.Click += new System.EventHandler(this.SaveClick_MAD);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 536);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelChar_MAD);
            this.Controls.Add(this.panelOut_MAD);
            this.Controls.Add(this.panelHead_MAD);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сприт6 | Таск4 | Вариант 13 | Мороз.А.Д.";
            this.panelHead_MAD.ResumeLayout(false);
            this.panelOut_MAD.ResumeLayout(false);
            this.panelChar_MAD.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTask_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).EndInit();
            this.groupBoxEnter_MAD.ResumeLayout(false);
            this.groupBoxStart_MAD.ResumeLayout(false);
            this.groupBoxStart_MAD.PerformLayout();
            this.groupBoxStop_MAD.ResumeLayout(false);
            this.groupBoxStop_MAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead_MAD;
        private System.Windows.Forms.Button buttonHelp_MAD;
        private System.Windows.Forms.GroupBox groupBoxTask_MAD;
        private System.Windows.Forms.Panel panelOut_MAD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRes_MAD;
        private System.Windows.Forms.Panel panelChar_MAD;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_MAD;
        private System.Windows.Forms.TextBox textBoxTask_MAD;
        private System.Windows.Forms.GroupBox groupBoxEnter_MAD;
        private System.Windows.Forms.GroupBox groupBoxStop_MAD;
        private System.Windows.Forms.TextBox textBoxStop_MAD;
        private System.Windows.Forms.GroupBox groupBoxStart_MAD;
        private System.Windows.Forms.TextBox textBoxStart_MAD;
        private System.Windows.Forms.Button buttonSave_MAD;
        private System.Windows.Forms.Button buttonDone_MAD;
    }
}

