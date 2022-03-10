
namespace TP6_SIM
{
    partial class frmGrafico2
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
            this.grafico2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafico2)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico1
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico2.Legends.Add(legend1);
            this.grafico2.Location = new System.Drawing.Point(12, 12);
            this.grafico2.Name = "grafico1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "X\'\'";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.grafico2.Series.Add(series1);
            this.grafico2.Size = new System.Drawing.Size(510, 426);
            this.grafico2.TabIndex = 1;
            this.grafico2.Text = "chart1";
            // 
            // frmGrafico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.grafico2);
            this.Name = "frmGrafico2";
            this.Text = "Visualizacion de Graficos";
            ((System.ComponentModel.ISupportInitialize)(this.grafico2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart grafico2;
    }
}