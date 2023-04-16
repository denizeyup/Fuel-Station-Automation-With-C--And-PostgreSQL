using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Tabanı_Yönetim_Sistemleri_Proje_Ödevi
{
    public partial class GunSonuIslemleri : Form
    {
        public GunSonuIslemleri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");



        

        private void GunSonuIslemleri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "select * from kargetir()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();

            charteleman.DataSource = dt;
            charteleman.Series["Eleman"].XValueMember = "adsutun";
            charteleman.Series["Eleman"].YValueMembers = "karsutun";




            baglanti.Open();
            String sorgu1 = "select * from akaryakitgetir()";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            baglanti.Close();

            chartyakit.DataSource = dt1;
            chartyakit.Series["Yakıtlar"].XValueMember = "akaryakittipi";
            chartyakit.Series["Yakıtlar"].YValueMembers = "tlitre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection baglanti1 = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

            bool kayit_arama_durumu = false;
            baglanti1.Open();
            String sorgu1 = "select * from gunlukkargetir()";
            NpgsqlCommand selectsorgu = new NpgsqlCommand(sorgu1, baglanti1);
            selectsorgu.Connection = baglanti1;
            NpgsqlDataReader kayitokuma = selectsorgu.ExecuteReader();


            while (kayitokuma.Read())
            {

                kayit_arama_durumu = true;
                labelkar.Text = kayitokuma.GetValue(0).ToString();
                double.Parse(labelkar.Text);
                break;
            }
            baglanti1.Close();

            bool kayit_arama_durumu1 = false;
            baglanti1.Open();
            String sorgu = "select * from gunlukcirogetir()";
            NpgsqlCommand selectsorgu1 = new NpgsqlCommand(sorgu, baglanti1);
            selectsorgu.Connection = baglanti1;
            NpgsqlDataReader kayitokuma1 = selectsorgu1.ExecuteReader();


            while (kayitokuma1.Read())
            {

                kayit_arama_durumu1 = true;
                labelciro.Text = kayitokuma1.GetValue(0).ToString();
                break;
            }
            baglanti1.Close();


        }
    }
}
