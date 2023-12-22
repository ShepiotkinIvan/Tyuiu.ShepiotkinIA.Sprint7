
namespace Tyuiu.ShepiotkinIA.Sprint7.Project.V12
{
    partial class FormAboutChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartHaDrVo_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRAM_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxRam_SIA = new System.Windows.Forms.GroupBox();
            this.groupBoxHaDrVo_SIA = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartHaDrVo_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM_SIA)).BeginInit();
            this.groupBoxRam_SIA.SuspendLayout();
            this.groupBoxHaDrVo_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartHaDrVo_SIA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHaDrVo_SIA.ChartAreas.Add(chartArea1);
            this.chartHaDrVo_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartHaDrVo_SIA.Legends.Add(legend1);
            this.chartHaDrVo_SIA.Location = new System.Drawing.Point(3, 16);
            this.chartHaDrVo_SIA.Name = "chartHaDrVo_SIA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHaDrVo_SIA.Series.Add(series1);
            this.chartHaDrVo_SIA.Size = new System.Drawing.Size(484, 309);
            this.chartHaDrVo_SIA.TabIndex = 0;
            this.chartHaDrVo_SIA.Text = "chart1";
            // 
            // chartRAM_SIA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRAM_SIA.ChartAreas.Add(chartArea2);
            this.chartRAM_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartRAM_SIA.Legends.Add(legend2);
            this.chartRAM_SIA.Location = new System.Drawing.Point(3, 16);
            this.chartRAM_SIA.Name = "chartRAM_SIA";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRAM_SIA.Series.Add(series2);
            this.chartRAM_SIA.Size = new System.Drawing.Size(487, 309);
            this.chartRAM_SIA.TabIndex = 0;
            this.chartRAM_SIA.Text = "chart1";
            // 
            // groupBoxRam_SIA
            // 
            this.groupBoxRam_SIA.Controls.Add(this.chartRAM_SIA);
            this.groupBoxRam_SIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRam_SIA.Name = "groupBoxRam_SIA";
            this.groupBoxRam_SIA.Size = new System.Drawing.Size(493, 328);
            this.groupBoxRam_SIA.TabIndex = 1;
            this.groupBoxRam_SIA.TabStop = false;
            this.groupBoxRam_SIA.Text = "groupBox1";
            // 
            // groupBoxHaDrVo_SIA
            // 
            this.groupBoxHaDrVo_SIA.Controls.Add(this.chartHaDrVo_SIA);
            this.groupBoxHaDrVo_SIA.Location = new System.Drawing.Point(515, 12);
            this.groupBoxHaDrVo_SIA.Name = "groupBoxHaDrVo_SIA";
            this.groupBoxHaDrVo_SIA.Size = new System.Drawing.Size(490, 328);
            this.groupBoxHaDrVo_SIA.TabIndex = 1;
            this.groupBoxHaDrVo_SIA.TabStop = false;
            this.groupBoxHaDrVo_SIA.Text = "groupBox1";
            // 
            // FormAboutChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 350);
            this.Controls.Add(this.groupBoxHaDrVo_SIA);
            this.Controls.Add(this.groupBoxRam_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutChart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики таблицы";
            ((System.ComponentModel.ISupportInitialize)(this.chartHaDrVo_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM_SIA)).EndInit();
            this.groupBoxRam_SIA.ResumeLayout(false);
            this.groupBoxHaDrVo_SIA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHaDrVo_SIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRAM_SIA;
        private System.Windows.Forms.GroupBox groupBoxRam_SIA;
        private System.Windows.Forms.GroupBox groupBoxHaDrVo_SIA;
    }
}