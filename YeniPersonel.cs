using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fitness_Center
{
    public partial class YeniPersonel : Form
    {
        public YeniPersonel()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            String fad = txtAd.Text;
            string lsoyad = txtSoyad.Text;

            string cinsiyet = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                cinsiyet = radioButton1.Text;
            }
            else
            {
                cinsiyet = radioButton2.Text;
            }

            string dob = dateTimePickerDOB.Text;
            Int64 telefon = Int64.Parse(txtTelefon.Text);
            string email = txtEmail.Text;
            string uyelikTarihi = dateTimePickerUyelikTarihi.Text;
            string ulke = txtUlke.Text;
            string sehir = txtSehir.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=MR-SIMSEK;database=gym; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into YeniPersonel(Fad,Lsoyad,Cinsiyet,Dob,Telefon,Email,Üyeliktarihi,ülke,Şehir)values('" + fad + "','" + lsoyad + "','" + cinsiyet + "','" + dob + "'," + telefon + ",'" + email + "','" + uyelikTarihi + "','" + ulke + "','" + sehir + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Kayıt Başarılı.");
        }

        private void YeniPersonel_Load(object sender, EventArgs e)
        {

        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtTelefon.Clear();
            txtEmail.Clear();
            txtSehir.Clear();
            txtUlke.Clear();
            dateTimePickerDOB.Value= DateTime.Now;
            dateTimePickerUyelikTarihi.Value= DateTime.Now;
        }
    }
}
