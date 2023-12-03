
namespace Tyuiu.MorozAD.Sprint6.Task3.V16
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxTask_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxResul_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.buttonHelp_MAD = new System.Windows.Forms.Button();
            this.buttonDone_MAD = new System.Windows.Forms.Button();
            this.dataGridViewRes_MAD = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewAns_MAD = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_MAD.SuspendLayout();
            this.groupBoxOut_MAD.SuspendLayout();
            this.groupBoxResul_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAns_MAD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MAD
            // 
            this.groupBoxTask_MAD.Controls.Add(this.dataGridViewRes_MAD);
            this.groupBoxTask_MAD.Controls.Add(this.textBoxTask);
            this.groupBoxTask_MAD.Location = new System.Drawing.Point(13, 14);
            this.groupBoxTask_MAD.Name = "groupBoxTask_MAD";
            this.groupBoxTask_MAD.Size = new System.Drawing.Size(558, 428);
            this.groupBoxTask_MAD.TabIndex = 0;
            this.groupBoxTask_MAD.TabStop = false;
            this.groupBoxTask_MAD.Text = "Условие";
            // 
            // groupBoxOut_MAD
            // 
            this.groupBoxOut_MAD.Controls.Add(this.groupBoxResul_MAD);
            this.groupBoxOut_MAD.Location = new System.Drawing.Point(577, 22);
            this.groupBoxOut_MAD.Name = "groupBoxOut_MAD";
            this.groupBoxOut_MAD.Size = new System.Drawing.Size(220, 380);
            this.groupBoxOut_MAD.TabIndex = 1;
            this.groupBoxOut_MAD.TabStop = false;
            this.groupBoxOut_MAD.Text = "Вывод данных";
            // 
            // groupBoxResul_MAD
            // 
            this.groupBoxResul_MAD.Controls.Add(this.dataGridViewAns_MAD);
            this.groupBoxResul_MAD.Location = new System.Drawing.Point(6, 19);
            this.groupBoxResul_MAD.Name = "groupBoxResul_MAD";
            this.groupBoxResul_MAD.Size = new System.Drawing.Size(225, 315);
            this.groupBoxResul_MAD.TabIndex = 0;
            this.groupBoxResul_MAD.TabStop = false;
            this.groupBoxResul_MAD.Text = "Результат:";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(15, 36);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(267, 142);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Дана матрица 5 на 5:\r\n\r\n14   1  -3   1  10\r\n 7  -3   5  -4   0\r\n-10 -19 -18  -9  " +
    "19\r\n -2  -2 -16   2 -17\r\n-16   9   5 -10  16\r\n\r\nЗаменить четные значения в треть" +
    "ей строке на 0.";
            // 
            // buttonHelp_MAD
            // 
            this.buttonHelp_MAD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_MAD.Location = new System.Drawing.Point(624, 408);
            this.buttonHelp_MAD.Name = "buttonHelp_MAD";
            this.buttonHelp_MAD.Size = new System.Drawing.Size(47, 33);
            this.buttonHelp_MAD.TabIndex = 2;
            this.buttonHelp_MAD.Text = "?";
            this.buttonHelp_MAD.UseVisualStyleBackColor = false;
            this.buttonHelp_MAD.Click += new System.EventHandler(this.buttonHelpCLick_MAD);
            // 
            // buttonDone_MAD
            // 
            this.buttonDone_MAD.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_MAD.Location = new System.Drawing.Point(697, 408);
            this.buttonDone_MAD.Name = "buttonDone_MAD";
            this.buttonDone_MAD.Size = new System.Drawing.Size(100, 32);
            this.buttonDone_MAD.TabIndex = 3;
            this.buttonDone_MAD.Text = "Выполнить";
            this.buttonDone_MAD.UseVisualStyleBackColor = false;
            this.buttonDone_MAD.Click += new System.EventHandler(this.buttonDoneClick_MAD);
            // 
            // dataGridViewRes_MAD
            // 
            this.dataGridViewRes_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_MAD.ColumnHeadersVisible = false;
            this.dataGridViewRes_MAD.Location = new System.Drawing.Point(292, 39);
            this.dataGridViewRes_MAD.Name = "dataGridViewRes_MAD";
            this.dataGridViewRes_MAD.RowHeadersVisible = false;
            this.dataGridViewRes_MAD.Size = new System.Drawing.Size(254, 303);
            this.dataGridViewRes_MAD.TabIndex = 1;
            // 
            // dataGridViewAns_MAD
            // 
            this.dataGridViewAns_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAns_MAD.ColumnHeadersVisible = false;
            this.dataGridViewAns_MAD.Location = new System.Drawing.Point(0, 19);
            this.dataGridViewAns_MAD.Name = "dataGridViewAns_MAD";
            this.dataGridViewAns_MAD.RowHeadersVisible = false;
            this.dataGridViewAns_MAD.Size = new System.Drawing.Size(200, 296);
            this.dataGridViewAns_MAD.TabIndex = 0;
            this.dataGridViewAns_MAD.Click += new System.EventHandler(this.FormMain_MAD_CLick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_MAD);
            this.Controls.Add(this.buttonHelp_MAD);
            this.Controls.Add(this.groupBoxOut_MAD);
            this.Controls.Add(this.groupBoxTask_MAD);
            this.Name = "FormMain";
            this.Text = "Сприт 6 | Таск 3 | Вариант 16| Мороз.А.Д.";
            this.groupBoxTask_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.PerformLayout();
            this.groupBoxOut_MAD.ResumeLayout(false);
            this.groupBoxResul_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAns_MAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MAD;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxOut_MAD;
        private System.Windows.Forms.GroupBox groupBoxResul_MAD;
        private System.Windows.Forms.Button buttonHelp_MAD;
        private System.Windows.Forms.Button buttonDone_MAD;
        private System.Windows.Forms.DataGridView dataGridViewRes_MAD;
        private System.Windows.Forms.DataGridView dataGridViewAns_MAD;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

