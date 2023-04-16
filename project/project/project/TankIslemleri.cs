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
    public partial class TankIslemleri : Form
    {
        public TankIslemleri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

        private void kullanicilari_goster() // datagridwiev1 nesnesine elemanları atama form2 sayfa1
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("Select * from tanklar", baglanti);
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
                NpgsqlCommand guncellekomutu = new NpgsqlCommand("update tanklar set tankno='" + textBoxTankNo.Text + "',tanktakiurun='" + comboBoxyakitturu.Text + "',gelisfiyati='" + textBoxgelisfiyati.Text + "',tankhacim='" + textBoxHacim.Text + "' where tankid='" + textBoxtankid.Text + "'", baglanti);
                guncellekomutu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tank Bilgileri Güncellendi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            String sorgu = "insert into tanklar values('" + textBoxtankid.Text + "','" + textBoxTankNo.Text + "','" + comboBoxyakitturu.SelectedValue + "','" + textBoxgelisfiyati.Text + "','" + textBoxHacim.Text + "')";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tank Ekleme İşlemi Başarıyla Gerçekleşmistir." + MessageBoxButtons.OK + MessageBoxIcon.Information);
            kullanicilari_goster();
        }

       
        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand deletesorgu = new NpgsqlCommand("delete  from tanklar where tankno=@p1", baglanti);
            deletesorgu.Parameters.AddWithValue("@p1", int.Parse(textBoxTankNo.Text));
            deletesorgu.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Silindi!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            kullanicilari_goster();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            bool kayit_arama_durumu = false;
            baglanti.Open();
            String sorgu = "select * from tanklar where tankno='" + textBoxAra.Text + "'";
            NpgsqlCommand selectsorgu = new NpgsqlCommand(sorgu, baglanti);
            selectsorgu.Connection = baglanti;
            NpgsqlDataReader kayitokuma = selectsorgu.ExecuteReader();

            while (kayitokuma.Read())
            {
                kayit_arama_durumu = true;
                textBoxtankid.Text = kayitokuma.GetValue(0).ToString();
                textBoxTankNo.Text = kayitokuma.GetValue(1).ToString();
                comboBoxyakitturu.Text = kayitokuma.GetValue(2).ToString();
                textBoxgelisfiyati.Text = kayitokuma.GetValue(3).ToString();
                textBoxHacim.Text = kayitokuma.GetValue(4).ToString();

                break;
            }
            if (kayit_arama_durumu == false)
            {
                MessageBox.Show("Aradığınız Kayıt Listede Bulunmamaktadır!", "Benzin İstasyonu Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            baglanti.Close();

        }

        private void buttonTanklaraYakitEkle_Click(object sender, EventArgs e)
        {
            TankaYakitEkleme tankaYakitEkleme=new TankaYakitEkleme();
            tankaYakitEkleme.Show();
            this.Hide();
            
            baglanti.Open();
            String sorgu1 = "select akaryakittur,tankhacim from akaryakitlar as a inner join tanklar as t \r\non a.akaryakitid= t.tanktakiurun;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();

            tankaYakitEkleme.chartyakitekleme.DataSource = dt;
            tankaYakitEkleme.chartyakitekleme.Series["Yakıt Seviyesi"].XValueMember = "akaryakittur";
            tankaYakitEkleme.chartyakitekleme.Series["Yakıt Seviyesi"].YValueMembers = "tankhacim";
        }

        private void TankIslemleri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("Select * from akaryakitlar", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxyakitturu.DisplayMember = "akaryakittur";
            comboBoxyakitturu.ValueMember = "akaryakitid";
            comboBoxyakitturu.DataSource = dt2;
            baglanti.Close();
        }

    }
}
