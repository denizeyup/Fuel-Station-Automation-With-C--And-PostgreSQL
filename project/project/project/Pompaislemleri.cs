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
    public partial class Pompaislemleri : Form
    {
        public Pompaislemleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

        private void kullanicilari_goster() // datagridwiev1 nesnesine elemanları atama form2 sayfa1
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("Select * from pompalar", baglanti);
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
       
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "insert into pompalar values('" + textBoxPompaadi.Text + "','" + textBoxPompaid.Text + "')";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Pompa Ekleme İşlemi Başarıyla Gerçekleşmistir." + MessageBoxButtons.OK + MessageBoxIcon.Information);
            kullanicilari_goster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand deletesorgu = new NpgsqlCommand("delete from pompalar where pompaadi=@p1", baglanti);
            deletesorgu.Parameters.AddWithValue("@p1", textBoxPompaadi.Text);
            deletesorgu.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Silindi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            kullanicilari_goster();
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            bool kayit_arama_durumu = false;
            baglanti.Open();
            String sorgu = "select * from pompalar where pompaadi='" + textBoxAra.Text + "'";
            NpgsqlCommand selectsorgu = new NpgsqlCommand(sorgu, baglanti);
            selectsorgu.Connection = baglanti;
            NpgsqlDataReader kayitokuma = selectsorgu.ExecuteReader();

            while (kayitokuma.Read())
            {
                kayit_arama_durumu = true;
                textBoxPompaadi.Text = kayitokuma.GetValue(0).ToString();
                textBoxPompaid.Text = kayitokuma.GetValue(1).ToString();
                break;
            }
            if (kayit_arama_durumu == false)
            {
                MessageBox.Show("Aradığınız Kayıt Listede Bulunmamaktadır!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            baglanti.Close();
        }
    }
    }

