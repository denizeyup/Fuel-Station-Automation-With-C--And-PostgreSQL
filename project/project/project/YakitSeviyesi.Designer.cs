namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    partial class YakitSeviyesi
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
            this.chartyakitseviyesi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartyakitseviyesi)).BeginInit();
            this.SuspendLayout();
            // 
            // chartyakitseviyesi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartyakitseviyesi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartyakitseviyesi.Legends.Add(legend1);
            this.chartyakitseviyesi.Location = new System.Drawing.Point(70, 32);
            this.chartyakitseviyesi.Name = "chartyakitseviyesi";
            this.chartyakitseviyesi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Yakıt Seviyesi";
            this.chartyakitseviyesi.Series.Add(series1);
            this.chartyakitseviyesi.Size = new System.Drawing.Size(663, 358);
            this.chartyakitseviyesi.TabIndex = 1;
            this.chartyakitseviyesi.Text = "chart1";
            // 
            // YakitSeviyesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartyakitseviyesi);
            this.Name = "YakitSeviyesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YakitSeviyesi";
            ((System.ComponentModel.ISupportInitialize)(this.chartyakitseviyesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartyakitseviyesi;
    }
}