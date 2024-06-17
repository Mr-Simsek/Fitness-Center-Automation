using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Center
{
    public partial class YeniUye : Form
    {
        public YeniUye()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YeniUye_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string fname = txtAd.Text;
            string lname = txtSoyad.Text;
            string cinsiyet = "";
            bool isChacked = radioButton1.Checked;
            if (isChacked)
            {

                cinsiyet = radioButton1.Text;
            }
            else
            {
                cinsiyet = radioButton2.Text;
            }
            string dob = dateTimePickerDogum.Text;
            Int64 telefon = Int64.Parse(txtBoxTelefon.Text);
            string email = txtEmail.Text;
            string uyeliktarihi = dateTimePickerUyelikTarihi.Text;
            string sporzamanı = comboBoxSporZamanı.Text;
            string adress = txtAdres.Text;
            string uyeliksüresi = comboBoxUyelikSuresi.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=MR-SIMSEK;database=gym; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into YenıUyee(Fad,Lsoyad,Cinsiyet,Dob,Telefon,Email,uyeliktarihi,SporZamanı,adress,uyeliksüresi)values('" + fname + "','" + lname + "','" + cinsiyet + "','" + dob + "'," + telefon + ",'" + email + "','" + uyeliktarihi + "','" + sporzamanı + "','" + adress + "','" + uyeliksüresi + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Kayıt Başarılı.");

        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtBoxTelefon.Clear();
            txtEmail.Clear();

            comboBoxSporZamanı.ResetText();
            comboBoxUyelikSuresi.ResetText();
            txtAdres.Clear();

            dateTimePickerDogum.Value = DateTime.Now;
            dateTimePickerUyelikTarihi.Value = DateTime.Now;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
