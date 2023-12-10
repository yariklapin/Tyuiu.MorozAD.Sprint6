
namespace Tyuiu.MorozAD.Sprint6.Task7.V20
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
            this.buttonHelp_MAD = new System.Windows.Forms.Button();
            this.buttonSave_MAD = new System.Windows.Forms.Button();
            this.buttonDone_MAD = new System.Windows.Forms.Button();
            this.buttonOpen_MAD = new System.Windows.Forms.Button();
            this.panelTask_MAD = new System.Windows.Forms.Panel();
            this.groupBoxTask_MAD = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTask_MAD = new System.Windows.Forms.Label();
            this.panelEnter_MAD = new System.Windows.Forms.Panel();
            this.groupBoxEnter_MAD = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_MAD = new System.Windows.Forms.DataGridView();
            this.panelOut_MAD = new System.Windows.Forms.Panel();
            this.groupBoxRes_MAD = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_MAD = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_MAD = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_MAD = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_MAD = new System.Windows.Forms.SaveFileDialog();
            this.panelHead_MAD.SuspendLayout();
            this.panelTask_MAD.SuspendLayout();
            this.groupBoxTask_MAD.SuspendLayout();
            this.panelEnter_MAD.SuspendLayout();
            this.groupBoxEnter_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_MAD)).BeginInit();
            this.panelOut_MAD.SuspendLayout();
            this.groupBoxRes_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MAD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead_MAD
            // 
            this.panelHead_MAD.Controls.Add(this.buttonHelp_MAD);
            this.panelHead_MAD.Controls.Add(this.buttonSave_MAD);
            this.panelHead_MAD.Controls.Add(this.buttonDone_MAD);
            this.panelHead_MAD.Controls.Add(this.buttonOpen_MAD);
            this.panelHead_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelHead_MAD.Name = "panelHead_MAD";
            this.panelHead_MAD.Size = new System.Drawing.Size(800, 43);
            this.panelHead_MAD.TabIndex = 0;
            // 
            // buttonHelp_MAD
            // 
            this.buttonHelp_MAD.Location = new System.Drawing.Point(710, 3);
            this.buttonHelp_MAD.Name = "buttonHelp_MAD";
            this.buttonHelp_MAD.Size = new System.Drawing.Size(84, 37);
            this.buttonHelp_MAD.TabIndex = 3;
            this.buttonHelp_MAD.Text = "Справка";
            this.toolTipTask_MAD.SetToolTip(this.buttonHelp_MAD, "О программе\r\n");
            this.buttonHelp_MAD.UseVisualStyleBackColor = true;
            this.buttonHelp_MAD.Click += new System.EventHandler(this.ClickHelp_MAD);
            // 
            // buttonSave_MAD
            // 
            this.buttonSave_MAD.Location = new System.Drawing.Point(193, 3);
            this.buttonSave_MAD.Name = "buttonSave_MAD";
            this.buttonSave_MAD.Size = new System.Drawing.Size(84, 37);
            this.buttonSave_MAD.TabIndex = 2;
            this.buttonSave_MAD.Text = "Сохранить";
            this.toolTipTask_MAD.SetToolTip(this.buttonSave_MAD, "Нажмите чтобы сохранить\r\n");
            this.buttonSave_MAD.UseVisualStyleBackColor = true;
            this.buttonSave_MAD.Click += new System.EventHandler(this.ClickSave_MAD);
            // 
            // buttonDone_MAD
            // 
            this.buttonDone_MAD.Location = new System.Drawing.Point(103, 3);
            this.buttonDone_MAD.Name = "buttonDone_MAD";
            this.buttonDone_MAD.Size = new System.Drawing.Size(84, 37);
            this.buttonDone_MAD.TabIndex = 1;
            this.buttonDone_MAD.Text = "Выполнить";
            this.toolTipTask_MAD.SetToolTip(this.buttonDone_MAD, "Нажмите чтоб запустить программу\r\n");
            this.buttonDone_MAD.UseVisualStyleBackColor = true;
            this.buttonDone_MAD.Click += new System.EventHandler(this.ClickDone_MAD);
            // 
            // buttonOpen_MAD
            // 
            this.buttonOpen_MAD.Location = new System.Drawing.Point(12, 3);
            this.buttonOpen_MAD.Name = "buttonOpen_MAD";
            this.buttonOpen_MAD.Size = new System.Drawing.Size(84, 37);
            this.buttonOpen_MAD.TabIndex = 0;
            this.buttonOpen_MAD.Text = "Открыть";
            this.toolTipTask_MAD.SetToolTip(this.buttonOpen_MAD, "Нажмите чтобы выбрать нужный файл\r\n");
            this.buttonOpen_MAD.UseVisualStyleBackColor = true;
            this.buttonOpen_MAD.Click += new System.EventHandler(this.ClickOpenFile_MAD);
            // 
            // panelTask_MAD
            // 
            this.panelTask_MAD.Controls.Add(this.groupBoxTask_MAD);
            this.panelTask_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_MAD.Location = new System.Drawing.Point(0, 43);
            this.panelTask_MAD.Name = "panelTask_MAD";
            this.panelTask_MAD.Size = new System.Drawing.Size(800, 86);
            this.panelTask_MAD.TabIndex = 1;
            // 
            // groupBoxTask_MAD
            // 
            this.groupBoxTask_MAD.Controls.Add(this.panel2);
            this.groupBoxTask_MAD.Controls.Add(this.labelTask_MAD);
            this.groupBoxTask_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_MAD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_MAD.Name = "groupBoxTask_MAD";
            this.groupBoxTask_MAD.Size = new System.Drawing.Size(800, 86);
            this.groupBoxTask_MAD.TabIndex = 0;
            this.groupBoxTask_MAD.TabStop = false;
            this.groupBoxTask_MAD.Text = "Условие:";
            this.groupBoxTask_MAD.Enter += new System.EventHandler(this.groupBoxTask_MAD_Enter);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(402, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 349);
            this.panel2.TabIndex = 3;
            // 
            // labelTask_MAD
            // 
            this.labelTask_MAD.AutoSize = true;
            this.labelTask_MAD.Location = new System.Drawing.Point(10, 19);
            this.labelTask_MAD.Name = "labelTask_MAD";
            this.labelTask_MAD.Size = new System.Drawing.Size(596, 52);
            this.labelTask_MAD.TabIndex = 0;
            this.labelTask_MAD.Text = resources.GetString("labelTask_MAD.Text");
            // 
            // panelEnter_MAD
            // 
            this.panelEnter_MAD.Controls.Add(this.groupBoxEnter_MAD);
            this.panelEnter_MAD.Location = new System.Drawing.Point(3, 134);
            this.panelEnter_MAD.Name = "panelEnter_MAD";
            this.panelEnter_MAD.Size = new System.Drawing.Size(398, 349);
            this.panelEnter_MAD.TabIndex = 2;
            // 
            // groupBoxEnter_MAD
            // 
            this.groupBoxEnter_MAD.Controls.Add(this.dataGridViewIn_MAD);
            this.groupBoxEnter_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEnter_MAD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEnter_MAD.Name = "groupBoxEnter_MAD";
            this.groupBoxEnter_MAD.Size = new System.Drawing.Size(398, 349);
            this.groupBoxEnter_MAD.TabIndex = 0;
            this.groupBoxEnter_MAD.TabStop = false;
            this.groupBoxEnter_MAD.Text = "Ввод:";
            // 
            // dataGridViewIn_MAD
            // 
            this.dataGridViewIn_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_MAD.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_MAD.Name = "dataGridViewIn_MAD";
            this.dataGridViewIn_MAD.Size = new System.Drawing.Size(392, 330);
            this.dataGridViewIn_MAD.TabIndex = 0;
            // 
            // panelOut_MAD
            // 
            this.panelOut_MAD.Controls.Add(this.groupBoxRes_MAD);
            this.panelOut_MAD.Location = new System.Drawing.Point(399, 134);
            this.panelOut_MAD.Name = "panelOut_MAD";
            this.panelOut_MAD.Size = new System.Drawing.Size(398, 349);
            this.panelOut_MAD.TabIndex = 3;
            // 
            // groupBoxRes_MAD
            // 
            this.groupBoxRes_MAD.Controls.Add(this.dataGridViewRes_MAD);
            this.groupBoxRes_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_MAD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes_MAD.Name = "groupBoxRes_MAD";
            this.groupBoxRes_MAD.Size = new System.Drawing.Size(398, 349);
            this.groupBoxRes_MAD.TabIndex = 1;
            this.groupBoxRes_MAD.TabStop = false;
            this.groupBoxRes_MAD.Text = "Вывод:";
            // 
            // dataGridViewRes_MAD
            // 
            this.dataGridViewRes_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRes_MAD.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRes_MAD.Name = "dataGridViewRes_MAD";
            this.dataGridViewRes_MAD.Size = new System.Drawing.Size(392, 330);
            this.dataGridViewRes_MAD.TabIndex = 1;
            // 
            // openFileDialogTask_MAD
            // 
            this.openFileDialogTask_MAD.FileName = "openFileDialog1";
            this.openFileDialogTask_MAD.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.panelOut_MAD);
            this.Controls.Add(this.panelEnter_MAD);
            this.Controls.Add(this.panelTask_MAD);
            this.Controls.Add(this.panelHead_MAD);
            this.Name = "FormMain";
            this.Text = "Сприт 6 | Таск 7 | Вариант 20| Мороз.А.Д.";
            this.panelHead_MAD.ResumeLayout(false);
            this.panelTask_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.ResumeLayout(false);
            this.groupBoxTask_MAD.PerformLayout();
            this.panelEnter_MAD.ResumeLayout(false);
            this.groupBoxEnter_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_MAD)).EndInit();
            this.panelOut_MAD.ResumeLayout(false);
            this.groupBoxRes_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead_MAD;
        private System.Windows.Forms.Button buttonHelp_MAD;
        private System.Windows.Forms.Button buttonSave_MAD;
        private System.Windows.Forms.Button buttonDone_MAD;
        private System.Windows.Forms.Button buttonOpen_MAD;
        private System.Windows.Forms.Panel panelTask_MAD;
        private System.Windows.Forms.GroupBox groupBoxTask_MAD;
        private System.Windows.Forms.Label labelTask_MAD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelEnter_MAD;
        private System.Windows.Forms.GroupBox groupBoxEnter_MAD;
        private System.Windows.Forms.Panel panelOut_MAD;
        private System.Windows.Forms.GroupBox groupBoxRes_MAD;
        private System.Windows.Forms.DataGridView dataGridViewIn_MAD;
        private System.Windows.Forms.DataGridView dataGridViewRes_MAD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MAD;
        private System.Windows.Forms.ToolTip toolTipTask_MAD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_MAD;
    }
}

