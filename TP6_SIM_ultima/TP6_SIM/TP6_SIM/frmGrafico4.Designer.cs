
namespace TP6_SIM
{
    partial class frmGrafico4
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
            this.grafico4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafico4)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico3
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico4.ChartAreas.Add(chartArea1);
            this.grafico4.DataSource = this.grafico4.Images;
            legend1.Name = "Legend1";
            this.grafico4.Legends.Add(legend1);
            this.grafico4.Location = new System.Drawing.Point(12, 12);
            this.grafico4.Name = "grafico3";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "X\'";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.grafico4.Series.Add(series1);
            this.grafico4.Size = new System.Drawing.Size(510, 426);
            this.grafico4.TabIndex = 3;
            this.grafico4.Text = "chart1";
            // 
            // frmGrafico4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.grafico4);
            this.Name = "frmGrafico4";
            this.Text = "frmGrafico4";
            ((System.ComponentModel.ISupportInitialize)(this.grafico4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart grafico4;
    }
}