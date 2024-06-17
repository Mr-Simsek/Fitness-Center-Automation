using System.Windows.Forms;

namespace Fitness_Center
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Boolean b = true;


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                yeniÜyeToolStripMenuItem.Image
               = Image.FromFile(@"C:\Users\ALİ OSMAN\Source\Repos\Fitness_Center\gym icons and images\Name-48-50px\img3.jpg");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                yeniÜyeToolStripMenuItem.Image = Image.FromFile(@"C:\Users\ALİ OSMAN\Source\Repos\Fitness_Center\gym icons and images\Name-48-50px\img2.jpg");
            }
        }
        private void yeniÜyeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            yeniÜyeToolStripMenuItem.Image
             = Image.FromFile(@"C:\Users\ALİ OSMAN\Source\Repos\Fitness_Center\gym icons and images\Name-48-50px\img2.jpg");
        }

        private void yeniÜyeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YeniUye nm = new YeniUye();
            nm.Show();
        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniPersonel yp = new YeniPersonel();
            yp.Show();
        }

        private void ekipmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekipman ek = new Ekipman();
            ek.Show();
        }

        private void üyeAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeAra ua = new UyeAra();
            ua.Show();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeSil us = new UyeSil();
            us.Show();

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama Kapanacaktır,ONAYLIYORMUSUNUZ?", "GERİ", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Tekrar Hoşgeldiniz", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oturum Kapatılıyır !! Onaylıyormusunuz?", "OTURUM KAPATILDI" , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
            {
            this.Close();   
            Giris gr = new Giris();
                gr.Show();
            }
        }
    }
}
