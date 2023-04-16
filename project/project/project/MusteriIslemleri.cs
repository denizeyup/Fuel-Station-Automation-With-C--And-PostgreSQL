using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }
        
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

        private void kullanicilari_goster() // datagridwiev1 nesnesine elemanları atama form2 sayfa1
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("Select * from musteriler", baglanti);
                DataSet dshafiza = new DataSet();
                kullannicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Akaryakıt İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        public void guncelle()
        {

            try
            {
                baglanti.Open();
                NpgsqlCommand guncellekomutu = new NpgsqlCommand("update musteriler set pozisyon='" + comboBoxPozisyon.SelectedValue + "',ad='" + textBoxAdi.Text + "',soyad='" + textBoxSoyadi.Text + "',plaka='" + textBoxPlaka.Text + "',telno='" + maskedTextBoxTel.Text + "' where tcno='" + maskedTextBoxTC.Text + "'", baglanti);
                guncellekomutu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Bilgileri Güncellendi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                kullanicilari_goster();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "call musteriekleme('" + maskedTextBoxTC.Text + "','" + textBoxAdi.Text + "','" + textBoxSoyadi.Text + "','" + maskedTextBoxTel.Text + "','" + comboBoxPozisyon.SelectedValue + "','" + textBoxPlaka.Text + "')";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Ekleme İşlemi Başarıyla Gerçekleşmistir." + MessageBoxButtons.OK + MessageBoxIcon.Information);
            kullanicilari_goster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand deletesorgu = new NpgsqlCommand("delete  from musteriler where tcno=@p1", baglanti);
            deletesorgu.Parameters.AddWithValue("@p1",(maskedTextBoxTC.Text));
            deletesorgu.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Silindi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            kullanicilari_goster();
               
            
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            bool kayit_arama_durumu = false;
            baglanti.Open();
            String sorgu = "select * from musteriler where tcno='" + textBoxTcAra.Text + "'";
            NpgsqlCommand selectsorgu = new NpgsqlCommand(sorgu, baglanti);
            selectsorgu.Connection = baglanti;
            NpgsqlDataReader kayitokuma = selectsorgu.ExecuteReader();

            while (kayitokuma.Read())
            {
                kayit_arama_durumu = true;
                maskedTextBoxTC.Text = kayitokuma.GetValue(0).ToString();
                textBoxAdi.Text = kayitokuma.GetValue(1).ToString();
                textBoxSoyadi.Text = kayitokuma.GetValue(2).ToString();
                maskedTextBoxTel.Text = kayitokuma.GetValue(4).ToString();
                comboBoxPozisyon.Text = kayitokuma.GetValue(5).ToString();
                textBoxPlaka.Text = kayitokuma.GetValue(3).ToString();
                break;
            }
            if (kayit_arama_durumu == false)
            {
                MessageBox.Show("Aradığınız Kayıt Listede Bulunmamaktadır!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            baglanti.Close();


        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();

            
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("Select * from pozisyonmusteri", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBoxPozisyon.DisplayMember = "pozisyontipi";
            comboBoxPozisyon.ValueMember = "pozisyonid";
            comboBoxPozisyon.DataSource = dt1;
            baglanti.Close();
        }
    }
}
