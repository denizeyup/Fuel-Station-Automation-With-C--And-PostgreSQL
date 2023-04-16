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

namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

        private void kullanicilari_goster() // datagridwiev1 nesnesine elemanları atama form2 sayfa1
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("Select * from kullanicilar", baglanti);
                DataSet dshafiza = new DataSet();
                kullannicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        public void guncelle()
        {

            try
            {
                baglanti.Open();
                NpgsqlCommand guncellekomutu = new NpgsqlCommand("update kullanicilar set kullaniciadi='" + textBoxkullaniciadi.Text + "',sifre='" + textBoxsifre.Text + "' where kullaniciid='"+comboBox1.SelectedValue+"'", baglanti);
                guncellekomutu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kullanıcı Bilgileri Güncellendi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                kullanicilari_goster();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("Select * from personeller", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox1.DisplayMember = "ad";
            comboBox1.ValueMember = "personelid";
            comboBox1.DataSource = dt1;
            baglanti.Close();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                String sorgu = "insert into kullanicilar values('" + comboBox1.SelectedValue + "','" + textBoxkullaniciadi.Text + "','" + textBoxsifre.Text + "')";
                NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kullanıcı Ekleme İşlemi Başarıyla Gerçekleşmistir." + MessageBoxButtons.OK + MessageBoxIcon.Information);
                kullanicilari_goster();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
           
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand deletesorgu = new NpgsqlCommand("delete from kullanicilar where kullaniciid='" + comboBox1.SelectedValue + "'", baglanti);
                deletesorgu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydınız Silindi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                kullanicilari_goster();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
            
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
            kullanicilari_goster();
        }
    }
}
