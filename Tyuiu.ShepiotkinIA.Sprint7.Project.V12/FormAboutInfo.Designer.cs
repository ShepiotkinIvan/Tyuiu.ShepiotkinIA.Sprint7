
namespace Tyuiu.ShepiotkinIA.Sprint7.Project.V12
{
    partial class FormAboutInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutInfo));
            this.pictureBoxAvatar_SIA = new System.Windows.Forms.PictureBox();
            this.labelInfo_SIA = new System.Windows.Forms.Label();
            this.buttonOk_SIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_SIA
            // 
            this.pictureBoxAvatar_SIA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SIA.Image")));
            this.pictureBoxAvatar_SIA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_SIA.Name = "pictureBoxAvatar_SIA";
            this.pictureBoxAvatar_SIA.Size = new System.Drawing.Size(215, 287);
            this.pictureBoxAvatar_SIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_SIA.TabIndex = 0;
            this.pictureBoxAvatar_SIA.TabStop = false;
            // 
            // labelInfo_SIA
            // 
            this.labelInfo_SIA.AutoSize = true;
            this.labelInfo_SIA.Location = new System.Drawing.Point(243, 45);
            this.labelInfo_SIA.Name = "labelInfo_SIA";
            this.labelInfo_SIA.Size = new System.Drawing.Size(555, 208);
            this.labelInfo_SIA.TabIndex = 1;
            this.labelInfo_SIA.Text = resources.GetString("labelInfo_SIA.Text");
            // 
            // buttonOk_SIA
            // 
            this.buttonOk_SIA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOk_SIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk_SIA.Location = new System.Drawing.Point(712, 268);
            this.buttonOk_SIA.Name = "buttonOk_SIA";
            this.buttonOk_SIA.Size = new System.Drawing.Size(90, 31);
            this.buttonOk_SIA.TabIndex = 2;
            this.buttonOk_SIA.Text = "Ок";
            this.buttonOk_SIA.UseVisualStyleBackColor = false;
            this.buttonOk_SIA.Click += new System.EventHandler(this.buttonOk_SIA_Click);
            // 
            // FormAboutInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 311);
            this.Controls.Add(this.buttonOk_SIA);
            this.Controls.Add(this.labelInfo_SIA);
            this.Controls.Add(this.pictureBoxAvatar_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(830, 350);
            this.Name = "FormAboutInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_SIA;
        private System.Windows.Forms.Label labelInfo_SIA;
        private System.Windows.Forms.Button buttonOk_SIA;
    }
}