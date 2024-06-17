namespace Fitness_Center
{
    partial class Giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            panel1 = new Panel();
            btnGiris = new Button();
            label3 = new Label();
            label2 = new Label();
            txtBoxKulanıcıAdı = new TextBox();
            txtBoxSifre = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxKulanıcıAdı);
            panel1.Controls.Add(txtBoxSifre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(750, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 327);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Gray;
            btnGiris.Location = new Point(127, 272);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(261, 35);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(152, 189);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 5;
            label3.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(152, 116);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 4;
            label2.Text = "Kulanıcı Adı";
            // 
            // txtBoxKulanıcıAdı
            // 
            txtBoxKulanıcıAdı.BackColor = Color.FromArgb(128, 255, 128);
            txtBoxKulanıcıAdı.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxKulanıcıAdı.Location = new Point(152, 142);
            txtBoxKulanıcıAdı.Name = "txtBoxKulanıcıAdı";
            txtBoxKulanıcıAdı.Size = new Size(213, 30);
            txtBoxKulanıcıAdı.TabIndex = 3;
            // 
            // txtBoxSifre
            // 
            txtBoxSifre.BackColor = Color.FromArgb(128, 255, 128);
            txtBoxSifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSifre.Location = new Point(152, 215);
            txtBoxSifre.Name = "txtBoxSifre";
            txtBoxSifre.PasswordChar = '*';
            txtBoxSifre.Size = new Size(213, 30);
            txtBoxSifre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 1;
            label1.Text = " KULANICI GİRİŞ";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1132, 565);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnGiris;
        private Label label3;
        private Label label2;
        private TextBox txtBoxKulanıcıAdı;
        private TextBox txtBoxSifre;
    }
}