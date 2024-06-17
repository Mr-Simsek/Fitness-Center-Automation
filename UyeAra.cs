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


namespace Fitness_Center
{
    public partial class UyeAra : Form
    {
        public UyeAra()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=MR-SIMSEK;database=gym; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from YenıUyee where MID =  "+ txtAra + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
               

                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Lütfen ID Bilgisini Girin", "ileti", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void UyeAra_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=MR-SIMSEK;database=gym; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from YenıUyee";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0]; 
        }
    }
}
