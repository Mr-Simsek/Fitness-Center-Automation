namespace Fitness_Center
{
    partial class Ekipman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekipman));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEkipmanAdı = new TextBox();
            txtAcıklama = new RichTextBox();
            txtCalısanKaslar = new TextBox();
            dateTimePickerTeslimTarihi = new DateTimePicker();
            txtTutar = new TextBox();
            btnKaydet = new Button();
            btnSıfırla = new Button();
            btnEkipmanGoruntule = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(105, 121);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "Ekipman Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(109, 163);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(109, 260);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 2;
            label3.Text = "Çalışan Kaslar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(109, 314);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 3;
            label4.Text = "Teslim Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(109, 360);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 4;
            label5.Text = "Tutar";
            // 
            // txtEkipmanAdı
            // 
            txtEkipmanAdı.Location = new Point(224, 121);
            txtEkipmanAdı.Name = "txtEkipmanAdı";
            txtEkipmanAdı.Size = new Size(245, 27);
            txtEkipmanAdı.TabIndex = 5;
            // 
            // txtAcıklama
            // 
            txtAcıklama.Location = new Point(224, 163);
            txtAcıklama.Name = "txtAcıklama";
            txtAcıklama.Size = new Size(422, 91);
            txtAcıklama.TabIndex = 6;
            txtAcıklama.Text = "";
            // 
            // txtCalısanKaslar
            // 
            txtCalısanKaslar.Location = new Point(224, 260);
            txtCalısanKaslar.Name = "txtCalısanKaslar";
            txtCalısanKaslar.Size = new Size(245, 27);
            txtCalısanKaslar.TabIndex = 7;
            // 
            // dateTimePickerTeslimTarihi
            // 
            dateTimePickerTeslimTarihi.Format = DateTimePickerFormat.Short;
            dateTimePickerTeslimTarihi.Location = new Point(224, 314);
            dateTimePickerTeslimTarihi.Name = "dateTimePickerTeslimTarihi";
            dateTimePickerTeslimTarihi.Size = new Size(245, 27);
            dateTimePickerTeslimTarihi.TabIndex = 8;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(224, 360);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(245, 27);
            txtTutar.TabIndex = 9;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(124, 415);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSıfırla
            // 
            btnSıfırla.Location = new Point(269, 415);
            btnSıfırla.Name = "btnSıfırla";
            btnSıfırla.Size = new Size(94, 29);
            btnSıfırla.TabIndex = 11;
            btnSıfırla.Text = "Sıfırla";
            btnSıfırla.UseVisualStyleBackColor = true;
            btnSıfırla.Click += btnSıfırla_Click;
            // 
            // btnEkipmanGoruntule
            // 
            btnEkipmanGoruntule.Location = new Point(403, 415);
            btnEkipmanGoruntule.Name = "btnEkipmanGoruntule";
            btnEkipmanGoruntule.Size = new Size(155, 29);
            btnEkipmanGoruntule.TabIndex = 12;
            btnEkipmanGoruntule.Text = "Ekipmanı Görüntüle";
            btnEkipmanGoruntule.UseVisualStyleBackColor = true;
            btnEkipmanGoruntule.Click += btnEkipmanGoruntule_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Ekipman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 496);
            Controls.Add(pictureBox1);
            Controls.Add(btnEkipmanGoruntule);
            Controls.Add(btnSıfırla);
            Controls.Add(btnKaydet);
            Controls.Add(txtTutar);
            Controls.Add(dateTimePickerTeslimTarihi);
            Controls.Add(txtCalısanKaslar);
            Controls.Add(txtAcıklama);
            Controls.Add(txtEkipmanAdı);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ekipman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ekipman";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEkipmanAdı;
        private RichTextBox txtAcıklama;
        private TextBox txtCalısanKaslar;
        private DateTimePicker dateTimePickerTeslimTarihi;
        private TextBox txtTutar;
        private Button btnKaydet;
        private Button btnSıfırla;
        private Button btnEkipmanGoruntule;
        private PictureBox pictureBox1;
    }
}