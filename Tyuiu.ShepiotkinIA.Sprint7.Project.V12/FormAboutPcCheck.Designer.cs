
namespace Tyuiu.ShepiotkinIA.Sprint7.Project.V12
{
    partial class FormAboutPcCheck
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
            this.dataGridViewPcCheck_SIA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPcCheck_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPcCheck_SIA
            // 
            this.dataGridViewPcCheck_SIA.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPcCheck_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPcCheck_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPcCheck_SIA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPcCheck_SIA.Name = "dataGridViewPcCheck_SIA";
            this.dataGridViewPcCheck_SIA.Size = new System.Drawing.Size(498, 168);
            this.dataGridViewPcCheck_SIA.TabIndex = 0;
            // 
            // FormAboutPcCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 168);
            this.Controls.Add(this.dataGridViewPcCheck_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutPcCheck";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка комлектующих пк";
            this.Load += new System.EventHandler(this.FormAboutPcCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPcCheck_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPcCheck_SIA;
    }
}