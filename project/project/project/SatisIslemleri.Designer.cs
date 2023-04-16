namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    partial class SatisIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisIslemleri));
            this.comboBoxSatisYapan = new System.Windows.Forms.ComboBox();
            this.comboBoxPompa = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.indirimyuzdesi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSatisYap = new System.Windows.Forms.Button();
            this.buttonAnaSayfa = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.litrefiyati = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxLitre = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxAkaryakit = new System.Windows.Forms.ComboBox();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.txtindirimtutari = new System.Windows.Forms.TextBox();
            this.txttoplamtutar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSatisYapan
            // 
            this.comboBoxSatisYapan.FormattingEnabled = true;
            this.comboBoxSatisYapan.Location = new System.Drawing.Point(180, 91);
            this.comboBoxSatisYapan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSatisYapan.Name = "comboBoxSatisYapan";
            this.comboBoxSatisYapan.Size = new System.Drawing.Size(136, 29);
            this.comboBoxSatisYapan.TabIndex = 1;
            // 
            // comboBoxPompa
            // 
            this.comboBoxPompa.FormattingEnabled = true;
            this.comboBoxPompa.Location = new System.Drawing.Point(180, 128);
            this.comboBoxPompa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPompa.Name = "comboBoxPompa";
            this.comboBoxPompa.Size = new System.Drawing.Size(136, 29);
            this.comboBoxPompa.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 279);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 29);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "İndirim Tutarı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Satış Yapan:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Pompa:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "Tarih:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.txttoplamtutar);
            this.groupBox1.Controls.Add(this.txtindirimtutari);
            this.groupBox1.Controls.Add(this.indirimyuzdesi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSatisYap);
            this.groupBox1.Controls.Add(this.buttonAnaSayfa);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.litrefiyati);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxLitre);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.comboBoxAkaryakit);
            this.groupBox1.Controls.Add(this.textBoxPlaka);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxSatisYapan);
            this.groupBox1.Controls.Add(this.comboBoxPompa);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(423, 481);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış İşlemleri";
            // 
            // indirimyuzdesi
            // 
            this.indirimyuzdesi.AutoSize = true;
            this.indirimyuzdesi.Location = new System.Drawing.Point(334, 91);
            this.indirimyuzdesi.Name = "indirimyuzdesi";
            this.indirimyuzdesi.Size = new System.Drawing.Size(19, 23);
            this.indirimyuzdesi.TabIndex = 30;
            this.indirimyuzdesi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "TL";
            // 
            // buttonSatisYap
            // 
            this.buttonSatisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.buttonSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSatisYap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSatisYap.ForeColor = System.Drawing.Color.White;
            this.buttonSatisYap.Image = ((System.Drawing.Image)(resources.GetObject("buttonSatisYap.Image")));
            this.buttonSatisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSatisYap.Location = new System.Drawing.Point(218, 402);
            this.buttonSatisYap.Name = "buttonSatisYap";
            this.buttonSatisYap.Size = new System.Drawing.Size(161, 52);
            this.buttonSatisYap.TabIndex = 28;
            this.buttonSatisYap.Text = "Satış Yap";
            this.buttonSatisYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSatisYap.UseVisualStyleBackColor = false;
            this.buttonSatisYap.Click += new System.EventHandler(this.buttonSatisYap_Click);
            // 
            // buttonAnaSayfa
            // 
            this.buttonAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.buttonAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnaSayfa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnaSayfa.ForeColor = System.Drawing.Color.White;
            this.buttonAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnaSayfa.Image")));
            this.buttonAnaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnaSayfa.Location = new System.Drawing.Point(41, 402);
            this.buttonAnaSayfa.Name = "buttonAnaSayfa";
            this.buttonAnaSayfa.Size = new System.Drawing.Size(153, 52);
            this.buttonAnaSayfa.TabIndex = 27;
            this.buttonAnaSayfa.Text = "Anasayfa";
            this.buttonAnaSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnaSayfa.UseVisualStyleBackColor = false;
            this.buttonAnaSayfa.Click += new System.EventHandler(this.buttonAnaSayfa_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(290, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 23);
            this.label15.TabIndex = 16;
            this.label15.Text = "TL";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 350);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 23);
            this.label17.TabIndex = 14;
            this.label17.Text = "Toplam Tutar :";
            // 
            // litrefiyati
            // 
            this.litrefiyati.AutoSize = true;
            this.litrefiyati.ForeColor = System.Drawing.Color.Maroon;
            this.litrefiyati.Location = new System.Drawing.Point(183, 209);
            this.litrefiyati.Name = "litrefiyati";
            this.litrefiyati.Size = new System.Drawing.Size(19, 23);
            this.litrefiyati.TabIndex = 12;
            this.litrefiyati.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(80, 209);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 23);
            this.label19.TabIndex = 11;
            this.label19.Text = "Litre Fiyatı :";
            // 
            // textBoxLitre
            // 
            this.textBoxLitre.Location = new System.Drawing.Point(180, 240);
            this.textBoxLitre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLitre.Name = "textBoxLitre";
            this.textBoxLitre.Size = new System.Drawing.Size(137, 29);
            this.textBoxLitre.TabIndex = 4;
            this.textBoxLitre.TextChanged += new System.EventHandler(this.textBoxLitre_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(66, 246);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 23);
            this.label21.TabIndex = 8;
            this.label21.Text = "Satılan Litre :";
            // 
            // comboBoxAkaryakit
            // 
            this.comboBoxAkaryakit.FormattingEnabled = true;
            this.comboBoxAkaryakit.Location = new System.Drawing.Point(180, 165);
            this.comboBoxAkaryakit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAkaryakit.Name = "comboBoxAkaryakit";
            this.comboBoxAkaryakit.Size = new System.Drawing.Size(136, 29);
            this.comboBoxAkaryakit.TabIndex = 3;
            this.comboBoxAkaryakit.SelectedIndexChanged += new System.EventHandler(this.comboBoxAkaryakit_SelectedIndexChanged);
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Location = new System.Drawing.Point(180, 54);
            this.textBoxPlaka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(137, 29);
            this.textBoxPlaka.TabIndex = 0;
            this.textBoxPlaka.TextChanged += new System.EventHandler(this.textBoxPlaka_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(82, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 23);
            this.label23.TabIndex = 2;
            this.label23.Text = "Akaryakıt :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(114, 58);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 23);
            this.label25.TabIndex = 0;
            this.label25.Text = "Plaka :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(466, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(337, 218);
            this.dataGridView1.TabIndex = 23;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // txtindirimtutari
            // 
            this.txtindirimtutari.Location = new System.Drawing.Point(180, 315);
            this.txtindirimtutari.Name = "txtindirimtutari";
            this.txtindirimtutari.Size = new System.Drawing.Size(100, 29);
            this.txtindirimtutari.TabIndex = 31;
            // 
            // txttoplamtutar
            // 
            this.txttoplamtutar.Location = new System.Drawing.Point(180, 350);
            this.txttoplamtutar.Name = "txttoplamtutar";
            this.txttoplamtutar.Size = new System.Drawing.Size(100, 29);
            this.txttoplamtutar.TabIndex = 32;
            // 
            // SatisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(825, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SatisIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisIslemleri";
            this.Load += new System.EventHandler(this.SatisIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSatisYapan;
        private System.Windows.Forms.ComboBox comboBoxPompa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label litrefiyati;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxLitre;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxAkaryakit;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSatisYap;
        private System.Windows.Forms.Button buttonAnaSayfa;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.Label indirimyuzdesi;
        private System.Windows.Forms.TextBox txttoplamtutar;
        private System.Windows.Forms.TextBox txtindirimtutari;
    }
}