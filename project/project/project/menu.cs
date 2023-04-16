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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");

        private void satisislemleri_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SatisIslemleri satisislemleri = new SatisIslemleri();
            String sorgu = "select*from satilanakaryakit";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            satisislemleri.Show();
            satisislemleri.dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
         
        }

        private void musteriislemleri_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MusteriIslemleri musteriIslemleri= new MusteriIslemleri();      
            String sorgu = "select*from musteriler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            musteriIslemleri.Show();
            musteriIslemleri.dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
            
        }

        private void personelislemleri_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            PersonelIslemleri personelislemleri=new PersonelIslemleri();
            String sorgu = "select*from personeller";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            personelislemleri.Show();
            personelislemleri.dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void akaryakitislemleri_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            AkaryakitIslemleri akaryakitislemleri = new AkaryakitIslemleri();
            String sorgu = "select*from akaryakitlar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            akaryakitislemleri.Show();
            akaryakitislemleri.dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

       private void yakitseviyesi_Click(object sender, EventArgs e)
        {
            
            YakitSeviyesi yakitSeviyesi = new YakitSeviyesi();
            yakitSeviyesi.Show();
            baglanti.Open();
            String sorgu = "select akaryakittur,tankhacim from akaryakitlar as a inner join tanklar as t \r\non a.akaryakitid= t.tanktakiurun;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();

            yakitSeviyesi.chartyakitseviyesi.DataSource = dt;
            yakitSeviyesi.chartyakitseviyesi.Series["Yakıt Seviyesi"].XValueMember = "akaryakittur";
            yakitSeviyesi.chartyakitseviyesi.Series["Yakıt Seviyesi"].YValueMembers = "tankhacim";



        }

        private void satisraporlari_Click(object sender, EventArgs e)
        {
            Pompaislemleri satisraporlari= new Pompaislemleri();
            String sorgu = "select*from pompalar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            satisraporlari.Show();
            satisraporlari.dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();


        }

        private void tankislemleri_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            TankIslemleri tankislemleri= new TankIslemleri();
            String sorgu = "select*from tanklar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            tankislemleri.Show();
            tankislemleri.dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void gunsonuislemleri_Click(object sender, EventArgs e)
        {
            GunSonuIslemleri gunSonuIslemleri = new GunSonuIslemleri();
            gunSonuIslemleri.Show();
        }

        private void panelislemleri_Click(object sender, EventArgs e)
        {
            Pozisyonislemleri panelIslemleri = new Pozisyonislemleri();
            panelIslemleri.Show();
           
        }

       

        private void istatistik_Click(object sender, EventArgs e)
        {
            Istatistikler istatistikler= new Istatistikler();
            istatistikler.Show();
        }

        private void buttondosyaislemleri_Click(object sender, EventArgs e)
        {
            Dosyaislemleri dosyaislemleri= new Dosyaislemleri();
            dosyaislemleri.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin= new Admin();
            admin.Show();
            baglanti.Open();
          
            String sorgu = "select*from kullanicilar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);           
            admin.dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
