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
            txtPosiyonTipi = new TextBox();
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
            tabPage2 = new TabPage();
            dgvPorsiyon = new DataGridView();
            tabPage3 = new TabPage();
            dgvOgun = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAdminYemek).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPorsiyon).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgun).BeginInit();
            SuspendLayout();
            // 
            // dgvAdminYemek
            // 
            dgvAdminYemek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminYemek.Location = new Point(6, 6);
            dgvAdminYemek.Name = "dgvAdminYemek";
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
            // txtPosiyonTipi
            // 
            txtPosiyonTipi.Location = new Point(203, 328);
            txtPosiyonTipi.Name = "txtPosiyonTipi";
            txtPosiyonTipi.PlaceholderText = "Porsiyon Tipi";
            txtPosiyonTipi.Size = new Size(100, 23);
            txtPosiyonTipi.TabIndex = 5;
            // 
            // txtPorsiyonAdet
            // 
            txtPorsiyonAdet.Location = new Point(203, 370);
            txtPorsiyonAdet.Name = "txtPorsiyonAdet";
            txtPorsiyonAdet.PlaceholderText = "Porsiyon Adeti";
            txtPorsiyonAdet.Size = new Size(100, 23);
            txtPorsiyonAdet.TabIndex = 6;
            txtPorsiyonAdet.TextChanged += txtPorsiyonAdet_TextChanged;
            txtPorsiyonAdet.KeyPress += txtPorsiyonAdet_KeyPress;
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
            btnOgunEkle.Location = new Point(35, 379);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(197, 35);
            btnOgunEkle.TabIndex = 8;
            btnOgunEkle.Text = "Ogun Ekle";
            btnOgunEkle.UseVisualStyleBackColor = true;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(394, 307);
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
            btnOgunSil.Location = new Point(35, 337);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(197, 36);
            btnOgunSil.TabIndex = 14;
            btnOgunSil.Text = "Ogun Sil";
            btnOgunSil.UseVisualStyleBackColor = true;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // btnOgnGunc
            // 
            btnOgnGunc.Location = new Point(35, 297);
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
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 452);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
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
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPorsiyon);
            tabPage2.Controls.Add(txtPosiyonTipi);
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
            dgvPorsiyon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPorsiyon.Size = new Size(757, 221);
            dgvPorsiyon.TabIndex = 14;
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
            dgvOgun.Location = new Point(21, 15);
            dgvOgun.Name = "dgvOgun";
            dgvOgun.Size = new Size(721, 216);
            dgvOgun.TabIndex = 16;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form5";
            Text = "Form5";
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdminYemek;
        private Button btnYemekEkle;
        private TextBox txtYemekAdi;
        private TextBox txtYemekCalorie;
        private TextBox txtYemekAciklama;
        private TextBox txtPosiyonTipi;
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
    }
}