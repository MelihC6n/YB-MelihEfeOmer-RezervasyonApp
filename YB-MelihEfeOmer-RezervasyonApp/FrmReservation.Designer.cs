﻿namespace YB_MelihEfeOmer_RezervasyonApp
{
    partial class FrmReservation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservation));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            exitButton = new PictureBox();
            label1 = new Label();
            panel5 = new Panel();
            groupBox1 = new GroupBox();
            dgvRezervasyonlar = new DataGridView();
            btnSil = new Button();
            btnGüncelle = new Button();
            btnListele = new Button();
            grpReservationDetails = new GroupBox();
            grpRooms = new GroupBox();
            cmbOdaTipi = new ComboBox();
            btnRezervasyonaBasla = new Button();
            label4 = new Label();
            lblToplamTutar = new Label();
            label14 = new Label();
            label5 = new Label();
            cmbOda = new ComboBox();
            btnOdaBul = new Button();
            dtpCikisTarihi = new DateTimePicker();
            dtpGirisTarihi = new DateTimePicker();
            nudKisiSayisi = new NumericUpDown();
            cmbOtelAdi = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            grpPersonalDetails = new GroupBox();
            İleriButonu = new Label();
            GeriButonu = new Label();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtSoyadi = new TextBox();
            txtKimlikNo = new TextBox();
            txtAdi = new TextBox();
            label13 = new Label();
            dtpDogumTarihi = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label22 = new Label();
            btnKaydet = new Button();
            label3 = new Label();
            label10 = new Label();
            grpGüncelleme = new GroupBox();
            grpOdaGüncelleme = new GroupBox();
            cmbOdaTipiGüncelleme = new ComboBox();
            btnGüncellemeRezervasyonaBasla = new Button();
            label16 = new Label();
            label17 = new Label();
            cmbOdaGüncelleme = new ComboBox();
            btnGüncellemeOdaBul = new Button();
            dtpCikisTarihiGüncelleme = new DateTimePicker();
            dtpGirisTarihiGüncelleme = new DateTimePicker();
            label18 = new Label();
            label20 = new Label();
            minimalizeButton = new PictureBox();
            pictureBox1 = new PictureBox();
            label19 = new Label();
            txtKimlikAra = new TextBox();
            label21 = new Label();
            tabArama = new TabControl();
            pgKimlik = new TabPage();
            pgAd = new TabPage();
            txtAdAra = new TextBox();
            pgRez = new TabPage();
            txtRezAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).BeginInit();
            grpReservationDetails.SuspendLayout();
            grpRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKisiSayisi).BeginInit();
            grpPersonalDetails.SuspendLayout();
            grpGüncelleme.SuspendLayout();
            grpOdaGüncelleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimalizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabArama.SuspendLayout();
            pgKimlik.SuspendLayout();
            pgAd.SuspendLayout();
            pgRez.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 1100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1165, 0);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 1100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGreen;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(6, 0);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1159, 7);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGreen;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(6, 1093);
            panel4.Margin = new Padding(5, 4, 5, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1159, 7);
            panel4.TabIndex = 3;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Image = Properties.Resources.icons8_close_351;
            exitButton.Location = new Point(1117, 12);
            exitButton.Margin = new Padding(5, 4, 5, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(41, 47);
            exitButton.SizeMode = PictureBoxSizeMode.CenterImage;
            exitButton.TabIndex = 4;
            exitButton.TabStop = false;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 20);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 42);
            label1.TabIndex = 6;
            label1.Text = "Rezervasyon Formu";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(14, 63);
            panel5.Margin = new Padding(5, 4, 5, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1143, 3);
            panel5.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dgvRezervasyonlar);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(6, 732);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(1159, 361);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyonlar";
            // 
            // dgvRezervasyonlar
            // 
            dgvRezervasyonlar.AllowUserToAddRows = false;
            dgvRezervasyonlar.AllowUserToDeleteRows = false;
            dgvRezervasyonlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRezervasyonlar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRezervasyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvRezervasyonlar.DefaultCellStyle = dataGridViewCellStyle1;
            dgvRezervasyonlar.Dock = DockStyle.Fill;
            dgvRezervasyonlar.Location = new Point(5, 31);
            dgvRezervasyonlar.Margin = new Padding(3, 4, 3, 4);
            dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            dgvRezervasyonlar.ReadOnly = true;
            dgvRezervasyonlar.RowHeadersWidth = 51;
            dgvRezervasyonlar.Size = new Size(1149, 326);
            dgvRezervasyonlar.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.White;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F);
            btnSil.ForeColor = Color.Black;
            btnSil.Location = new Point(751, 681);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(195, 43);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.White;
            btnGüncelle.FlatStyle = FlatStyle.Flat;
            btnGüncelle.Font = new Font("Segoe UI", 12F);
            btnGüncelle.ForeColor = Color.Black;
            btnGüncelle.Location = new Point(491, 681);
            btnGüncelle.Margin = new Padding(3, 4, 3, 4);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(195, 43);
            btnGüncelle.TabIndex = 1;
            btnGüncelle.Text = "Güncelleme Ekranı";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.White;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Segoe UI", 12F);
            btnListele.ForeColor = Color.Black;
            btnListele.Location = new Point(232, 681);
            btnListele.Margin = new Padding(3, 4, 3, 4);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(195, 43);
            btnListele.TabIndex = 1;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // grpReservationDetails
            // 
            grpReservationDetails.BackColor = Color.Transparent;
            grpReservationDetails.Controls.Add(grpRooms);
            grpReservationDetails.Controls.Add(btnOdaBul);
            grpReservationDetails.Controls.Add(dtpCikisTarihi);
            grpReservationDetails.Controls.Add(dtpGirisTarihi);
            grpReservationDetails.Controls.Add(nudKisiSayisi);
            grpReservationDetails.Controls.Add(cmbOtelAdi);
            grpReservationDetails.Controls.Add(label8);
            grpReservationDetails.Controls.Add(label6);
            grpReservationDetails.Controls.Add(label7);
            grpReservationDetails.Controls.Add(label2);
            grpReservationDetails.FlatStyle = FlatStyle.Flat;
            grpReservationDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpReservationDetails.ForeColor = Color.White;
            grpReservationDetails.Location = new Point(14, 79);
            grpReservationDetails.Margin = new Padding(3, 4, 3, 4);
            grpReservationDetails.Name = "grpReservationDetails";
            grpReservationDetails.Padding = new Padding(3, 4, 3, 4);
            grpReservationDetails.Size = new Size(416, 589);
            grpReservationDetails.TabIndex = 9;
            grpReservationDetails.TabStop = false;
            grpReservationDetails.Text = "Rezervasyon Bilgilerini Giriniz";
            // 
            // grpRooms
            // 
            grpRooms.BackColor = Color.Transparent;
            grpRooms.Controls.Add(cmbOdaTipi);
            grpRooms.Controls.Add(btnRezervasyonaBasla);
            grpRooms.Controls.Add(label4);
            grpRooms.Controls.Add(lblToplamTutar);
            grpRooms.Controls.Add(label14);
            grpRooms.Controls.Add(label5);
            grpRooms.Controls.Add(cmbOda);
            grpRooms.Enabled = false;
            grpRooms.FlatStyle = FlatStyle.Flat;
            grpRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpRooms.ForeColor = Color.White;
            grpRooms.Location = new Point(7, 308);
            grpRooms.Margin = new Padding(3, 4, 3, 4);
            grpRooms.Name = "grpRooms";
            grpRooms.Padding = new Padding(3, 4, 3, 4);
            grpRooms.Size = new Size(398, 273);
            grpRooms.TabIndex = 12;
            grpRooms.TabStop = false;
            grpRooms.Text = "Bilgilerinize Göre Müsait Oda Tipleri ve Odalar";
            // 
            // cmbOdaTipi
            // 
            cmbOdaTipi.BackColor = Color.White;
            cmbOdaTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOdaTipi.FlatStyle = FlatStyle.Flat;
            cmbOdaTipi.FormattingEnabled = true;
            cmbOdaTipi.Location = new Point(153, 63);
            cmbOdaTipi.Margin = new Padding(3, 4, 3, 4);
            cmbOdaTipi.Name = "cmbOdaTipi";
            cmbOdaTipi.Size = new Size(210, 36);
            cmbOdaTipi.TabIndex = 4;
            cmbOdaTipi.SelectedIndexChanged += cmbOdaTipi_SelectedIndexChanged;
            // 
            // btnRezervasyonaBasla
            // 
            btnRezervasyonaBasla.BackColor = Color.White;
            btnRezervasyonaBasla.FlatStyle = FlatStyle.Flat;
            btnRezervasyonaBasla.ForeColor = Color.Black;
            btnRezervasyonaBasla.Location = new Point(153, 223);
            btnRezervasyonaBasla.Margin = new Padding(3, 4, 3, 4);
            btnRezervasyonaBasla.Name = "btnRezervasyonaBasla";
            btnRezervasyonaBasla.Size = new Size(210, 43);
            btnRezervasyonaBasla.TabIndex = 1;
            btnRezervasyonaBasla.Text = "Rezervasyona Başla";
            btnRezervasyonaBasla.UseVisualStyleBackColor = false;
            btnRezervasyonaBasla.Click += btnRezervasyonaBasla_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 69);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 2;
            label4.Text = "Oda Tipi :";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamTutar.Location = new Point(250, 168);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(0, 28);
            lblToplamTutar.TabIndex = 2;
            lblToplamTutar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 168);
            label14.Name = "label14";
            label14.Size = new Size(135, 28);
            label14.TabIndex = 2;
            label14.Text = "Toplam Tutar :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 113);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 2;
            label5.Text = "Oda Seçiniz :";
            // 
            // cmbOda
            // 
            cmbOda.BackColor = Color.White;
            cmbOda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOda.FlatStyle = FlatStyle.Flat;
            cmbOda.FormattingEnabled = true;
            cmbOda.Location = new Point(153, 109);
            cmbOda.Margin = new Padding(3, 4, 3, 4);
            cmbOda.Name = "cmbOda";
            cmbOda.Size = new Size(210, 36);
            cmbOda.TabIndex = 4;
            // 
            // btnOdaBul
            // 
            btnOdaBul.BackColor = Color.White;
            btnOdaBul.FlatStyle = FlatStyle.Flat;
            btnOdaBul.ForeColor = Color.Black;
            btnOdaBul.Location = new Point(257, 244);
            btnOdaBul.Margin = new Padding(3, 4, 3, 4);
            btnOdaBul.Name = "btnOdaBul";
            btnOdaBul.Size = new Size(113, 43);
            btnOdaBul.TabIndex = 1;
            btnOdaBul.Text = "Oda Bul";
            btnOdaBul.UseVisualStyleBackColor = false;
            btnOdaBul.Click += btnOdaBul_Click;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(160, 151);
            dtpCikisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(210, 34);
            dtpCikisTarihi.TabIndex = 6;
            dtpCikisTarihi.Value = new DateTime(2024, 7, 24, 12, 36, 49, 513);
            dtpCikisTarihi.ValueChanged += dtpCikisTarihi_ValueChanged;
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Location = new Point(160, 104);
            dtpGirisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(210, 34);
            dtpGirisTarihi.TabIndex = 6;
            dtpGirisTarihi.Value = new DateTime(2024, 7, 24, 12, 36, 49, 514);
            dtpGirisTarihi.ValueChanged += dtpGirisTarihi_ValueChanged;
            // 
            // nudKisiSayisi
            // 
            nudKisiSayisi.BorderStyle = BorderStyle.FixedSingle;
            nudKisiSayisi.Location = new Point(160, 204);
            nudKisiSayisi.Margin = new Padding(3, 4, 3, 4);
            nudKisiSayisi.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudKisiSayisi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudKisiSayisi.Name = "nudKisiSayisi";
            nudKisiSayisi.Size = new Size(82, 34);
            nudKisiSayisi.TabIndex = 5;
            nudKisiSayisi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbOtelAdi
            // 
            cmbOtelAdi.BackColor = Color.White;
            cmbOtelAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtelAdi.FlatStyle = FlatStyle.Flat;
            cmbOtelAdi.FormattingEnabled = true;
            cmbOtelAdi.Location = new Point(160, 57);
            cmbOtelAdi.Margin = new Padding(3, 4, 3, 4);
            cmbOtelAdi.Name = "cmbOtelAdi";
            cmbOtelAdi.Size = new Size(210, 36);
            cmbOtelAdi.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 159);
            label8.Name = "label8";
            label8.Size = new Size(112, 28);
            label8.TabIndex = 2;
            label8.Text = "Çıkış Tarihi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 207);
            label6.Name = "label6";
            label6.Size = new Size(105, 28);
            label6.TabIndex = 2;
            label6.Text = "Kişi Sayısı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 112);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 2;
            label7.Text = "Giriş Tarihi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 61);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 2;
            label2.Text = "Otel Adı :";
            // 
            // grpPersonalDetails
            // 
            grpPersonalDetails.BackColor = Color.Transparent;
            grpPersonalDetails.Controls.Add(İleriButonu);
            grpPersonalDetails.Controls.Add(GeriButonu);
            grpPersonalDetails.Controls.Add(txtAdres);
            grpPersonalDetails.Controls.Add(txtEmail);
            grpPersonalDetails.Controls.Add(txtTelefon);
            grpPersonalDetails.Controls.Add(txtSoyadi);
            grpPersonalDetails.Controls.Add(txtKimlikNo);
            grpPersonalDetails.Controls.Add(txtAdi);
            grpPersonalDetails.Controls.Add(label13);
            grpPersonalDetails.Controls.Add(dtpDogumTarihi);
            grpPersonalDetails.Controls.Add(label12);
            grpPersonalDetails.Controls.Add(label11);
            grpPersonalDetails.Controls.Add(label9);
            grpPersonalDetails.Controls.Add(label22);
            grpPersonalDetails.Controls.Add(btnKaydet);
            grpPersonalDetails.Controls.Add(label3);
            grpPersonalDetails.Controls.Add(label10);
            grpPersonalDetails.Enabled = false;
            grpPersonalDetails.FlatStyle = FlatStyle.Flat;
            grpPersonalDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpPersonalDetails.ForeColor = Color.White;
            grpPersonalDetails.Location = new Point(749, 79);
            grpPersonalDetails.Margin = new Padding(3, 4, 3, 4);
            grpPersonalDetails.Name = "grpPersonalDetails";
            grpPersonalDetails.Padding = new Padding(3, 4, 3, 4);
            grpPersonalDetails.Size = new Size(409, 589);
            grpPersonalDetails.TabIndex = 11;
            grpPersonalDetails.TabStop = false;
            grpPersonalDetails.Text = "? Misafirin Bilgilerini Giriniz";
            // 
            // İleriButonu
            // 
            İleriButonu.AutoSize = true;
            İleriButonu.Enabled = false;
            İleriButonu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            İleriButonu.Location = new Point(275, 469);
            İleriButonu.Name = "İleriButonu";
            İleriButonu.Size = new Size(48, 32);
            İleriButonu.TabIndex = 7;
            İleriButonu.Text = ">>";
            İleriButonu.Click += İleriButonu_Click;
            // 
            // GeriButonu
            // 
            GeriButonu.AutoSize = true;
            GeriButonu.Enabled = false;
            GeriButonu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            GeriButonu.Location = new Point(211, 469);
            GeriButonu.Name = "GeriButonu";
            GeriButonu.Size = new Size(48, 32);
            GeriButonu.TabIndex = 7;
            GeriButonu.Text = "<<";
            GeriButonu.Click += GeriButonu_Click;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.White;
            txtAdres.BorderStyle = BorderStyle.FixedSingle;
            txtAdres.ForeColor = Color.Black;
            txtAdres.Location = new Point(153, 247);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.ScrollBars = ScrollBars.Vertical;
            txtAdres.Size = new Size(218, 119);
            txtAdres.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(153, 421);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 34);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.White;
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.ForeColor = Color.Black;
            txtTelefon.Location = new Point(153, 375);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(218, 34);
            txtTelefon.TabIndex = 3;
            // 
            // txtSoyadi
            // 
            txtSoyadi.BackColor = Color.White;
            txtSoyadi.BorderStyle = BorderStyle.FixedSingle;
            txtSoyadi.ForeColor = Color.Black;
            txtSoyadi.Location = new Point(153, 153);
            txtSoyadi.Margin = new Padding(3, 4, 3, 4);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(218, 34);
            txtSoyadi.TabIndex = 3;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.BackColor = Color.White;
            txtKimlikNo.BorderStyle = BorderStyle.FixedSingle;
            txtKimlikNo.ForeColor = Color.Black;
            txtKimlikNo.Location = new Point(153, 59);
            txtKimlikNo.Margin = new Padding(3, 4, 3, 4);
            txtKimlikNo.MaxLength = 11;
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(218, 34);
            txtKimlikNo.TabIndex = 3;
            // 
            // txtAdi
            // 
            txtAdi.BackColor = Color.White;
            txtAdi.BorderStyle = BorderStyle.FixedSingle;
            txtAdi.ForeColor = Color.Black;
            txtAdi.Location = new Point(153, 107);
            txtAdi.Margin = new Padding(3, 4, 3, 4);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(218, 34);
            txtAdi.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(79, 423);
            label13.Name = "label13";
            label13.Size = new Size(73, 28);
            label13.TabIndex = 2;
            label13.Text = "Email'i:";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(153, 200);
            dtpDogumTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(218, 34);
            dtpDogumTarihi.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(61, 376);
            label12.Name = "label12";
            label12.Size = new Size(94, 28);
            label12.TabIndex = 2;
            label12.Text = "Telefonu :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(77, 252);
            label11.Name = "label11";
            label11.Size = new Size(76, 28);
            label11.TabIndex = 2;
            label11.Text = "Adresi :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(73, 155);
            label9.Name = "label9";
            label9.Size = new Size(81, 28);
            label9.TabIndex = 2;
            label9.Text = "Soyadı :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(49, 61);
            label22.Name = "label22";
            label22.Size = new Size(107, 28);
            label22.TabIndex = 2;
            label22.Text = "Kimlik No :";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.White;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(210, 528);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(113, 43);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 112);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 2;
            label3.Text = "Adı :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 207);
            label10.Name = "label10";
            label10.Size = new Size(138, 28);
            label10.TabIndex = 2;
            label10.Text = "Doğum Tarihi :";
            // 
            // grpGüncelleme
            // 
            grpGüncelleme.BackColor = Color.Transparent;
            grpGüncelleme.Controls.Add(grpOdaGüncelleme);
            grpGüncelleme.Controls.Add(btnGüncellemeOdaBul);
            grpGüncelleme.Controls.Add(dtpCikisTarihiGüncelleme);
            grpGüncelleme.Controls.Add(dtpGirisTarihiGüncelleme);
            grpGüncelleme.Controls.Add(label18);
            grpGüncelleme.Controls.Add(label20);
            grpGüncelleme.FlatStyle = FlatStyle.Flat;
            grpGüncelleme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpGüncelleme.ForeColor = Color.White;
            grpGüncelleme.Location = new Point(14, 79);
            grpGüncelleme.Margin = new Padding(3, 4, 3, 4);
            grpGüncelleme.Name = "grpGüncelleme";
            grpGüncelleme.Padding = new Padding(3, 4, 3, 4);
            grpGüncelleme.Size = new Size(416, 589);
            grpGüncelleme.TabIndex = 12;
            grpGüncelleme.TabStop = false;
            grpGüncelleme.Text = "Güncel Rezervasyon Bilgilerini Giriniz";
            // 
            // grpOdaGüncelleme
            // 
            grpOdaGüncelleme.BackColor = Color.Transparent;
            grpOdaGüncelleme.Controls.Add(cmbOdaTipiGüncelleme);
            grpOdaGüncelleme.Controls.Add(btnGüncellemeRezervasyonaBasla);
            grpOdaGüncelleme.Controls.Add(label16);
            grpOdaGüncelleme.Controls.Add(label17);
            grpOdaGüncelleme.Controls.Add(cmbOdaGüncelleme);
            grpOdaGüncelleme.FlatStyle = FlatStyle.Flat;
            grpOdaGüncelleme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpOdaGüncelleme.ForeColor = Color.White;
            grpOdaGüncelleme.Location = new Point(7, 319);
            grpOdaGüncelleme.Margin = new Padding(3, 4, 3, 4);
            grpOdaGüncelleme.Name = "grpOdaGüncelleme";
            grpOdaGüncelleme.Padding = new Padding(3, 4, 3, 4);
            grpOdaGüncelleme.Size = new Size(398, 263);
            grpOdaGüncelleme.TabIndex = 12;
            grpOdaGüncelleme.TabStop = false;
            grpOdaGüncelleme.Text = "Bilgilerinize Göre Müsait Oda Tipleri ve Odalar";
            // 
            // cmbOdaTipiGüncelleme
            // 
            cmbOdaTipiGüncelleme.BackColor = Color.White;
            cmbOdaTipiGüncelleme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOdaTipiGüncelleme.FlatStyle = FlatStyle.Flat;
            cmbOdaTipiGüncelleme.FormattingEnabled = true;
            cmbOdaTipiGüncelleme.Location = new Point(153, 73);
            cmbOdaTipiGüncelleme.Margin = new Padding(3, 4, 3, 4);
            cmbOdaTipiGüncelleme.Name = "cmbOdaTipiGüncelleme";
            cmbOdaTipiGüncelleme.Size = new Size(210, 36);
            cmbOdaTipiGüncelleme.TabIndex = 4;
            // 
            // btnGüncellemeRezervasyonaBasla
            // 
            btnGüncellemeRezervasyonaBasla.BackColor = Color.White;
            btnGüncellemeRezervasyonaBasla.FlatStyle = FlatStyle.Flat;
            btnGüncellemeRezervasyonaBasla.ForeColor = Color.Black;
            btnGüncellemeRezervasyonaBasla.Location = new Point(153, 167);
            btnGüncellemeRezervasyonaBasla.Margin = new Padding(3, 4, 3, 4);
            btnGüncellemeRezervasyonaBasla.Name = "btnGüncellemeRezervasyonaBasla";
            btnGüncellemeRezervasyonaBasla.Size = new Size(210, 43);
            btnGüncellemeRezervasyonaBasla.TabIndex = 1;
            btnGüncellemeRezervasyonaBasla.Text = "Rezervasyona Başla";
            btnGüncellemeRezervasyonaBasla.UseVisualStyleBackColor = false;
            btnGüncellemeRezervasyonaBasla.Click += btnGüncellemeRezervasyonaBasla_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(61, 77);
            label16.Name = "label16";
            label16.Size = new Size(95, 28);
            label16.TabIndex = 2;
            label16.Text = "Oda Tipi :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(34, 124);
            label17.Name = "label17";
            label17.Size = new Size(123, 28);
            label17.TabIndex = 2;
            label17.Text = "Oda Seçiniz :";
            // 
            // cmbOdaGüncelleme
            // 
            cmbOdaGüncelleme.BackColor = Color.White;
            cmbOdaGüncelleme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOdaGüncelleme.FlatStyle = FlatStyle.Flat;
            cmbOdaGüncelleme.FormattingEnabled = true;
            cmbOdaGüncelleme.Location = new Point(153, 120);
            cmbOdaGüncelleme.Margin = new Padding(3, 4, 3, 4);
            cmbOdaGüncelleme.Name = "cmbOdaGüncelleme";
            cmbOdaGüncelleme.Size = new Size(210, 36);
            cmbOdaGüncelleme.TabIndex = 4;
            // 
            // btnGüncellemeOdaBul
            // 
            btnGüncellemeOdaBul.BackColor = Color.White;
            btnGüncellemeOdaBul.FlatStyle = FlatStyle.Flat;
            btnGüncellemeOdaBul.ForeColor = Color.Black;
            btnGüncellemeOdaBul.Location = new Point(257, 197);
            btnGüncellemeOdaBul.Margin = new Padding(3, 4, 3, 4);
            btnGüncellemeOdaBul.Name = "btnGüncellemeOdaBul";
            btnGüncellemeOdaBul.Size = new Size(113, 43);
            btnGüncellemeOdaBul.TabIndex = 1;
            btnGüncellemeOdaBul.Text = "Oda Bul";
            btnGüncellemeOdaBul.UseVisualStyleBackColor = false;
            btnGüncellemeOdaBul.Click += btnGüncellemeOdaBul_Click;
            // 
            // dtpCikisTarihiGüncelleme
            // 
            dtpCikisTarihiGüncelleme.Location = new Point(160, 151);
            dtpCikisTarihiGüncelleme.Margin = new Padding(3, 4, 3, 4);
            dtpCikisTarihiGüncelleme.Name = "dtpCikisTarihiGüncelleme";
            dtpCikisTarihiGüncelleme.Size = new Size(210, 34);
            dtpCikisTarihiGüncelleme.TabIndex = 6;
            // 
            // dtpGirisTarihiGüncelleme
            // 
            dtpGirisTarihiGüncelleme.Location = new Point(160, 104);
            dtpGirisTarihiGüncelleme.Margin = new Padding(3, 4, 3, 4);
            dtpGirisTarihiGüncelleme.Name = "dtpGirisTarihiGüncelleme";
            dtpGirisTarihiGüncelleme.Size = new Size(210, 34);
            dtpGirisTarihiGüncelleme.TabIndex = 6;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(41, 159);
            label18.Name = "label18";
            label18.Size = new Size(112, 28);
            label18.TabIndex = 2;
            label18.Text = "Çıkış Tarihi :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(50, 112);
            label20.Name = "label20";
            label20.Size = new Size(111, 28);
            label20.TabIndex = 2;
            label20.Text = "Giriş Tarihi :";
            // 
            // minimalizeButton
            // 
            minimalizeButton.Cursor = Cursors.Hand;
            minimalizeButton.Image = Properties.Resources.icons8_minimize_35;
            minimalizeButton.Location = new Point(1063, 12);
            minimalizeButton.Margin = new Padding(5, 4, 5, 4);
            minimalizeButton.Name = "minimalizeButton";
            minimalizeButton.Size = new Size(41, 47);
            minimalizeButton.SizeMode = PictureBoxSizeMode.CenterImage;
            minimalizeButton.TabIndex = 5;
            minimalizeButton.TabStop = false;
            minimalizeButton.Click += minimalizeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(544, 12);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += minimalizeButton_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label19.ForeColor = Color.White;
            label19.Location = new Point(503, 125);
            label19.Name = "label19";
            label19.Size = new Size(198, 32);
            label19.TabIndex = 2;
            label19.Text = "Otel mi? Trivago!";
            // 
            // txtKimlikAra
            // 
            txtKimlikAra.BackColor = Color.White;
            txtKimlikAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKimlikAra.ForeColor = Color.Black;
            txtKimlikAra.Location = new Point(9, 8);
            txtKimlikAra.Margin = new Padding(3, 4, 3, 4);
            txtKimlikAra.Name = "txtKimlikAra";
            txtKimlikAra.Size = new Size(233, 34);
            txtKimlikAra.TabIndex = 3;
            txtKimlikAra.TextChanged += txtKimlikAra_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label21.ForeColor = Color.White;
            label21.Location = new Point(491, 517);
            label21.Name = "label21";
            label21.Size = new Size(212, 28);
            label21.TabIndex = 2;
            label21.Text = "Aranacak Rezarvasyon";
            // 
            // tabArama
            // 
            tabArama.Controls.Add(pgKimlik);
            tabArama.Controls.Add(pgAd);
            tabArama.Controls.Add(pgRez);
            tabArama.Location = new Point(458, 564);
            tabArama.Margin = new Padding(3, 4, 3, 4);
            tabArama.Name = "tabArama";
            tabArama.SelectedIndex = 0;
            tabArama.Size = new Size(258, 92);
            tabArama.TabIndex = 13;
            // 
            // pgKimlik
            // 
            pgKimlik.BackColor = Color.SeaGreen;
            pgKimlik.Controls.Add(txtKimlikAra);
            pgKimlik.Location = new Point(4, 29);
            pgKimlik.Margin = new Padding(3, 4, 3, 4);
            pgKimlik.Name = "pgKimlik";
            pgKimlik.Padding = new Padding(3, 4, 3, 4);
            pgKimlik.Size = new Size(250, 59);
            pgKimlik.TabIndex = 0;
            pgKimlik.Text = "KİMLİK ";
            // 
            // pgAd
            // 
            pgAd.BackColor = Color.SeaGreen;
            pgAd.Controls.Add(txtAdAra);
            pgAd.Location = new Point(4, 29);
            pgAd.Margin = new Padding(3, 4, 3, 4);
            pgAd.Name = "pgAd";
            pgAd.Padding = new Padding(3, 4, 3, 4);
            pgAd.Size = new Size(250, 59);
            pgAd.TabIndex = 1;
            pgAd.Text = "İSİM";
            // 
            // txtAdAra
            // 
            txtAdAra.BackColor = Color.White;
            txtAdAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdAra.ForeColor = Color.Black;
            txtAdAra.Location = new Point(8, 8);
            txtAdAra.Margin = new Padding(3, 4, 3, 4);
            txtAdAra.Name = "txtAdAra";
            txtAdAra.Size = new Size(233, 34);
            txtAdAra.TabIndex = 4;
            txtAdAra.TextChanged += txtAdAra_TextChanged;
            // 
            // pgRez
            // 
            pgRez.BackColor = Color.SeaGreen;
            pgRez.Controls.Add(txtRezAra);
            pgRez.Location = new Point(4, 29);
            pgRez.Margin = new Padding(3, 4, 3, 4);
            pgRez.Name = "pgRez";
            pgRez.Size = new Size(250, 59);
            pgRez.TabIndex = 2;
            pgRez.Text = "REZ. NO";
            // 
            // txtRezAra
            // 
            txtRezAra.BackColor = Color.White;
            txtRezAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtRezAra.ForeColor = Color.Black;
            txtRezAra.Location = new Point(8, 8);
            txtRezAra.Margin = new Padding(3, 4, 3, 4);
            txtRezAra.Name = "txtRezAra";
            txtRezAra.Size = new Size(233, 34);
            txtRezAra.TabIndex = 4;
            txtRezAra.TextChanged += txtRezAra_TextChanged;
            // 
            // FrmReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1171, 1100);
            Controls.Add(tabArama);
            Controls.Add(btnSil);
            Controls.Add(label1);
            Controls.Add(btnGüncelle);
            Controls.Add(btnListele);
            Controls.Add(exitButton);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label21);
            Controls.Add(label19);
            Controls.Add(minimalizeButton);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(grpPersonalDetails);
            Controls.Add(grpReservationDetails);
            Controls.Add(grpGüncelleme);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezervasyon Formu";
            Load += FrmReservation_Load;
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).EndInit();
            grpReservationDetails.ResumeLayout(false);
            grpReservationDetails.PerformLayout();
            grpRooms.ResumeLayout(false);
            grpRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKisiSayisi).EndInit();
            grpPersonalDetails.ResumeLayout(false);
            grpPersonalDetails.PerformLayout();
            grpGüncelleme.ResumeLayout(false);
            grpGüncelleme.PerformLayout();
            grpOdaGüncelleme.ResumeLayout(false);
            grpOdaGüncelleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimalizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabArama.ResumeLayout(false);
            pgKimlik.ResumeLayout(false);
            pgKimlik.PerformLayout();
            pgAd.ResumeLayout(false);
            pgAd.PerformLayout();
            pgRez.ResumeLayout(false);
            pgRez.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox exitButton;
        private Label label1;
        private Panel panel5;
        private GroupBox groupBox1;
        private DataGridView dgvRezervasyonlar;
        private GroupBox grpReservationDetails;
        private Label label2;
        private Button btnRezervasyonaBasla;
        private GroupBox grpPersonalDetails;
        private TextBox txtAdi;
        private Label label3;
        private ComboBox cmbOdaTipi;
        private ComboBox cmbOtelAdi;
        private Label label4;
        private NumericUpDown nudKisiSayisi;
        private ComboBox cmbOda;
        private Label label5;
        private DateTimePicker dtpGirisTarihi;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpCikisTarihi;
        private Label label8;
        private GroupBox grpRooms;
        private Button btnOdaBul;
        private TextBox txtAdres;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtSoyadi;
        private Label label13;
        private DateTimePicker dtpDogumTarihi;
        private Label label12;
        private Label label11;
        private Label label9;
        private Button btnKaydet;
        private Label label10;
        private Label İleriButonu;
        private Label GeriButonu;
        private GroupBox grpGüncelleme;
        private GroupBox grpOdaGüncelleme;
        private ComboBox cmbOdaTipiGüncelleme;
        private Button btnGüncellemeRezervasyonaBasla;
        private Label label16;
        private Label label17;
        private ComboBox cmbOdaGüncelleme;
        private Button btnGüncellemeOdaBul;
        private DateTimePicker dtpCikisTarihiGüncelleme;
        private DateTimePicker dtpGirisTarihiGüncelleme;
        private Label label18;
        private Label label20;
        private PictureBox minimalizeButton;
        private PictureBox pictureBox1;
        private Label label19;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnListele;
        private TextBox txtKimlikAra;
        private Label label21;
        private TextBox txtKimlikNo;
        private Label label22;
        private TabControl tabArama;
        private TabPage pgKimlik;
        private TabPage pgAd;
        private TabPage pgRez;
        private TextBox txtAdAra;
        private TextBox txtRezAra;
        private Label lblToplamTutar;
        private Label label14;
    }
}