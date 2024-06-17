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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Fitness_Center
{
    public partial class Ekipman : Form
    {
        public Ekipman()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string EkipmanAdı = txtEkipmanAdı.Text;
            string Acıklama = txtAcıklama.Text;
            string CKaslar = txtCalısanKaslar.Text;
            string TTarihi = dateTimePickerTeslimTarihi.Text;
            Int64 Tutar = Int64.Parse(txtTutar.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=MR-SIMSEK;database=gym; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Ekipman(EkipmanAdı,Acıklama,CKaslar,TTarihi,Tutar)values('" + EkipmanAdı + "','" + Acıklama + "','" + CKaslar + "','" + TTarihi + "','" + Tutar + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Kayıt Başarılı.", "Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            txtEkipmanAdı.Clear();
            txtAcıklama.Clear();
            txtCalısanKaslar.Clear();
            txtTutar.Clear();
            dateTimePickerTeslimTarihi.Value = DateTime.Now;

        }

        private void btnEkipmanGoruntule_Click(object sender, EventArgs e)
        {
          EkipmanıGoruntule eg= new EkipmanıGoruntule();
            eg.Show();
        }
    }
}
