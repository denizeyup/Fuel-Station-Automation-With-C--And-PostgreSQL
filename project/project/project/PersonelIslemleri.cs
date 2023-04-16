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
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

        private void kullanicilari_goster() // datagridwiev1 nesnesine elemanları atama form2 sayfa1
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("Select * from personeller", baglanti);
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
                NpgsqlCommand guncellekomutu = new NpgsqlCommand("update personeller set tcno='" + maskedTextBoxTc.Text + "',ad='" + textBoxAdi.Text + "',soyad='" + textBoxSoyadi.Text + "',telno='" + maskedTextBoxTel.Text + "',pozisyon='" + comboBoxPozisyon.SelectedValue + "',maas='" + textBoxmaas.Text + "',dogumtarihi='" + dateTimePicker1.Text + "' where personelid='" + textBoxpersonelid.Text + "'", baglanti);
                guncellekomutu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel Bilgileri Güncellendi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            String sorgu = "call personelekleme('" + maskedTextBoxTc.Text + "','" + textBoxAdi.Text + "','" + textBoxSoyadi.Text + "','" + maskedTextBoxTel.Text + "','" + comboBoxPozisyon.SelectedValue + "','" + textBoxmaas.Text + "','" + textBoxpersonelid.Text + "','" + dateTimePicker1.Text + "')";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Ekleme İşlemi Başarıyla Gerçekleşmistir." + MessageBoxButtons.OK + MessageBoxIcon.Information);
            kullanicilari_goster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand deletesorgu = new NpgsqlCommand("delete from personeller where personelid=@p1", baglanti);
            deletesorgu.Parameters.AddWithValue("@p1", int.Parse(textBoxpersonelid.Text));
            deletesorgu.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Silindi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            kullanicilari_goster();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            bool kayit_arama_durumu = false;
            baglanti.Open();
            String sorgu = "select * from personeller where personelid='" + textBoxAra.Text + "'";
            NpgsqlCommand selectsorgu = new NpgsqlCommand(sorgu, baglanti);
            selectsorgu.Connection = baglanti;
            NpgsqlDataReader kayitokuma = selectsorgu.ExecuteReader();

            while (kayitokuma.Read())
            {
                kayit_arama_durumu = true;
                textBoxpersonelid.Text = kayitokuma.GetValue(0).ToString();
                maskedTextBoxTc.Text = kayitokuma.GetValue(1).ToString();
                textBoxAdi.Text = kayitokuma.GetValue(2).ToString();
                textBoxSoyadi.Text = kayitokuma.GetValue(3).ToString();
                maskedTextBoxTel.Text = kayitokuma.GetValue(4).ToString();
                comboBoxPozisyon.Text = kayitokuma.GetValue(5).ToString();
                textBoxmaas.Text = kayitokuma.GetValue(6).ToString();
                dateTimePicker1.Text = kayitokuma.GetValue(7).ToString();
                break;
            }
            if (kayit_arama_durumu == false)
            {
                MessageBox.Show("Aradığınız Kayıt Listede Bulunmamaktadır!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            baglanti.Close();

        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("Select * from pozisyonpersonel", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBoxPozisyon.DisplayMember = "pozisyontipi";
            comboBoxPozisyon.ValueMember = "pozisyonid";
            comboBoxPozisyon.DataSource = dt1;
            baglanti.Close();
        }
    }
}
