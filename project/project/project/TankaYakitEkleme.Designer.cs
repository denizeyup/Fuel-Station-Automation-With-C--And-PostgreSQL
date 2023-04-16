namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    partial class TankaYakitEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TankaYakitEkleme));
            this.chartyakitekleme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLitre = new System.Windows.Forms.TextBox();
            this.comboBoxTankNo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartyakitekleme)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartyakitekleme
            // 
            this.chartyakitekleme.BackColor = System.Drawing.Color.GhostWhite;
            chartArea1.Name = "ChartArea1";
            this.chartyakitekleme.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartyakitekleme.Legends.Add(legend1);
            this.chartyakitekleme.Location = new System.Drawing.Point(475, 27);
            this.chartyakitekleme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartyakitekleme.Name = "chartyakitekleme";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Yakıt Seviyesi";
            this.chartyakitekleme.Series.Add(series1);
            this.chartyakitekleme.Size = new System.Drawing.Size(392, 328);
            this.chartyakitekleme.TabIndex = 0;
            this.chartyakitekleme.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Litre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tank No :";
            // 
            // textBoxLitre
            // 
            this.textBoxLitre.Location = new System.Drawing.Point(115, 91);
            this.textBoxLitre.Name = "textBoxLitre";
            this.textBoxLitre.Size = new System.Drawing.Size(121, 29);
            this.textBoxLitre.TabIndex = 24;
            // 
            // comboBoxTankNo
            // 
            this.comboBoxTankNo.FormattingEnabled = true;
            this.comboBoxTankNo.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Teknisyen",
            "Pompacı",
            "Temizlikçi",
            "Yıkamacı",
            "Marketçi",
            "Güvenlikçi"});
            this.comboBoxTankNo.Location = new System.Drawing.Point(115, 45);
            this.comboBoxTankNo.Name = "comboBoxTankNo";
            this.comboBoxTankNo.Size = new System.Drawing.Size(121, 29);
            this.comboBoxTankNo.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.comboBoxTankNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxLitre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 249);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yakıt Ekleme İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.buttonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.Color.White;
            this.buttonEkle.Image = ((System.Drawing.Image)(resources.GetObject("buttonEkle.Image")));
            this.buttonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEkle.Location = new System.Drawing.Point(249, 174);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(121, 50);
            this.buttonEkle.TabIndex = 33;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // TankaYakitEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(900, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartyakitekleme);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TankaYakitEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TankaYakitEkleme";
            this.Load += new System.EventHandler(this.TankaYakitEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartyakitekleme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLitre;
        private System.Windows.Forms.ComboBox comboBoxTankNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartyakitekleme;
    }
}