using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;



namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    public partial class Dosyaislemleri : Form
    {
        public Dosyaislemleri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

        

        private void gunluk_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("select * from gunlukdosya", baglanti);
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

        private void Dosyaislemleri_Load(object sender, EventArgs e)
        {
            
            
        }

        private void toplam_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlDataAdapter kullannicilari_listele = new NpgsqlDataAdapter("select * from toplamdosya", baglanti);
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
    }
}
