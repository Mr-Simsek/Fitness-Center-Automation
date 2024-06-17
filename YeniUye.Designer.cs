
namespace Fitness_Center
{
    partial class YeniUye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniUye));
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePickerDogum = new DateTimePicker();
            txtBoxTelefon = new TextBox();
            txtEmail = new TextBox();
            dateTimePickerUyelikTarihi = new DateTimePicker();
            txtAdres = new RichTextBox();
            comboBoxSporZamanı = new ComboBox();
            comboBoxUyelikSuresi = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnKaydet = new Button();
            btnSıfırla = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(142, 96);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(142, 146);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(142, 220);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Location = new Point(213, 220);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerDogum
            // 
            dateTimePickerDogum.Format = DateTimePickerFormat.Short;
            dateTimePickerDogum.Location = new Point(158, 274);
            dateTimePickerDogum.Name = "dateTimePickerDogum";
            dateTimePickerDogum.Size = new Size(109, 27);
            dateTimePickerDogum.TabIndex = 4;
            // 
            // txtBoxTelefon
            // 
            txtBoxTelefon.Location = new Point(142, 335);
            txtBoxTelefon.Name = "txtBoxTelefon";
            txtBoxTelefon.Size = new Size(125, 27);
            txtBoxTelefon.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(461, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 6;
            // 
            // dateTimePickerUyelikTarihi
            // 
            dateTimePickerUyelikTarihi.Format = DateTimePickerFormat.Short;
            dateTimePickerUyelikTarihi.Location = new Point(461, 142);
            dateTimePickerUyelikTarihi.Name = "dateTimePickerUyelikTarihi";
            dateTimePickerUyelikTarihi.Size = new Size(125, 27);
            dateTimePickerUyelikTarihi.TabIndex = 7;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(445, 256);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(243, 117);
            txtAdres.TabIndex = 8;
            txtAdres.Text = "";
            // 
            // comboBoxSporZamanı
            // 
            comboBoxSporZamanı.FormattingEnabled = true;
            comboBoxSporZamanı.Items.AddRange(new object[] { "06:00-07:00", "08:00-09:00", "12:00-14:00", "17:00-18:00", "19:00-21:00" });
            comboBoxSporZamanı.Location = new Point(461, 214);
            comboBoxSporZamanı.Name = "comboBoxSporZamanı";
            comboBoxSporZamanı.Size = new Size(151, 28);
            comboBoxSporZamanı.TabIndex = 9;
            comboBoxSporZamanı.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxUyelikSuresi
            // 
            comboBoxUyelikSuresi.FormattingEnabled = true;
            comboBoxUyelikSuresi.Items.AddRange(new object[] { "1 AY", "2 AY", "3 AY", "6 AY", "12 AY" });
            comboBoxUyelikSuresi.Location = new Point(322, 393);
            comboBoxUyelikSuresi.Name = "comboBoxUyelikSuresi";
            comboBoxUyelikSuresi.Size = new Size(151, 28);
            comboBoxUyelikSuresi.TabIndex = 10;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 11;
            label1.Text = "Ad";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(1, 146);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 12;
            label2.Text = "Soyad";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(12, 215);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 13;
            label3.Text = "Cinsiyet";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(6, 278);
            label4.Name = "label4";
            label4.Size = new Size(146, 23);
            label4.TabIndex = 14;
            label4.Text = "Dogum Tarihi";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(12, 336);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 15;
            label5.Text = "Telefon";
            label5.TextAlign = ContentAlignment.TopRight;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(313, 96);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 16;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.TopRight;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(313, 146);
            label7.Name = "label7";
            label7.Size = new Size(142, 23);
            label7.TabIndex = 17;
            label7.Text = "Üyelik Tarihi";
            label7.TextAlign = ContentAlignment.TopRight;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(313, 215);
            label8.Name = "label8";
            label8.Size = new Size(142, 23);
            label8.TabIndex = 18;
            label8.Text = "Spor Zamanı";
            label8.TextAlign = ContentAlignment.TopRight;
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(313, 275);
            label9.Name = "label9";
            label9.Size = new Size(88, 23);
            label9.TabIndex = 19;
            label9.Text = "Adres";
            label9.TextAlign = ContentAlignment.TopRight;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.Image = (Image)resources.GetObject("label10.Image");
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(177, 398);
            label10.Name = "label10";
            label10.Size = new Size(138, 23);
            label10.TabIndex = 20;
            label10.Text = "Üyelik Süresi";
            label10.TextAlign = ContentAlignment.MiddleRight;
            label10.Click += label10_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Image = (Image)resources.GetObject("btnKaydet.Image");
            btnKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaydet.Location = new Point(231, 442);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 42);
            btnKaydet.TabIndex = 21;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextAlign = ContentAlignment.MiddleRight;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSıfırla
            // 
            btnSıfırla.Image = (Image)resources.GetObject("btnSıfırla.Image");
            btnSıfırla.ImageAlign = ContentAlignment.MiddleLeft;
            btnSıfırla.Location = new Point(361, 442);
            btnSıfırla.Name = "btnSıfırla";
            btnSıfırla.Size = new Size(94, 42);
            btnSıfırla.TabIndex = 22;
            btnSıfırla.Text = "Sıfırla";
            btnSıfırla.TextAlign = ContentAlignment.MiddleRight;
            btnSıfırla.UseVisualStyleBackColor = true;
            btnSıfırla.Click += btnSıfırla_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // YeniUye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 496);
            Controls.Add(pictureBox1);
            Controls.Add(btnSıfırla);
            Controls.Add(btnKaydet);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxUyelikSuresi);
            Controls.Add(comboBoxSporZamanı);
            Controls.Add(txtAdres);
            Controls.Add(dateTimePickerUyelikTarihi);
            Controls.Add(txtEmail);
            Controls.Add(txtBoxTelefon);
            Controls.Add(dateTimePickerDogum);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "YeniUye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += YeniUye_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePickerDogum;
        private TextBox txtBoxTelefon;
        private TextBox txtEmail;
        private DateTimePicker dateTimePickerUyelikTarihi;
        private RichTextBox txtAdres;
        private ComboBox comboBoxSporZamanı;
        private ComboBox comboBoxUyelikSuresi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnKaydet;
        private Button btnSıfırla;
        private PictureBox pictureBox1;
    }
}