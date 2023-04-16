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
    public partial class Istatistikler : Form
    {
        public Istatistikler()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");


      

        private void Istatistikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "select * from yakitkaristatistik()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();

            chart1.DataSource = dt;
            chart1.Series["Yakıt Kar"].XValueMember = "akaryakit";
            chart1.Series["Yakıt Kar"].YValueMembers = "kar";

            baglanti.Open();
            String sorgu1 = "select * from elemankaristatistik()";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            baglanti.Close();

            chart2.DataSource = dt1;
            chart2.Series["Eleman Kar"].XValueMember = "adi";
            chart2.Series["Eleman Kar"].YValueMembers = "kar";


        }
    }
}
