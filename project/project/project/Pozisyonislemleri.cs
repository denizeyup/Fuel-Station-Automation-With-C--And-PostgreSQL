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
    public partial class Pozisyonislemleri : Form
    {
        public Pozisyonislemleri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");


        private void kullanicilari_goster() // datagridwiev1 nesnesine elemanları atama form2 sayfa1
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("Select * from pozisyonpersonel", baglanti);
                DataSet dshafiza = new DataSet();
                kullannicilari_listele.Fill(dshafiza);
                dataGridViewpersonel.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void kullanicilari_goster1() // datagridwiev1 nesnesine elemanları atama form2 sayfa1
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("Select * from pozisyonmusteri", baglanti);
                DataSet dshafiza = new DataSet();
                kullannicilari_listele.Fill(dshafiza);
                dataGridViewmusteri.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }


        private void Pozisyonislemleri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "select*from pozisyonpersonel";  ////bu sorguyu düşünüp yap buraya bir fonksiyon yaz
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewpersonel.DataSource = ds.Tables[0];
            baglanti.Close();

            baglanti.Open();
            String sorgu1 = "select*from pozisyonmusteri";  ////bu sorguyu düşünüp yap buraya bir fonksiyon yaz
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridViewmusteri.DataSource = ds1.Tables[0];
            baglanti.Close();
        }

        private void buttonpersonelekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "insert into pozisyonpersonel values('" + textBoxPPAd.Text + "','" + int.Parse(textBoxPPid.Text) + "','" + int.Parse(textBoxZamyuzdesi.Text) + "')";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Pozisyon Ekleme İşlemi Başarıyla Gerçekleşmistir." + MessageBoxButtons.OK + MessageBoxIcon.Information);
            kullanicilari_goster();
        }

        private void buttonmusteriekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "insert into pozisyonmusteri values('" + textBoxMpAd.Text + "','" + int.Parse(textBoxMPid.Text) + "','" + int.Parse(textBoxindirim.Text) + "')";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Pozisyon Ekleme İşlemi Başarıyla Gerçekleşmistir." + MessageBoxButtons.OK + MessageBoxIcon.Information);
            kullanicilari_goster1();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand deletesorgu = new NpgsqlCommand("delete from pozisyonpersonel where pozisyonid=@p1", baglanti);
            deletesorgu.Parameters.AddWithValue("@p1",int.Parse(textBoxPPid.Text));
            deletesorgu.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Silindi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            kullanicilari_goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand deletesorgu = new NpgsqlCommand("delete from pozisyonmusteri where pozisyonid=@p1", baglanti);
            deletesorgu.Parameters.AddWithValue("@p1", int.Parse(textBoxMPid.Text));
            deletesorgu.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Silindi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            kullanicilari_goster1();
        }
    }
}
