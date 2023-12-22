
namespace Tyuiu.ShepiotkinIA.Sprint7.Project.V12
{
    partial class FormAboutHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutHelp));
            this.buttonHelpOk_SIA = new System.Windows.Forms.Button();
            this.panelFillHelp_SIA = new System.Windows.Forms.Panel();
            this.labelHelp_SIA = new System.Windows.Forms.Label();
            this.panelTopNameButtonHelp_SIA = new System.Windows.Forms.Panel();
            this.labelNameProgrammHelp_SIA = new System.Windows.Forms.Label();
            this.panelFillHelp_SIA.SuspendLayout();
            this.panelTopNameButtonHelp_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelpOk_SIA
            // 
            this.buttonHelpOk_SIA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelpOk_SIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelpOk_SIA.Location = new System.Drawing.Point(682, 405);
            this.buttonHelpOk_SIA.Name = "buttonHelpOk_SIA";
            this.buttonHelpOk_SIA.Size = new System.Drawing.Size(90, 31);
            this.buttonHelpOk_SIA.TabIndex = 3;
            this.buttonHelpOk_SIA.Text = "Ок";
            this.buttonHelpOk_SIA.UseVisualStyleBackColor = false;
            this.buttonHelpOk_SIA.Click += new System.EventHandler(this.buttonHelpOk_SIA_Click);
            // 
            // panelFillHelp_SIA
            // 
            this.panelFillHelp_SIA.BackColor = System.Drawing.Color.White;
            this.panelFillHelp_SIA.Controls.Add(this.labelHelp_SIA);
            this.panelFillHelp_SIA.Controls.Add(this.panelTopNameButtonHelp_SIA);
            this.panelFillHelp_SIA.Controls.Add(this.buttonHelpOk_SIA);
            this.panelFillHelp_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFillHelp_SIA.Location = new System.Drawing.Point(0, 0);
            this.panelFillHelp_SIA.Name = "panelFillHelp_SIA";
            this.panelFillHelp_SIA.Size = new System.Drawing.Size(784, 448);
            this.panelFillHelp_SIA.TabIndex = 4;
            // 
            // labelHelp_SIA
            // 
            this.labelHelp_SIA.AutoSize = true;
            this.labelHelp_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelp_SIA.Location = new System.Drawing.Point(26, 87);
            this.labelHelp_SIA.Name = "labelHelp_SIA";
            this.labelHelp_SIA.Size = new System.Drawing.Size(717, 300);
            this.labelHelp_SIA.TabIndex = 7;
            this.labelHelp_SIA.Text = resources.GetString("labelHelp_SIA.Text");
            // 
            // panelTopNameButtonHelp_SIA
            // 
            this.panelTopNameButtonHelp_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelTopNameButtonHelp_SIA.Controls.Add(this.labelNameProgrammHelp_SIA);
            this.panelTopNameButtonHelp_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopNameButtonHelp_SIA.Location = new System.Drawing.Point(0, 0);
            this.panelTopNameButtonHelp_SIA.Name = "panelTopNameButtonHelp_SIA";
            this.panelTopNameButtonHelp_SIA.Size = new System.Drawing.Size(784, 65);
            this.panelTopNameButtonHelp_SIA.TabIndex = 6;
            // 
            // labelNameProgrammHelp_SIA
            // 
            this.labelNameProgrammHelp_SIA.AutoSize = true;
            this.labelNameProgrammHelp_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameProgrammHelp_SIA.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNameProgrammHelp_SIA.Location = new System.Drawing.Point(296, 9);
            this.labelNameProgrammHelp_SIA.Name = "labelNameProgrammHelp_SIA";
            this.labelNameProgrammHelp_SIA.Size = new System.Drawing.Size(151, 48);
            this.labelNameProgrammHelp_SIA.TabIndex = 5;
            this.labelNameProgrammHelp_SIA.Text = "PC Component\r\n     Manager";
            // 
            // FormAboutHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 448);
            this.Controls.Add(this.panelFillHelp_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutHelp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Краткое руководство пользователя";
            this.panelFillHelp_SIA.ResumeLayout(false);
            this.panelFillHelp_SIA.PerformLayout();
            this.panelTopNameButtonHelp_SIA.ResumeLayout(false);
            this.panelTopNameButtonHelp_SIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelpOk_SIA;
        private System.Windows.Forms.Panel panelFillHelp_SIA;
        private System.Windows.Forms.Label labelNameProgrammHelp_SIA;
        private System.Windows.Forms.Label labelHelp_SIA;
        private System.Windows.Forms.Panel panelTopNameButtonHelp_SIA;
    }
}