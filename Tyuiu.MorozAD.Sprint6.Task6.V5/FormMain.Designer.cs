
namespace Tyuiu.MorozAD.Sprint6.Task6.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHead_MAD = new System.Windows.Forms.Panel();
            this.panelTask_MAD = new System.Windows.Forms.Panel();
            this.panelLeft_MAD = new System.Windows.Forms.Panel();
            this.panelOut_MAD = new System.Windows.Forms.Panel();
            this.groupBoxTask_MAD = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxInput_MAD = new System.Windows.Forms.TextBox();
            this.textBoxOut_MAD = new System.Windows.Forms.TextBox();
            this.buttonOpen_MAD = new System.Windows.Forms.Button();
            this.buttonDone_MAD = new System.Windows.Forms.Button();
            this.buttonHelp_MAD = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MAD = new System.Windows.Forms.ToolTip(this.components);
            this.panelHead_MAD.SuspendLayout();
            this.panelTask_MAD.SuspendLayout();
            this.panelLeft_MAD.SuspendLayout();
            this.panelOut_MAD.SuspendLayout();
            this.groupBoxTask_MAD.SuspendLayout();
            this.groupBoxInPut_MAD.SuspendLayout();
            this.groupBoxOut_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead_MAD
            // 
            this.panelHead_MAD.Controls.Add(this.buttonHelp_MAD);
            this.panelHead_MAD.Controls.Add(this.buttonDone_MAD);
            this.panelHead_MAD.Controls.Add(this.buttonOpen_MAD);
            this.panelHead_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelHead_MAD.Name = "panelHead_MAD";
            this.panelHead_MAD.Size = new System.Drawing.Size(800, 61);
            this.panelHead_MAD.TabIndex = 0;
            // 
            // panelTask_MAD
            // 
            this.panelTask_MAD.Controls.Add(this.groupBoxTask_MAD);
            this.panelTask_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_MAD.Location = new System.Drawing.Point(0, 61);
            this.panelTask_MAD.Name = "panelTask_MAD";
            this.panelTask_MAD.Size = new System.Drawing.Size(800, 88);
            this.panelTask_MAD.TabIndex = 1;
            // 
            // panelLeft_MAD
            // 
            this.panelLeft_MAD.Controls.Add(this.groupBoxInPut_MAD);
            this.panelLeft_MAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MAD.Location = new System.Drawing.Point(0, 149);
            this.panelLeft_MAD.Name = "panelLeft_MAD";
            this.panelLeft_MAD.Size = new System.Drawing.Size(391, 301);
            this.panelLeft_MAD.TabIndex = 1;
            // 
            // panelOut_MAD
            // 
            this.panelOut_MAD.Controls.Add(this.groupBoxOut_MAD);
            this.panelOut_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOut_MAD.Location = new System.Drawing.Point(391, 149);
            this.panelOut_MAD.Name = "panelOut_MAD";
            this.panelOut_MAD.Size = new System.Drawing.Size(409, 301);
            this.panelOut_MAD.TabIndex = 1;
            // 
            // groupBoxTask_MAD
            // 
            this.groupBoxTask_MAD.Controls.Add(this.textBox1);
            this.groupBoxTask_MAD.Location = new System.Drawing.Point(8, 7);
            this.groupBoxTask_MAD.Name = "groupBoxTask_MAD";
            this.groupBoxTask_MAD.Size = new System.Drawing.Size(789, 62);
            this.groupBoxTask_MAD.TabIndex = 0;
            this.groupBoxTask_MAD.TabStop = false;
            this.groupBoxTask_MAD.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxInPut_MAD
            // 
            this.groupBoxInPut_MAD.Controls.Add(this.textBoxInput_MAD);
            this.groupBoxInPut_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_MAD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_MAD.Name = "groupBoxInPut_MAD";
            this.groupBoxInPut_MAD.Size = new System.Drawing.Size(391, 301);
            this.groupBoxInPut_MAD.TabIndex = 1;
            this.groupBoxInPut_MAD.TabStop = false;
            this.groupBoxInPut_MAD.Text = "Ввод:";
            // 
            // groupBoxOut_MAD
            // 
            this.groupBoxOut_MAD.Controls.Add(this.textBoxOut_MAD);
            this.groupBoxOut_MAD.Location = new System.Drawing.Point(6, 0);
            this.groupBoxOut_MAD.Name = "groupBoxOut_MAD";
            this.groupBoxOut_MAD.Size = new System.Drawing.Size(399, 301);
            this.groupBoxOut_MAD.TabIndex = 0;
            this.groupBoxOut_MAD.TabStop = false;
            this.groupBoxOut_MAD.Text = "Вывод:";
            // 
            // textBoxInput_MAD
            // 
            this.textBoxInput_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_MAD.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput_MAD.Multiline = true;
            this.textBoxInput_MAD.Name = "textBoxInput_MAD";
            this.textBoxInput_MAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_MAD.Size = new System.Drawing.Size(385, 282);
            this.textBoxInput_MAD.TabIndex = 0;
            // 
            // textBoxOut_MAD
            // 
            this.textBoxOut_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_MAD.Location = new System.Drawing.Point(3, 16);
            this.textBoxOut_MAD.Multiline = true;
            this.textBoxOut_MAD.Name = "textBoxOut_MAD";
            this.textBoxOut_MAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_MAD.Size = new System.Drawing.Size(393, 282);
            this.textBoxOut_MAD.TabIndex = 0;
            // 
            // buttonOpen_MAD
            // 
            this.buttonOpen_MAD.ImageKey = "(none)";
            this.buttonOpen_MAD.Location = new System.Drawing.Point(8, 3);
            this.buttonOpen_MAD.Name = "buttonOpen_MAD";
            this.buttonOpen_MAD.Size = new System.Drawing.Size(92, 49);
            this.buttonOpen_MAD.TabIndex = 0;
            this.buttonOpen_MAD.Text = "Открыть Файл";
            this.toolTip_MAD.SetToolTip(this.buttonOpen_MAD, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpen_MAD.UseVisualStyleBackColor = true;
            this.buttonOpen_MAD.Click += new System.EventHandler(this.buttonOpenFile_MAD_Click);
            // 
            // buttonDone_MAD
            // 
            this.buttonDone_MAD.Location = new System.Drawing.Point(115, 3);
            this.buttonDone_MAD.Name = "buttonDone_MAD";
            this.buttonDone_MAD.Size = new System.Drawing.Size(92, 49);
            this.buttonDone_MAD.TabIndex = 1;
            this.buttonDone_MAD.Text = "Выполнить";
            this.toolTip_MAD.SetToolTip(this.buttonDone_MAD, "Производит поиск  в файле вхождений символов\"I\"\r\n\r\n");
            this.buttonDone_MAD.UseVisualStyleBackColor = true;
            this.buttonDone_MAD.Click += new System.EventHandler(this.buttonDone_MAD_Click);
            // 
            // buttonHelp_MAD
            // 
            this.buttonHelp_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MAD.Location = new System.Drawing.Point(696, 6);
            this.buttonHelp_MAD.Name = "buttonHelp_MAD";
            this.buttonHelp_MAD.Size = new System.Drawing.Size(92, 49);
            this.buttonHelp_MAD.TabIndex = 2;
            this.buttonHelp_MAD.Text = "Справка";
            this.toolTip_MAD.SetToolTip(this.buttonHelp_MAD, "Сведение о программе\r\n\r\n\r\n");
            this.buttonHelp_MAD.UseVisualStyleBackColor = true;
            this.buttonHelp_MAD.Click += new System.EventHandler(this.buttonHelp_MAD_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip_MAD
            // 
            this.toolTip_MAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MAD.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOut_MAD);
            this.Controls.Add(this.panelLeft_MAD);
            this.Controls.Add(this.panelTask_MAD);
            this.Controls.Add(this.panelHead_MAD);
            this.Name = "FormMain";
            this.Text = "Сприт 6 | Таск 6 | Вариант 5  | Мороз.А.Д.";
            this.panelHead_MAD.ResumeLayout(false);
            this.panelTask_MAD.ResumeLayout(false);
            this.panelLeft_MAD.ResumeLayout(false);
            this.panelOut_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.PerformLayout();
            this.groupBoxInPut_MAD.ResumeLayout(false);
            this.groupBoxInPut_MAD.PerformLayout();
            this.groupBoxOut_MAD.ResumeLayout(false);
            this.groupBoxOut_MAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead_MAD;
        private System.Windows.Forms.Panel panelTask_MAD;
        private System.Windows.Forms.Panel panelLeft_MAD;
        private System.Windows.Forms.Panel panelOut_MAD;
        private System.Windows.Forms.GroupBox groupBoxTask_MAD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonHelp_MAD;
        private System.Windows.Forms.Button buttonDone_MAD;
        private System.Windows.Forms.Button buttonOpen_MAD;
        private System.Windows.Forms.GroupBox groupBoxInPut_MAD;
        private System.Windows.Forms.TextBox textBoxInput_MAD;
        private System.Windows.Forms.GroupBox groupBoxOut_MAD;
        private System.Windows.Forms.TextBox textBoxOut_MAD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip_MAD;
    }
}

