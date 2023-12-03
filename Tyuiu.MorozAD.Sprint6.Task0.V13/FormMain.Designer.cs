
namespace Tyuiu.MorozAD.Sprint6.Task0.V13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PictBoxFormula_MAD = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GroupBoxResult_MAD = new System.Windows.Forms.GroupBox();
            this.Result_MAD = new System.Windows.Forms.TextBox();
            this.buttonResult_MAD = new System.Windows.Forms.Button();
            this.buttonHelp_MAD = new System.Windows.Forms.Button();
            this.VarGroupBox_MAD = new System.Windows.Forms.GroupBox();
            this.VarGroupBoxX_MAD = new System.Windows.Forms.GroupBox();
            this.VarBoxX_MAD = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictBoxFormula_MAD)).BeginInit();
            this.GroupBoxResult_MAD.SuspendLayout();
            this.VarGroupBox_MAD.SuspendLayout();
            this.VarGroupBoxX_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PictBoxFormula_MAD);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // PictBoxFormula_MAD
            // 
            this.PictBoxFormula_MAD.Image = ((System.Drawing.Image)(resources.GetObject("PictBoxFormula_MAD.Image")));
            this.PictBoxFormula_MAD.Location = new System.Drawing.Point(613, 19);
            this.PictBoxFormula_MAD.Name = "PictBoxFormula_MAD";
            this.PictBoxFormula_MAD.Size = new System.Drawing.Size(109, 62);
            this.PictBoxFormula_MAD.TabIndex = 1;
            this.PictBoxFormula_MAD.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 187);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Вычеслить выражение по формуле";
            // 
            // GroupBoxResult_MAD
            // 
            this.GroupBoxResult_MAD.Controls.Add(this.Result_MAD);
            this.GroupBoxResult_MAD.Location = new System.Drawing.Point(478, 307);
            this.GroupBoxResult_MAD.Name = "GroupBoxResult_MAD";
            this.GroupBoxResult_MAD.Size = new System.Drawing.Size(310, 106);
            this.GroupBoxResult_MAD.TabIndex = 2;
            this.GroupBoxResult_MAD.TabStop = false;
            this.GroupBoxResult_MAD.Text = "Вывод данных";
            this.GroupBoxResult_MAD.Enter += new System.EventHandler(this.GroupBoxResult_MAD_Enter);
            // 
            // Result_MAD
            // 
            this.Result_MAD.Location = new System.Drawing.Point(25, 42);
            this.Result_MAD.Name = "Result_MAD";
            this.Result_MAD.Size = new System.Drawing.Size(167, 20);
            this.Result_MAD.TabIndex = 0;
            // 
            // buttonResult_MAD
            // 
            this.buttonResult_MAD.Location = new System.Drawing.Point(680, 419);
            this.buttonResult_MAD.Name = "buttonResult_MAD";
            this.buttonResult_MAD.Size = new System.Drawing.Size(108, 25);
            this.buttonResult_MAD.TabIndex = 3;
            this.buttonResult_MAD.Text = "Выполнить";
            this.buttonResult_MAD.UseVisualStyleBackColor = true;
            this.buttonResult_MAD.Click += new System.EventHandler(this.buttonResult_MAD_Click);
            // 
            // buttonHelp_MAD
            // 
            this.buttonHelp_MAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_MAD.Location = new System.Drawing.Point(625, 413);
            this.buttonHelp_MAD.Name = "buttonHelp_MAD";
            this.buttonHelp_MAD.Size = new System.Drawing.Size(45, 31);
            this.buttonHelp_MAD.TabIndex = 4;
            this.buttonHelp_MAD.Text = "?";
            this.buttonHelp_MAD.UseVisualStyleBackColor = true;
            this.buttonHelp_MAD.Click += new System.EventHandler(this.buttonHelp_MAD_Click);
            // 
            // VarGroupBox_MAD
            // 
            this.VarGroupBox_MAD.Controls.Add(this.VarGroupBoxX_MAD);
            this.VarGroupBox_MAD.Location = new System.Drawing.Point(41, 307);
            this.VarGroupBox_MAD.Name = "VarGroupBox_MAD";
            this.VarGroupBox_MAD.Size = new System.Drawing.Size(416, 106);
            this.VarGroupBox_MAD.TabIndex = 5;
            this.VarGroupBox_MAD.TabStop = false;
            this.VarGroupBox_MAD.Text = "Ввод данных";
            this.VarGroupBox_MAD.Enter += new System.EventHandler(this.VarGroupBox_MAD_Enter);
            // 
            // VarGroupBoxX_MAD
            // 
            this.VarGroupBoxX_MAD.Controls.Add(this.VarBoxX_MAD);
            this.VarGroupBoxX_MAD.Location = new System.Drawing.Point(84, 30);
            this.VarGroupBoxX_MAD.Name = "VarGroupBoxX_MAD";
            this.VarGroupBoxX_MAD.Size = new System.Drawing.Size(220, 52);
            this.VarGroupBoxX_MAD.TabIndex = 2;
            this.VarGroupBoxX_MAD.TabStop = false;
            this.VarGroupBoxX_MAD.Text = "                    Переменная Х:";
            // 
            // VarBoxX_MAD
            // 
            this.VarBoxX_MAD.Location = new System.Drawing.Point(12, 18);
            this.VarBoxX_MAD.Name = "VarBoxX_MAD";
            this.VarBoxX_MAD.Size = new System.Drawing.Size(194, 20);
            this.VarBoxX_MAD.TabIndex = 1;
            this.VarBoxX_MAD.TextChanged += new System.EventHandler(this.VarBoxX_MAD_TextChanged);
            this.VarBoxX_MAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonResult_MAD_KeyPress);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VarGroupBox_MAD);
            this.Controls.Add(this.buttonHelp_MAD);
            this.Controls.Add(this.buttonResult_MAD);
            this.Controls.Add(this.GroupBoxResult_MAD);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Сприт6 | Таск0 | Вариант 13 | Мороз.А.Д.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictBoxFormula_MAD)).EndInit();
            this.GroupBoxResult_MAD.ResumeLayout(false);
            this.GroupBoxResult_MAD.PerformLayout();
            this.VarGroupBox_MAD.ResumeLayout(false);
            this.VarGroupBoxX_MAD.ResumeLayout(false);
            this.VarGroupBoxX_MAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PictBoxFormula_MAD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox GroupBoxResult_MAD;
        private System.Windows.Forms.TextBox Result_MAD;
        private System.Windows.Forms.Button buttonResult_MAD;
        private System.Windows.Forms.Button buttonHelp_MAD;
        private System.Windows.Forms.GroupBox VarGroupBox_MAD;
        private System.Windows.Forms.GroupBox VarGroupBoxX_MAD;
        private System.Windows.Forms.TextBox VarBoxX_MAD;
    }
}

