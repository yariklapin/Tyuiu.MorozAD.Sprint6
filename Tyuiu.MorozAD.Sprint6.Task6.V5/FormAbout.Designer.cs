
namespace Tyuiu.MorozAD.Sprint6.Task6.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_MAD = new System.Windows.Forms.PictureBox();
            this.label_MAD = new System.Windows.Forms.Label();
            this.buttonOK_MAD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MAD)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_MAD
            // 
            this.pictureBoxAvatar_MAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAvatar_MAD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_MAD.Image")));
            this.pictureBoxAvatar_MAD.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvatar_MAD.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxAvatar_MAD.Name = "pictureBoxAvatar_MAD";
            this.pictureBoxAvatar_MAD.Size = new System.Drawing.Size(167, 217);
            this.pictureBoxAvatar_MAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAvatar_MAD.TabIndex = 1;
            this.pictureBoxAvatar_MAD.TabStop = false;
            // 
            // label_MAD
            // 
            this.label_MAD.AutoSize = true;
            this.label_MAD.Location = new System.Drawing.Point(178, 8);
            this.label_MAD.Name = "label_MAD";
            this.label_MAD.Size = new System.Drawing.Size(284, 156);
            this.label_MAD.TabIndex = 2;
            this.label_MAD.Text = resources.GetString("label_MAD.Text");
            // 
            // buttonOK_MAD
            // 
            this.buttonOK_MAD.Location = new System.Drawing.Point(384, 182);
            this.buttonOK_MAD.Name = "buttonOK_MAD";
            this.buttonOK_MAD.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_MAD.TabIndex = 4;
            this.buttonOK_MAD.Text = "Ok";
            this.buttonOK_MAD.UseVisualStyleBackColor = true;
            this.buttonOK_MAD.Click += new System.EventHandler(this.label_MAD_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 217);
            this.Controls.Add(this.buttonOK_MAD);
            this.Controls.Add(this.label_MAD);
            this.Controls.Add(this.pictureBoxAvatar_MAD);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_MAD;
        private System.Windows.Forms.Label label_MAD;
        private System.Windows.Forms.Button buttonOK_MAD;
    }
}