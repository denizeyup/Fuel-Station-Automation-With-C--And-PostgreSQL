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
    public partial class TankaYakitEkleme : Form
    {
        public TankaYakitEkleme()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=VeriTabaniProje; user ID=postgres; password=1234");


        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "update tanklar set tankhacim=tankhacim+'"+textBoxLitre.Text+"' where tankid='" + comboBoxTankNo.SelectedValue+ "'";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yakıt Ekleme İşlemi Başarıyla Gerçekleşmistir." + MessageBoxButtons.OK + MessageBoxIcon.Information);


            baglanti.Open();
            String sorgu1 = "select akaryakittur,tankhacim from akaryakitlar as a inner join tanklar as t \r\non a.akaryakitid= t.tanktakiurun;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();

            chartyakitekleme.DataSource = dt;
            chartyakitekleme.Series["Yakıt Seviyesi"].XValueMember = "akaryakittur";
            chartyakitekleme.Series["Yakıt Seviyesi"].YValueMembers = "tankhacim";
        }

        private void TankaYakitEkleme_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("Select * from tanklar", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxTankNo.DisplayMember = "tankno";
            comboBoxTankNo.ValueMember = "tankid";
            comboBoxTankNo.DataSource = dt2;
            baglanti.Close();

            

        }
    }
}
