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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 150);
            dataGridView1.TabIndex = 0;
            // 
            // btnYemekEkle
            // 
            btnYemekEkle.Location = new Point(30, 395);
            btnYemekEkle.Name = "btnYemekEkle";
            btnYemekEkle.Size = new Size(100, 23);
            btnYemekEkle.TabIndex = 1;
            btnYemekEkle.Text = "Yemek Ekle";
            btnYemekEkle.UseVisualStyleBackColor = true;
            btnYemekEkle.Click += btnYemekEkle_Click;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(30, 193);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.PlaceholderText = "Yemek Adi";
            txtYemekAdi.Size = new Size(100, 23);
            txtYemekAdi.TabIndex = 2;
            // 
            // txtYemekCalorie
            // 
            txtYemekCalorie.Location = new Point(30, 235);
            txtYemekCalorie.Name = "txtYemekCalorie";
            txtYemekCalorie.PlaceholderText = "Yemek Kalorisi";
            txtYemekCalorie.Size = new Size(100, 23);
            txtYemekCalorie.TabIndex = 3;
            txtYemekCalorie.KeyPress += txtYemekCalorie_KeyPress;
            // 
            // txtYemekAciklama
            // 
            txtYemekAciklama.Location = new Point(30, 283);
            txtYemekAciklama.Name = "txtYemekAciklama";
            txtYemekAciklama.PlaceholderText = "Yemek Aciklama";
            txtYemekAciklama.Size = new Size(100, 23);
            txtYemekAciklama.TabIndex = 4;
            // 
            // txtPosiyonTipi
            // 
            txtPosiyonTipi.Location = new Point(213, 193);
            txtPosiyonTipi.Name = "txtPosiyonTipi";
            txtPosiyonTipi.PlaceholderText = "Porsiyon Tipi";
            txtPosiyonTipi.Size = new Size(100, 23);
            txtPosiyonTipi.TabIndex = 5;
            // 
            // txtPorsiyonAdet
            // 
            txtPorsiyonAdet.Location = new Point(213, 235);
            txtPorsiyonAdet.Name = "txtPorsiyonAdet";
            txtPorsiyonAdet.PlaceholderText = "Porsiyon Adeti";
            txtPorsiyonAdet.Size = new Size(100, 23);
            txtPorsiyonAdet.TabIndex = 6;
            txtPorsiyonAdet.TextChanged += txtPorsiyonAdet_TextChanged;
            txtPorsiyonAdet.KeyPress += txtPorsiyonAdet_KeyPress;
            // 
            // btnPorsiyonEkle
            // 
            btnPorsiyonEkle.Location = new Point(213, 405);
            btnPorsiyonEkle.Name = "btnPorsiyonEkle";
            btnPorsiyonEkle.Size = new Size(135, 23);
            btnPorsiyonEkle.TabIndex = 7;
            btnPorsiyonEkle.Text = "Porsiyon Ekle";
            btnPorsiyonEkle.UseVisualStyleBackColor = true;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.Location = new Point(420, 405);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(130, 23);
            btnOgunEkle.TabIndex = 8;
            btnOgunEkle.Text = "Ogun Ekle";
            btnOgunEkle.UseVisualStyleBackColor = true;
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(420, 193);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.PlaceholderText = "Ogün Adi";
            txtOgunAdi.Size = new Size(100, 23);
            txtOgunAdi.TabIndex = 9;
            // 
            // btnYemekSil
            // 
            btnYemekSil.Location = new Point(30, 366);
            btnYemekSil.Name = "btnYemekSil";
            btnYemekSil.Size = new Size(100, 23);
            btnYemekSil.TabIndex = 10;
            btnYemekSil.Text = "Yemek Sil";
            btnYemekSil.UseVisualStyleBackColor = true;
            // 
            // btnYemekGuncelle
            // 
            btnYemekGuncelle.Location = new Point(30, 337);
            btnYemekGuncelle.Name = "btnYemekGuncelle";
            btnYemekGuncelle.Size = new Size(100, 23);
            btnYemekGuncelle.TabIndex = 11;
            btnYemekGuncelle.Text = "Yemek Guncelle";
            btnYemekGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnPorsiyonSil
            // 
            btnPorsiyonSil.Location = new Point(213, 375);
            btnPorsiyonSil.Name = "btnPorsiyonSil";
            btnPorsiyonSil.Size = new Size(135, 23);
            btnPorsiyonSil.TabIndex = 12;
            btnPorsiyonSil.Text = "Porsiyon Sil";
            btnPorsiyonSil.UseVisualStyleBackColor = true;
            // 
            // btnPorsiyonGuncelle
            // 
            btnPorsiyonGuncelle.Location = new Point(213, 346);
            btnPorsiyonGuncelle.Name = "btnPorsiyonGuncelle";
            btnPorsiyonGuncelle.Size = new Size(135, 23);
            btnPorsiyonGuncelle.TabIndex = 13;
            btnPorsiyonGuncelle.Text = "Porsiyon Güncelle";
            btnPorsiyonGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnOgunSil
            // 
            btnOgunSil.Location = new Point(420, 376);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(130, 23);
            btnOgunSil.TabIndex = 14;
            btnOgunSil.Text = "Ogun Sil";
            btnOgunSil.UseVisualStyleBackColor = true;
            // 
            // btnOgnGunc
            // 
            btnOgnGunc.Location = new Point(420, 346);
            btnOgnGunc.Name = "btnOgnGunc";
            btnOgnGunc.Size = new Size(130, 23);
            btnOgnGunc.TabIndex = 15;
            btnOgnGunc.Text = "Ogun Guncelle";
            btnOgnGunc.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOgnGunc);
            Controls.Add(btnOgunSil);
            Controls.Add(btnPorsiyonGuncelle);
            Controls.Add(btnPorsiyonSil);
            Controls.Add(btnYemekGuncelle);
            Controls.Add(btnYemekSil);
            Controls.Add(txtOgunAdi);
            Controls.Add(btnOgunEkle);
            Controls.Add(btnPorsiyonEkle);
            Controls.Add(txtPorsiyonAdet);
            Controls.Add(txtPosiyonTipi);
            Controls.Add(txtYemekAciklama);
            Controls.Add(txtYemekCalorie);
            Controls.Add(txtYemekAdi);
            Controls.Add(btnYemekEkle);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
    }
}