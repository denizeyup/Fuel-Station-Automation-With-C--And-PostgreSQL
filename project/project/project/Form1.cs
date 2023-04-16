using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }


        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");
        NpgsqlConnection baglanti1 = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");
        NpgsqlConnection baglanti2 = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");


        bool durum;
        public void cikisyap() // ÇIKIŞ YAPMA METODU
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //herhangi bir işlem yok
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            cikisyap();
        }

        private void gir_Click(object sender, EventArgs e)
        {
            if (radioButtonKullanici.Checked)
            {

                baglanti1.Open();
                String sorgu1 = "select * from kullanicigiris() ";
                NpgsqlCommand selectsorgu1 = new NpgsqlCommand(sorgu1, baglanti2);
                selectsorgu1.Connection = baglanti1;
                NpgsqlDataReader kayitokuma1 = selectsorgu1.ExecuteReader();

                while (kayitokuma1.Read())
                {
                    if (kayitokuma1["kullaniciad"].ToString() == textBox1.Text && kayitokuma1["sifree"].ToString() == textBox2.Text)
                    {
                        durum = true;
                        AnaSayfa anasayfa = new AnaSayfa();
                        anasayfa.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Veya Parola Yanlış" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                    }
                    break;
                }
            }
                baglanti2.Close();
                



                if (radioButtonyonetici.Checked)
                {

                    baglanti2.Open();
                    String sorgu2 = "select * from yoneticigiris() ";
                    NpgsqlCommand selectsorgu2 = new NpgsqlCommand(sorgu2, baglanti2);
                    selectsorgu2.Connection = baglanti2;
                    NpgsqlDataReader kayitokuma2 = selectsorgu2.ExecuteReader();

                    while (kayitokuma2.Read())
                    {
                        if (kayitokuma2["kullaniciad"].ToString() == textBox1.Text && kayitokuma2["sifree"].ToString() == textBox2.Text)
                        {
                            durum = true;
                            AnaSayfa anasayfa = new AnaSayfa();
                            anasayfa.Show();
                            this.Hide();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Adı Veya Parola Yanlış" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                        }
                        break;
                    }
                    baglanti2.Close();

                }

            }


        }
    }


 
    

