
namespace Tyuiu.MorozAD.Sprint6.Task1.V2
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
            this.groupBoxTask_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxResult_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MAD = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxStop_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxStop_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxStart_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxStart_MAD = new System.Windows.Forms.TextBox();
            this.buttonHelp_MAD = new System.Windows.Forms.Button();
            this.buttonDone_MAD = new System.Windows.Forms.Button();
            this.groupBoxTask_MAD.SuspendLayout();
            this.groupBoxResult_MAD.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxStop_MAD.SuspendLayout();
            this.groupBoxStart_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_MAD
            // 
            this.groupBoxTask_MAD.Controls.Add(this.textBoxTask_MAD);
            this.groupBoxTask_MAD.Location = new System.Drawing.Point(11, 11);
            this.groupBoxTask_MAD.Name = "groupBoxTask_MAD";
            this.groupBoxTask_MAD.Size = new System.Drawing.Size(505, 289);
            this.groupBoxTask_MAD.TabIndex = 0;
            this.groupBoxTask_MAD.TabStop = false;
            this.groupBoxTask_MAD.Text = "Условие";
            this.groupBoxTask_MAD.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTask_MAD
            // 
            this.textBoxTask_MAD.Location = new System.Drawing.Point(11, 29);
            this.textBoxTask_MAD.Multiline = true;
            this.textBoxTask_MAD.Name = "textBoxTask_MAD";
            this.textBoxTask_MAD.Size = new System.Drawing.Size(468, 223);
            this.textBoxTask_MAD.TabIndex = 0;
            this.textBoxTask_MAD.Text = "Протабулировать функцию sin(x) на заданном диапозоне. Результат вывести в виде та" +
    "блицы.";
            this.textBoxTask_MAD.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBoxResult_MAD
            // 
            this.groupBoxResult_MAD.Controls.Add(this.textBoxResult_MAD);
            this.groupBoxResult_MAD.Location = new System.Drawing.Point(548, 17);
            this.groupBoxResult_MAD.Name = "groupBoxResult_MAD";
            this.groupBoxResult_MAD.Size = new System.Drawing.Size(243, 429);
            this.groupBoxResult_MAD.TabIndex = 1;
            this.groupBoxResult_MAD.TabStop = false;
            this.groupBoxResult_MAD.Text = "Вывод данных";
            // 
            // textBoxResult_MAD
            // 
            this.textBoxResult_MAD.Location = new System.Drawing.Point(12, 33);
            this.textBoxResult_MAD.Multiline = true;
            this.textBoxResult_MAD.Name = "textBoxResult_MAD";
            this.textBoxResult_MAD.Size = new System.Drawing.Size(218, 386);
            this.textBoxResult_MAD.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBoxStop_MAD);
            this.groupBox3.Controls.Add(this.groupBoxStart_MAD);
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных:";
            // 
            // groupBoxStop_MAD
            // 
            this.groupBoxStop_MAD.Controls.Add(this.textBoxStop_MAD);
            this.groupBoxStop_MAD.Location = new System.Drawing.Point(153, 39);
            this.groupBoxStop_MAD.Name = "groupBoxStop_MAD";
            this.groupBoxStop_MAD.Size = new System.Drawing.Size(138, 51);
            this.groupBoxStop_MAD.TabIndex = 1;
            this.groupBoxStop_MAD.TabStop = false;
            this.groupBoxStop_MAD.Text = "Конец Шага:";
            // 
            // textBoxStop_MAD
            // 
            this.textBoxStop_MAD.Location = new System.Drawing.Point(6, 19);
            this.textBoxStop_MAD.Name = "textBoxStop_MAD";
            this.textBoxStop_MAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_MAD.TabIndex = 1;
            this.textBoxStop_MAD.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBoxStart_MAD
            // 
            this.groupBoxStart_MAD.Controls.Add(this.textBoxStart_MAD);
            this.groupBoxStart_MAD.Location = new System.Drawing.Point(19, 39);
            this.groupBoxStart_MAD.Name = "groupBoxStart_MAD";
            this.groupBoxStart_MAD.Size = new System.Drawing.Size(128, 51);
            this.groupBoxStart_MAD.TabIndex = 0;
            this.groupBoxStart_MAD.TabStop = false;
            this.groupBoxStart_MAD.Text = "Старт Шага:";
            // 
            // textBoxStart_MAD
            // 
            this.textBoxStart_MAD.Location = new System.Drawing.Point(3, 16);
            this.textBoxStart_MAD.Multiline = true;
            this.textBoxStart_MAD.Name = "textBoxStart_MAD";
            this.textBoxStart_MAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_MAD.TabIndex = 0;
            // 
            // buttonHelp_MAD
            // 
            this.buttonHelp_MAD.Location = new System.Drawing.Point(344, 383);
            this.buttonHelp_MAD.Name = "buttonHelp_MAD";
            this.buttonHelp_MAD.Size = new System.Drawing.Size(69, 55);
            this.buttonHelp_MAD.TabIndex = 3;
            this.buttonHelp_MAD.Text = "Справка";
            this.buttonHelp_MAD.UseVisualStyleBackColor = true;
            this.buttonHelp_MAD.Click += new System.EventHandler(this.buttonHelp_MAD_Click);
            // 
            // buttonDone_MAD
            // 
            this.buttonDone_MAD.Location = new System.Drawing.Point(438, 384);
            this.buttonDone_MAD.Name = "buttonDone_MAD";
            this.buttonDone_MAD.Size = new System.Drawing.Size(99, 51);
            this.buttonDone_MAD.TabIndex = 4;
            this.buttonDone_MAD.Text = "Выполнить";
            this.buttonDone_MAD.UseVisualStyleBackColor = true;
            this.buttonDone_MAD.Click += new System.EventHandler(this.buttonDone_MAD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_MAD);
            this.Controls.Add(this.buttonHelp_MAD);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxResult_MAD);
            this.Controls.Add(this.groupBoxTask_MAD);
            this.Name = "FormMain";
            this.Text = "Сприт6 | Таск1| Вариант 2 | Мороз.А.Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.PerformLayout();
            this.groupBoxResult_MAD.ResumeLayout(false);
            this.groupBoxResult_MAD.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxStop_MAD.ResumeLayout(false);
            this.groupBoxStop_MAD.PerformLayout();
            this.groupBoxStart_MAD.ResumeLayout(false);
            this.groupBoxStart_MAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MAD;
        private System.Windows.Forms.GroupBox groupBoxResult_MAD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonHelp_MAD;
        private System.Windows.Forms.GroupBox groupBoxStop_MAD;
        private System.Windows.Forms.TextBox textBoxStop_MAD;
        private System.Windows.Forms.GroupBox groupBoxStart_MAD;
        private System.Windows.Forms.TextBox textBoxStart_MAD;
        private System.Windows.Forms.TextBox textBoxTask_MAD;
        private System.Windows.Forms.TextBox textBoxResult_MAD;
        private System.Windows.Forms.Button buttonDone_MAD;
    }
}

