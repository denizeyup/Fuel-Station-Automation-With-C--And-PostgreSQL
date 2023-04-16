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
    public partial class SatisIslemleri : Form
    {
        public SatisIslemleri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");
        private void kullanicilari_goster() // datagridwiev1 nesnesine elemanları atama form2 sayfa1
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("Select * from satilanakaryakit", baglanti);
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

        private void buttonSatisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "call satisislemlerisatisyap('" + comboBoxAkaryakit.SelectedValue + "','" + double.Parse(txtindirimtutari.Text) + "','" + textBoxPlaka.Text + "','" + comboBoxPompa.SelectedValue.ToString() + "','" + double.Parse(textBoxLitre.Text) + "','" + comboBoxSatisYapan.SelectedValue.ToString() + "','" + dateTimePicker1.Text + "','" + double.Parse(txttoplamtutar.Text) + "')";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu,baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yakıt Satın Alma İşlemi Başarıyla Gerçekleşmistir." + MessageBoxButtons.OK + MessageBoxIcon.Information);
            kullanicilari_goster();

            

            baglanti.Open();
            String sorgu1 = "update tanklar set tankhacim=tankhacim-'" + textBoxLitre.Text + "' where tanktakiurun='" + comboBoxAkaryakit.SelectedValue + "'";
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu1, baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            
        }

        private void SatisIslemleri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from personeller", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxSatisYapan.DisplayMember = "ad";
            comboBoxSatisYapan.ValueMember = "personelid";
            comboBoxSatisYapan.DataSource = dt;
            baglanti.Close();

            baglanti.Open();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("Select * from pompalar", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBoxPompa.DisplayMember = "pompaadi";
            comboBoxPompa.ValueMember = "pompaid";
            comboBoxPompa.DataSource = dt1;
            baglanti.Close();

            baglanti.Open();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("Select * from akaryakitlar", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxAkaryakit.DisplayMember = "akaryakittur";
            comboBoxAkaryakit.ValueMember = "akaryakitid";
            comboBoxAkaryakit.DataSource = dt2;
            baglanti.Close();


            

        }

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBoxAkaryakit_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlConnection baglanti1 = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

            bool kayit_arama_durumu = false;
            baglanti1.Open();
            String sorgu1 = "select * from akaryakitlar where akaryakitid='" + comboBoxAkaryakit.SelectedValue + "'";
            NpgsqlCommand selectsorgu = new NpgsqlCommand(sorgu1, baglanti1);
            selectsorgu.Connection = baglanti1;
            NpgsqlDataReader kayitokuma = selectsorgu.ExecuteReader();
  

            while (kayitokuma.Read())
            {
                
                kayit_arama_durumu = true;
                litrefiyati.Text = kayitokuma.GetValue(1).ToString();
                break;
            }
            baglanti1.Close();
        }

        private void textBoxPlaka_TextChanged(object sender, EventArgs e)
        {

            NpgsqlConnection baglanti1 = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

            bool kayit_arama_durumu = false;
            baglanti1.Open();
            String sorgu1 = "select indirimyuzdesi from pozisyonmusteri where pozisyonid=(select pozisyon from musteriler where plaka='" + textBoxPlaka.Text + "')";
            NpgsqlCommand selectsorgu = new NpgsqlCommand(sorgu1, baglanti1);
            selectsorgu.Connection = baglanti1;
            NpgsqlDataReader kayitokuma = selectsorgu.ExecuteReader();


            while (kayitokuma.Read())
            {

                kayit_arama_durumu = true;
                indirimyuzdesi.Text = kayitokuma.GetValue(0).ToString();
                break;
            }
            baglanti1.Close();
        }

        private void textBoxLitre_TextChanged(object sender, EventArgs e)
        {
            double litre =double.Parse(textBoxLitre.Text);
            double indirimyuzde = double.Parse(indirimyuzdesi.Text);
            double litrefiyat =double.Parse(litrefiyati.Text);
            

            txtindirimtutari.Text = (litrefiyat*litre*(indirimyuzde/100)).ToString();

            txttoplamtutar.Text = ((litrefiyat * litre) - double.Parse(txtindirimtutari.Text)).ToString();




        }

      
    }
}
