namespace DiyetOtomasyon.PL
{
    partial class Form5
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
            dgvAdminYemek = new DataGridView();
            btnYemekEkle = new Button();
            txtYemekAdi = new TextBox();
            txtYemekCalorie = new TextBox();
            txtYemekAciklama = new TextBox();
            txtPorsiyonAdet = new TextBox();
            btnPorsiyonEkle = new Button();
            btnOgunEkle = new Button();
            txtOgunAdi = new TextBox();
            btnYemekSil = new Button();
            btnYemekGuncelle = new Button();
            btnPorsiyonSil = new Button();
            btnPorsiyonGuncelle = new Button();
            btnOgunSil = new Button();
            btnOgnGunc = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cmbKategori = new ComboBox();
            tabPage2 = new TabPage();
            dgvPorsiyon = new DataGridView();
            tabPage3 = new TabPage();
            dgvOgun = new DataGridView();
            tabPage4 = new TabPage();
            dgvKategoriList = new DataGridView();
            txtKatAdi = new TextBox();
            btnGunCat = new Button();
            btnEkleCat = new Button();
            btnSilKat = new Button();
            Userİslem = new TabPage();
            txtPass = new TextBox();
            txtMail = new TextBox();
            txtSoyadi = new TextBox();
            txtAdi = new TextBox();
            btnKullanıcıGunc = new Button();
            btnPersonSil = new Button();
            dgvPersons = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAdminYemek).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPorsiyon).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgun).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriList).BeginInit();
            Userİslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            SuspendLayout();
            // 
            // dgvAdminYemek
            // 
            dgvAdminYemek.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvAdminYemek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminYemek.Location = new Point(6, 6);
            dgvAdminYemek.Name = "dgvAdminYemek";
            dgvAdminYemek.ReadOnly = true;
            dgvAdminYemek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdminYemek.Size = new Size(777, 254);
            dgvAdminYemek.TabIndex = 0;
            dgvAdminYemek.CellClick += dgvAdminYemek_CellClick;
            // 
            // btnYemekEkle
            // 
            btnYemekEkle.Location = new Point(24, 389);
            btnYemekEkle.Name = "btnYemekEkle";
            btnYemekEkle.Size = new Size(100, 23);
            btnYemekEkle.TabIndex = 1;
            btnYemekEkle.Text = "Yemek Ekle";
            btnYemekEkle.UseVisualStyleBackColor = true;
            btnYemekEkle.Click += btnYemekEkle_Click;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(186, 298);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.PlaceholderText = "Yemek Adi";
            txtYemekAdi.Size = new Size(100, 23);
            txtYemekAdi.TabIndex = 2;
            // 
            // txtYemekCalorie
            // 
            txtYemekCalorie.Location = new Point(186, 340);
            txtYemekCalorie.Name = "txtYemekCalorie";
            txtYemekCalorie.PlaceholderText = "Yemek Kalorisi";
            txtYemekCalorie.Size = new Size(100, 23);
            txtYemekCalorie.TabIndex = 3;
            txtYemekCalorie.KeyPress += txtYemekCalorie_KeyPress;
            // 
            // txtYemekAciklama
            // 
            txtYemekAciklama.Location = new Point(186, 388);
            txtYemekAciklama.Name = "txtYemekAciklama";
            txtYemekAciklama.PlaceholderText = "Yemek Aciklama";
            txtYemekAciklama.Size = new Size(100, 23);
            txtYemekAciklama.TabIndex = 4;
            // 
            // txtPorsiyonAdet
            // 
            txtPorsiyonAdet.Location = new Point(203, 370);
            txtPorsiyonAdet.Name = "txtPorsiyonAdet";
            txtPorsiyonAdet.PlaceholderText = "Porsiyon Adeti";
            txtPorsiyonAdet.Size = new Size(100, 23);
            txtPorsiyonAdet.TabIndex = 6;
            // 
            // btnPorsiyonEkle
            // 
            btnPorsiyonEkle.Location = new Point(19, 387);
            btnPorsiyonEkle.Name = "btnPorsiyonEkle";
            btnPorsiyonEkle.Size = new Size(135, 23);
            btnPorsiyonEkle.TabIndex = 7;
            btnPorsiyonEkle.Text = "Porsiyon Ekle";
            btnPorsiyonEkle.UseVisualStyleBackColor = true;
            btnPorsiyonEkle.Click += btnPorsiyonEkle_Click;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.Location = new Point(38, 370);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(197, 35);
            btnOgunEkle.TabIndex = 8;
            btnOgunEkle.Text = "Ogun Ekle";
            btnOgunEkle.UseVisualStyleBackColor = true;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(397, 298);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.PlaceholderText = "Ogün Adi";
            txtOgunAdi.Size = new Size(121, 23);
            txtOgunAdi.TabIndex = 9;
            // 
            // btnYemekSil
            // 
            btnYemekSil.Location = new Point(24, 360);
            btnYemekSil.Name = "btnYemekSil";
            btnYemekSil.Size = new Size(100, 23);
            btnYemekSil.TabIndex = 10;
            btnYemekSil.Text = "Yemek Sil";
            btnYemekSil.UseVisualStyleBackColor = true;
            btnYemekSil.Click += btnYemekSil_Click;
            // 
            // btnYemekGuncelle
            // 
            btnYemekGuncelle.Location = new Point(24, 331);
            btnYemekGuncelle.Name = "btnYemekGuncelle";
            btnYemekGuncelle.Size = new Size(100, 23);
            btnYemekGuncelle.TabIndex = 11;
            btnYemekGuncelle.Text = "Yemek Guncelle";
            btnYemekGuncelle.UseVisualStyleBackColor = true;
            btnYemekGuncelle.Click += btnYemekGuncelle_Click;
            // 
            // btnPorsiyonSil
            // 
            btnPorsiyonSil.Location = new Point(19, 357);
            btnPorsiyonSil.Name = "btnPorsiyonSil";
            btnPorsiyonSil.Size = new Size(135, 23);
            btnPorsiyonSil.TabIndex = 12;
            btnPorsiyonSil.Text = "Porsiyon Sil";
            btnPorsiyonSil.UseVisualStyleBackColor = true;
            btnPorsiyonSil.Click += btnPorsiyonSil_Click;
            // 
            // btnPorsiyonGuncelle
            // 
            btnPorsiyonGuncelle.Location = new Point(19, 328);
            btnPorsiyonGuncelle.Name = "btnPorsiyonGuncelle";
            btnPorsiyonGuncelle.Size = new Size(135, 23);
            btnPorsiyonGuncelle.TabIndex = 13;
            btnPorsiyonGuncelle.Text = "Porsiyon Güncelle";
            btnPorsiyonGuncelle.UseVisualStyleBackColor = true;
            btnPorsiyonGuncelle.Click += btnPorsiyonGuncelle_Click;
            // 
            // btnOgunSil
            // 
            btnOgunSil.Location = new Point(38, 328);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(197, 36);
            btnOgunSil.TabIndex = 14;
            btnOgunSil.Text = "Ogun Sil";
            btnOgunSil.UseVisualStyleBackColor = true;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // btnOgnGunc
            // 
            btnOgnGunc.Location = new Point(38, 288);
            btnOgnGunc.Name = "btnOgnGunc";
            btnOgnGunc.Size = new Size(197, 33);
            btnOgnGunc.TabIndex = 15;
            btnOgnGunc.Text = "Ogun Guncelle";
            btnOgnGunc.UseVisualStyleBackColor = true;
            btnOgnGunc.Click += btnOgnGunc_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(Userİslem);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 452);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbKategori);
            tabPage1.Controls.Add(dgvAdminYemek);
            tabPage1.Controls.Add(btnYemekEkle);
            tabPage1.Controls.Add(txtYemekAdi);
            tabPage1.Controls.Add(txtYemekCalorie);
            tabPage1.Controls.Add(txtYemekAciklama);
            tabPage1.Controls.Add(btnYemekGuncelle);
            tabPage1.Controls.Add(btnYemekSil);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Yemek Ekle";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(326, 360);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(121, 23);
            cmbKategori.TabIndex = 12;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPorsiyon);
            tabPage2.Controls.Add(txtPorsiyonAdet);
            tabPage2.Controls.Add(btnPorsiyonEkle);
            tabPage2.Controls.Add(btnPorsiyonGuncelle);
            tabPage2.Controls.Add(btnPorsiyonSil);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Porsiyon Ekle";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPorsiyon
            // 
            dgvPorsiyon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPorsiyon.Location = new Point(19, 6);
            dgvPorsiyon.Name = "dgvPorsiyon";
            dgvPorsiyon.ReadOnly = true;
            dgvPorsiyon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPorsiyon.Size = new Size(757, 221);
            dgvPorsiyon.TabIndex = 14;
            dgvPorsiyon.CellMouseClick += dgvPorsiyon_CellMouseClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvOgun);
            tabPage3.Controls.Add(txtOgunAdi);
            tabPage3.Controls.Add(btnOgnGunc);
            tabPage3.Controls.Add(btnOgunEkle);
            tabPage3.Controls.Add(btnOgunSil);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 424);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ogun Ekle";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvOgun
            // 
            dgvOgun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgun.Location = new Point(24, 6);
            dgvOgun.Name = "dgvOgun";
            dgvOgun.ReadOnly = true;
            dgvOgun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgun.Size = new Size(721, 216);
            dgvOgun.TabIndex = 16;
            dgvOgun.CellMouseClick += dgvOgun_CellMouseClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvKategoriList);
            tabPage4.Controls.Add(txtKatAdi);
            tabPage4.Controls.Add(btnGunCat);
            tabPage4.Controls.Add(btnEkleCat);
            tabPage4.Controls.Add(btnSilKat);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(789, 424);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Kategori Ekle";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvKategoriList
            // 
            dgvKategoriList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriList.Location = new Point(34, 13);
            dgvKategoriList.Name = "dgvKategoriList";
            dgvKategoriList.ReadOnly = true;
            dgvKategoriList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategoriList.Size = new Size(721, 216);
            dgvKategoriList.TabIndex = 21;
            dgvKategoriList.CellMouseClick += dgvKategoriList_CellMouseClick;
            // 
            // txtKatAdi
            // 
            txtKatAdi.Location = new Point(407, 305);
            txtKatAdi.Name = "txtKatAdi";
            txtKatAdi.PlaceholderText = "Kategori Adi";
            txtKatAdi.Size = new Size(121, 23);
            txtKatAdi.TabIndex = 18;
            // 
            // btnGunCat
            // 
            btnGunCat.Location = new Point(48, 295);
            btnGunCat.Name = "btnGunCat";
            btnGunCat.Size = new Size(197, 33);
            btnGunCat.TabIndex = 20;
            btnGunCat.Text = "Kategori Guncelle";
            btnGunCat.UseVisualStyleBackColor = true;
            btnGunCat.Click += btnGunCat_Click;
            // 
            // btnEkleCat
            // 
            btnEkleCat.Location = new Point(48, 377);
            btnEkleCat.Name = "btnEkleCat";
            btnEkleCat.Size = new Size(197, 35);
            btnEkleCat.TabIndex = 17;
            btnEkleCat.Text = "Kategori Ekle";
            btnEkleCat.UseVisualStyleBackColor = true;
            btnEkleCat.Click += btnEkleCat_Click;
            // 
            // btnSilKat
            // 
            btnSilKat.Location = new Point(48, 335);
            btnSilKat.Name = "btnSilKat";
            btnSilKat.Size = new Size(197, 36);
            btnSilKat.TabIndex = 19;
            btnSilKat.Text = "Kategori Sil";
            btnSilKat.UseVisualStyleBackColor = true;
            btnSilKat.Click += btnSilKat_Click;
            // 
            // Userİslem
            // 
            Userİslem.Controls.Add(txtPass);
            Userİslem.Controls.Add(txtMail);
            Userİslem.Controls.Add(txtSoyadi);
            Userİslem.Controls.Add(txtAdi);
            Userİslem.Controls.Add(btnKullanıcıGunc);
            Userİslem.Controls.Add(btnPersonSil);
            Userİslem.Controls.Add(dgvPersons);
            Userİslem.Location = new Point(4, 24);
            Userİslem.Name = "Userİslem";
            Userİslem.Padding = new Padding(3);
            Userİslem.Size = new Size(789, 424);
            Userİslem.TabIndex = 4;
            Userİslem.Text = "UserIslem";
            Userİslem.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(217, 267);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Şifre";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(217, 213);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Email";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 5;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(66, 267);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.PlaceholderText = "Soyadi";
            txtSoyadi.Size = new Size(100, 23);
            txtSoyadi.TabIndex = 4;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(66, 213);
            txtAdi.Name = "txtAdi";
            txtAdi.PlaceholderText = "Adi";
            txtAdi.Size = new Size(100, 23);
            txtAdi.TabIndex = 3;
            // 
            // btnKullanıcıGunc
            // 
            btnKullanıcıGunc.Location = new Point(148, 370);
            btnKullanıcıGunc.Name = "btnKullanıcıGunc";
            btnKullanıcıGunc.Size = new Size(75, 23);
            btnKullanıcıGunc.TabIndex = 2;
            btnKullanıcıGunc.Text = "GÜNCELLE";
            btnKullanıcıGunc.UseVisualStyleBackColor = true;
            btnKullanıcıGunc.Click += btnKullanıcıGunc_Click;
            // 
            // btnPersonSil
            // 
            btnPersonSil.Location = new Point(41, 370);
            btnPersonSil.Name = "btnPersonSil";
            btnPersonSil.Size = new Size(75, 23);
            btnPersonSil.TabIndex = 1;
            btnPersonSil.Text = "SİL";
            btnPersonSil.UseVisualStyleBackColor = true;
            btnPersonSil.Click += btnPersonSil_Click;
            // 
            // dgvPersons
            // 
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(7, 6);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.ReadOnly = true;
            dgvPersons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersons.Size = new Size(776, 167);
            dgvPersons.TabIndex = 0;
            dgvPersons.CellMouseClick += dgvPersons_CellMouseClick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Paneli";
            FormClosed += Form5_FormClosed;
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdminYemek).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPorsiyon).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgun).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriList).EndInit();
            Userİslem.ResumeLayout(false);
            Userİslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnYemekEkle;
        private TextBox txtYemekAdi;
        private TextBox txtYemekCalorie;
        private TextBox txtYemekAciklama;
        private TextBox txtPorsiyonAdet;
        private Button btnPorsiyonEkle;
        private Button btnOgunEkle;
        private TextBox txtOgunAdi;
        private Button btnYemekSil;
        private Button btnYemekGuncelle;
        private Button btnPorsiyonSil;
        private Button btnPorsiyonGuncelle;
        private Button btnOgunSil;
        private Button btnOgnGunc;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvPorsiyon;
        private TabPage tabPage3;
        private DataGridView dgvOgun;
        private TabPage tabPage4;
        private DataGridView dgvKategoriList;
        private TextBox txtKatAdi;
        private Button btnGunCat;
        private Button btnEkleCat;
        private Button btnSilKat;
        private ComboBox cmbKategori;
        private DataGridView dgvAdminYemek;
        private TabPage Userİslem;
        private TextBox txtPass;
        private TextBox txtMail;
        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Button btnKullanıcıGunc;
        private Button btnPersonSil;
        private DataGridView dgvPersons;
    }
}