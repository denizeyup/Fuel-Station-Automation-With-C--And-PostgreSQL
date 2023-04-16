namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    partial class Dosyaislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dosyaislemleri));
            this.gunluk = new System.Windows.Forms.Button();
            this.toplam = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDisaaktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunluk
            // 
            this.gunluk.BackColor = System.Drawing.Color.Olive;
            this.gunluk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunluk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunluk.ForeColor = System.Drawing.Color.White;
            this.gunluk.Image = ((System.Drawing.Image)(resources.GetObject("gunluk.Image")));
            this.gunluk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gunluk.Location = new System.Drawing.Point(30, 26);
            this.gunluk.Name = "gunluk";
            this.gunluk.Size = new System.Drawing.Size(210, 106);
            this.gunluk.TabIndex = 34;
            this.gunluk.Text = "Günlük\r\nVeri Dosyası";
            this.gunluk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunluk.UseVisualStyleBackColor = false;
            this.gunluk.Click += new System.EventHandler(this.gunluk_Click);
            // 
            // toplam
            // 
            this.toplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toplam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toplam.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam.ForeColor = System.Drawing.Color.White;
            this.toplam.Image = ((System.Drawing.Image)(resources.GetObject("toplam.Image")));
            this.toplam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toplam.Location = new System.Drawing.Point(30, 150);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(210, 106);
            this.toplam.TabIndex = 33;
            this.toplam.Text = "Toplam\r\nVeri Dosyası";
            this.toplam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toplam.UseVisualStyleBackColor = false;
            this.toplam.Click += new System.EventHandler(this.toplam_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.Location = new System.Drawing.Point(278, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 315);
            this.dataGridView1.TabIndex = 36;
            // 
            // buttonDisaaktar
            // 
            this.buttonDisaaktar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonDisaaktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisaaktar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDisaaktar.ForeColor = System.Drawing.Color.White;
            this.buttonDisaaktar.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisaaktar.Image")));
            this.buttonDisaaktar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDisaaktar.Location = new System.Drawing.Point(65, 274);
            this.buttonDisaaktar.Name = "buttonDisaaktar";
            this.buttonDisaaktar.Size = new System.Drawing.Size(175, 67);
            this.buttonDisaaktar.TabIndex = 37;
            this.buttonDisaaktar.Text = "Dışa Aktar";
            this.buttonDisaaktar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDisaaktar.UseVisualStyleBackColor = false;
            // 
            // Dosyaislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(861, 372);
            this.Controls.Add(this.buttonDisaaktar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunluk);
            this.Controls.Add(this.toplam);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dosyaislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya İşlemleri";
            this.Load += new System.EventHandler(this.Dosyaislemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button gunluk;
        private System.Windows.Forms.Button toplam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDisaaktar;
    }
}