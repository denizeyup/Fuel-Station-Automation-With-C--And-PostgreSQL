namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    partial class GunSonuIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunSonuIslemleri));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.charteleman = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelciro = new System.Windows.Forms.Label();
            this.labelkar = new System.Windows.Forms.Label();
            this.chartyakit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.charteleman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartyakit)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(104, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 130);
            this.button1.TabIndex = 0;
            this.button1.Text = "Elemanların\r\nYapıtığı Satışlar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(448, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 130);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ciro ve Kâr";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(792, 28);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 130);
            this.button3.TabIndex = 2;
            this.button3.Text = "Yakıt\r\nKullanımı Detayları";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // charteleman
            // 
            chartArea1.Name = "ChartArea1";
            this.charteleman.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charteleman.Legends.Add(legend1);
            this.charteleman.Location = new System.Drawing.Point(38, 182);
            this.charteleman.Name = "charteleman";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Eleman";
            this.charteleman.Series.Add(series1);
            this.charteleman.Size = new System.Drawing.Size(380, 261);
            this.charteleman.TabIndex = 3;
            this.charteleman.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ciro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kâr :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "TL";
            // 
            // labelciro
            // 
            this.labelciro.AutoSize = true;
            this.labelciro.ForeColor = System.Drawing.Color.Red;
            this.labelciro.Location = new System.Drawing.Point(551, 182);
            this.labelciro.Name = "labelciro";
            this.labelciro.Size = new System.Drawing.Size(19, 23);
            this.labelciro.TabIndex = 8;
            this.labelciro.Text = "0";
            // 
            // labelkar
            // 
            this.labelkar.AutoSize = true;
            this.labelkar.ForeColor = System.Drawing.Color.Red;
            this.labelkar.Location = new System.Drawing.Point(551, 216);
            this.labelkar.Name = "labelkar";
            this.labelkar.Size = new System.Drawing.Size(19, 23);
            this.labelkar.TabIndex = 9;
            this.labelkar.Text = "0";
            // 
            // chartyakit
            // 
            chartArea2.Name = "ChartArea1";
            this.chartyakit.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartyakit.Legends.Add(legend2);
            this.chartyakit.Location = new System.Drawing.Point(724, 182);
            this.chartyakit.Name = "chartyakit";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Yakıtlar";
            this.chartyakit.Series.Add(series2);
            this.chartyakit.Size = new System.Drawing.Size(380, 261);
            this.chartyakit.TabIndex = 10;
            this.chartyakit.Text = "chartyakit";
            // 
            // GunSonuIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1151, 484);
            this.Controls.Add(this.chartyakit);
            this.Controls.Add(this.labelkar);
            this.Controls.Add(this.labelciro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charteleman);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GunSonuIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gün Sonu İşlemleri";
            this.Load += new System.EventHandler(this.GunSonuIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charteleman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartyakit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart charteleman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelciro;
        private System.Windows.Forms.Label labelkar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartyakit;
    }
}