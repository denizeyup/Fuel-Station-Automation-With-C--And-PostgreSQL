namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonyonetici = new System.Windows.Forms.RadioButton();
            this.radioButtonKullanici = new System.Windows.Forms.RadioButton();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.cikis = new System.Windows.Forms.Button();
            this.gir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.radioButtonyonetici);
            this.groupBox1.Controls.Add(this.radioButtonKullanici);
            this.groupBox1.Controls.Add(this.imgUser);
            this.groupBox1.Controls.Add(this.cikis);
            this.groupBox1.Controls.Add(this.gir);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // radioButtonyonetici
            // 
            this.radioButtonyonetici.AutoSize = true;
            this.radioButtonyonetici.Location = new System.Drawing.Point(196, 143);
            this.radioButtonyonetici.Name = "radioButtonyonetici";
            this.radioButtonyonetici.Size = new System.Drawing.Size(90, 21);
            this.radioButtonyonetici.TabIndex = 8;
            this.radioButtonyonetici.TabStop = true;
            this.radioButtonyonetici.Text = "Yönetici";
            this.radioButtonyonetici.UseVisualStyleBackColor = true;
            // 
            // radioButtonKullanici
            // 
            this.radioButtonKullanici.AutoSize = true;
            this.radioButtonKullanici.Location = new System.Drawing.Point(92, 142);
            this.radioButtonKullanici.Name = "radioButtonKullanici";
            this.radioButtonKullanici.Size = new System.Drawing.Size(93, 21);
            this.radioButtonKullanici.TabIndex = 7;
            this.radioButtonKullanici.TabStop = true;
            this.radioButtonKullanici.Text = "Kullanıcı";
            this.radioButtonKullanici.UseVisualStyleBackColor = true;
            // 
            // imgUser
            // 
            this.imgUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(259, 18);
            this.imgUser.Margin = new System.Windows.Forms.Padding(4);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(48, 48);
            this.imgUser.TabIndex = 6;
            this.imgUser.TabStop = false;
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.OrangeRed;
            this.cikis.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikis.Location = new System.Drawing.Point(102, 171);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 36);
            this.cikis.TabIndex = 5;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // gir
            // 
            this.gir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gir.Location = new System.Drawing.Point(196, 170);
            this.gir.Name = "gir";
            this.gir.Size = new System.Drawing.Size(75, 37);
            this.gir.TabIndex = 4;
            this.gir.Text = "Giriş";
            this.gir.UseVisualStyleBackColor = false;
            this.gir.Click += new System.EventHandler(this.gir_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(139, 24);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 24);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(619, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Akaryakıt Otomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button gir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.RadioButton radioButtonyonetici;
        private System.Windows.Forms.RadioButton radioButtonKullanici;
    }
}

