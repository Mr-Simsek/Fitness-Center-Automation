using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Center
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtBoxKulanıcıAdı.Text == "admin" && txtBoxSifre.Text == "admin")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Yanlış Kulanıcı Adı veya Parola", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
