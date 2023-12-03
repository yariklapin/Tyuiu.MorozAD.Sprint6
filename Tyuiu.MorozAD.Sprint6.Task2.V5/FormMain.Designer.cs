
namespace Tyuiu.MorozAD.Sprint6.Task2.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxOut_MAD = new System.Windows.Forms.GroupBox();
            this.chartFunc_MAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunc_MAD = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEnter_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxStop_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxStop_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxStart_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxStart_MAD = new System.Windows.Forms.TextBox();
            this.buttonHelp_MAD = new System.Windows.Forms.Button();
            this.buttonDone_MAD = new System.Windows.Forms.Button();
            this.groupBoxTask_MAD.SuspendLayout();
            this.groupBoxOut_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc_MAD)).BeginInit();
            this.groupBoxEnter_MAD.SuspendLayout();
            this.groupBoxStop_MAD.SuspendLayout();
            this.groupBoxStart_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_MAD
            // 
            this.groupBoxTask_MAD.Controls.Add(this.textBoxTask_MAD);
            this.groupBoxTask_MAD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_MAD.Name = "groupBoxTask_MAD";
            this.groupBoxTask_MAD.Size = new System.Drawing.Size(455, 347);
            this.groupBoxTask_MAD.TabIndex = 0;
            this.groupBoxTask_MAD.TabStop = false;
            this.groupBoxTask_MAD.Text = "Условие";
            // 
            // textBoxTask_MAD
            // 
            this.textBoxTask_MAD.Location = new System.Drawing.Point(11, 23);
            this.textBoxTask_MAD.Multiline = true;
            this.textBoxTask_MAD.Name = "textBoxTask_MAD";
            this.textBoxTask_MAD.Size = new System.Drawing.Size(419, 32);
            this.textBoxTask_MAD.TabIndex = 0;
            this.textBoxTask_MAD.Text = "Протаублировать функцию cos(X) на заданном диапозоне.                     Результ" +
    "атом вывести в DataGridView и построить график функий.";
            // 
            // groupBoxOut_MAD
            // 
            this.groupBoxOut_MAD.Controls.Add(this.chartFunc_MAD);
            this.groupBoxOut_MAD.Controls.Add(this.dataGridViewFunc_MAD);
            this.groupBoxOut_MAD.Location = new System.Drawing.Point(509, 9);
            this.groupBoxOut_MAD.Name = "groupBoxOut_MAD";
            this.groupBoxOut_MAD.Size = new System.Drawing.Size(512, 426);
            this.groupBoxOut_MAD.TabIndex = 1;
            this.groupBoxOut_MAD.TabStop = false;
            this.groupBoxOut_MAD.Text = "Вывод данных";
            // 
            // chartFunc_MAD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunc_MAD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunc_MAD.Legends.Add(legend1);
            this.chartFunc_MAD.Location = new System.Drawing.Point(128, 16);
            this.chartFunc_MAD.Name = "chartFunc_MAD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Cos(x)";
            this.chartFunc_MAD.Series.Add(series1);
            this.chartFunc_MAD.Size = new System.Drawing.Size(378, 410);
            this.chartFunc_MAD.TabIndex = 1;
            this.chartFunc_MAD.Text = "chart1";
            // 
            // dataGridViewFunc_MAD
            // 
            this.dataGridViewFunc_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunc_MAD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.ColumnF});
            this.dataGridViewFunc_MAD.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewFunc_MAD.Name = "dataGridViewFunc_MAD";
            this.dataGridViewFunc_MAD.RowHeadersVisible = false;
            this.dataGridViewFunc_MAD.Size = new System.Drawing.Size(119, 410);
            this.dataGridViewFunc_MAD.TabIndex = 0;
            this.dataGridViewFunc_MAD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "F(X)";
            this.ColumnF.Name = "ColumnF";
            this.ColumnF.Width = 50;
            // 
            // groupBoxEnter_MAD
            // 
            this.groupBoxEnter_MAD.Controls.Add(this.groupBoxStop_MAD);
            this.groupBoxEnter_MAD.Controls.Add(this.groupBoxStart_MAD);
            this.groupBoxEnter_MAD.Location = new System.Drawing.Point(12, 365);
            this.groupBoxEnter_MAD.Name = "groupBoxEnter_MAD";
            this.groupBoxEnter_MAD.Size = new System.Drawing.Size(309, 82);
            this.groupBoxEnter_MAD.TabIndex = 2;
            this.groupBoxEnter_MAD.TabStop = false;
            this.groupBoxEnter_MAD.Text = "Ввод данных";
            // 
            // groupBoxStop_MAD
            // 
            this.groupBoxStop_MAD.Controls.Add(this.textBoxStop_MAD);
            this.groupBoxStop_MAD.Location = new System.Drawing.Point(145, 32);
            this.groupBoxStop_MAD.Name = "groupBoxStop_MAD";
            this.groupBoxStop_MAD.Size = new System.Drawing.Size(154, 38);
            this.groupBoxStop_MAD.TabIndex = 1;
            this.groupBoxStop_MAD.TabStop = false;
            this.groupBoxStop_MAD.Text = "Конец шага:";
            // 
            // textBoxStop_MAD
            // 
            this.textBoxStop_MAD.Location = new System.Drawing.Point(6, 17);
            this.textBoxStop_MAD.Name = "textBoxStop_MAD";
            this.textBoxStop_MAD.Size = new System.Drawing.Size(106, 20);
            this.textBoxStop_MAD.TabIndex = 1;
            this.textBoxStop_MAD.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBoxStart_MAD
            // 
            this.groupBoxStart_MAD.Controls.Add(this.textBoxStart_MAD);
            this.groupBoxStart_MAD.Location = new System.Drawing.Point(6, 32);
            this.groupBoxStart_MAD.Name = "groupBoxStart_MAD";
            this.groupBoxStart_MAD.Size = new System.Drawing.Size(133, 38);
            this.groupBoxStart_MAD.TabIndex = 0;
            this.groupBoxStart_MAD.TabStop = false;
            this.groupBoxStart_MAD.Text = "Старт Шага :";
            // 
            // textBoxStart_MAD
            // 
            this.textBoxStart_MAD.Location = new System.Drawing.Point(11, 17);
            this.textBoxStart_MAD.Name = "textBoxStart_MAD";
            this.textBoxStart_MAD.Size = new System.Drawing.Size(106, 20);
            this.textBoxStart_MAD.TabIndex = 0;
            // 
            // buttonHelp_MAD
            // 
            this.buttonHelp_MAD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_MAD.Location = new System.Drawing.Point(327, 389);
            this.buttonHelp_MAD.Name = "buttonHelp_MAD";
            this.buttonHelp_MAD.Size = new System.Drawing.Size(74, 49);
            this.buttonHelp_MAD.TabIndex = 3;
            this.buttonHelp_MAD.Text = "Справка";
            this.buttonHelp_MAD.UseVisualStyleBackColor = false;
            this.buttonHelp_MAD.Click += new System.EventHandler(this.Help_Click);
            // 
            // buttonDone_MAD
            // 
            this.buttonDone_MAD.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_MAD.Location = new System.Drawing.Point(407, 389);
            this.buttonDone_MAD.Name = "buttonDone_MAD";
            this.buttonDone_MAD.Size = new System.Drawing.Size(96, 49);
            this.buttonDone_MAD.TabIndex = 4;
            this.buttonDone_MAD.Text = "Выполнить";
            this.buttonDone_MAD.UseVisualStyleBackColor = false;
            this.buttonDone_MAD.Click += new System.EventHandler(this.buttonDone_MAD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.buttonDone_MAD);
            this.Controls.Add(this.buttonHelp_MAD);
            this.Controls.Add(this.groupBoxEnter_MAD);
            this.Controls.Add(this.groupBoxOut_MAD);
            this.Controls.Add(this.groupBoxTask_MAD);
            this.Name = "FormMain";
            this.Text = "Сприт6 | Таск2 | Вариант 5 | Мороз.А.Д.";
            this.groupBoxTask_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.PerformLayout();
            this.groupBoxOut_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc_MAD)).EndInit();
            this.groupBoxEnter_MAD.ResumeLayout(false);
            this.groupBoxStop_MAD.ResumeLayout(false);
            this.groupBoxStop_MAD.PerformLayout();
            this.groupBoxStart_MAD.ResumeLayout(false);
            this.groupBoxStart_MAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MAD;
        private System.Windows.Forms.GroupBox groupBoxOut_MAD;
        private System.Windows.Forms.DataGridView dataGridViewFunc_MAD;
        private System.Windows.Forms.GroupBox groupBoxEnter_MAD;
        private System.Windows.Forms.GroupBox groupBoxStop_MAD;
        private System.Windows.Forms.GroupBox groupBoxStart_MAD;
        private System.Windows.Forms.Button buttonHelp_MAD;
        private System.Windows.Forms.Button buttonDone_MAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_MAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
        private System.Windows.Forms.TextBox textBoxStop_MAD;
        private System.Windows.Forms.TextBox textBoxStart_MAD;
        private System.Windows.Forms.TextBox textBoxTask_MAD;
    }
}

