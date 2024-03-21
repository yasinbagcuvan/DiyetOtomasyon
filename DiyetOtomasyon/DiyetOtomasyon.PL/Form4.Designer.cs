namespace DiyetOtomasyon.PL
{
    partial class Form4
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
            dgvYemekListesi = new DataGridView();
            lblMealDesc = new Label();
            lblCalorie = new Label();
            lblMealName = new Label();
            cmbOgun = new ComboBox();
            btnEkleYemek = new Button();
            label1 = new Label();
            dgvDayList = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            cmbTip = new ComboBox();
            tabPage2 = new TabPage();
            lblToplamKalori = new Label();
            label2 = new Label();
            btnDayList = new Button();
            tabPage3 = new TabPage();
            label5 = new Label();
            btnWeekList = new Button();
            dgvWeekList = new DataGridView();
            tabPage4 = new TabPage();
            label6 = new Label();
            btnMountList = new Button();
            dgvMountList = new DataGridView();
            tabPage5 = new TabPage();
            label7 = new Label();
            btnYemekCesit = new Button();
            dgvYemekKiyas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvYemekListesi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDayList).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeekList).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMountList).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYemekKiyas).BeginInit();
            SuspendLayout();
            // 
            // dgvYemekListesi
            // 
            dgvYemekListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekListesi.Location = new Point(7, 58);
            dgvYemekListesi.Name = "dgvYemekListesi";
            dgvYemekListesi.ReadOnly = true;
            dgvYemekListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekListesi.Size = new Size(738, 285);
            dgvYemekListesi.TabIndex = 0;
            dgvYemekListesi.CellContentClick += dataGridView1_CellContentClick;
            dgvYemekListesi.CellMouseClick += dgvYemekListesi_CellMouseClick;
            dgvYemekListesi.MouseClick += dgvYemekListesi_MouseClick;
            // 
            // lblMealDesc
            // 
            lblMealDesc.AutoSize = true;
            lblMealDesc.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblMealDesc.Location = new Point(20, 477);
            lblMealDesc.Name = "lblMealDesc";
            lblMealDesc.Size = new Size(103, 25);
            lblMealDesc.TabIndex = 3;
            lblMealDesc.Text = "Açıklama :";
            // 
            // lblCalorie
            // 
            lblCalorie.AutoSize = true;
            lblCalorie.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblCalorie.Location = new Point(20, 439);
            lblCalorie.Name = "lblCalorie";
            lblCalorie.Size = new Size(78, 25);
            lblCalorie.TabIndex = 4;
            lblCalorie.Text = "Kalori : ";
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblMealName.Location = new Point(20, 403);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(85, 25);
            lblMealName.TabIndex = 5;
            lblMealName.Text = "Yemek : ";
            // 
            // cmbOgun
            // 
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(416, 420);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(121, 23);
            cmbOgun.TabIndex = 6;
            // 
            // btnEkleYemek
            // 
            btnEkleYemek.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkleYemek.Location = new Point(623, 418);
            btnEkleYemek.Name = "btnEkleYemek";
            btnEkleYemek.Size = new Size(122, 38);
            btnEkleYemek.TabIndex = 7;
            btnEkleYemek.Text = "EKLE";
            btnEkleYemek.UseVisualStyleBackColor = true;
            btnEkleYemek.Click += btnEkleYemek_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(161, 24);
            label1.TabIndex = 8;
            label1.Text = "YEMEK LISTESI";
            // 
            // dgvDayList
            // 
            dgvDayList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDayList.Location = new Point(6, 100);
            dgvDayList.Name = "dgvDayList";
            dgvDayList.ReadOnly = true;
            dgvDayList.Size = new Size(758, 226);
            dgvDayList.TabIndex = 11;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(778, 549);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cmbTip);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvYemekListesi);
            tabPage1.Controls.Add(lblMealDesc);
            tabPage1.Controls.Add(lblCalorie);
            tabPage1.Controls.Add(lblMealName);
            tabPage1.Controls.Add(btnEkleYemek);
            tabPage1.Controls.Add(cmbOgun);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(770, 521);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Oğün İşleme";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(309, 418);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 13;
            label4.Text = "Öğün : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(305, 479);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 12;
            label3.Text = "Porsiyon : ";
            // 
            // cmbTip
            // 
            cmbTip.FormattingEnabled = true;
            cmbTip.Location = new Point(416, 481);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(121, 23);
            cmbTip.TabIndex = 11;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblToplamKalori);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnDayList);
            tabPage2.Controls.Add(dgvDayList);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(770, 521);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Günlük Yemek Sorgulama";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamKalori.Location = new Point(6, 345);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(194, 32);
            lblToplamKalori.TabIndex = 14;
            lblToplamKalori.Text = "Toplam Kalori : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(148, 41);
            label2.Name = "label2";
            label2.Size = new Size(458, 24);
            label2.TabIndex = 13;
            label2.Text = "GUNLUK YENILEN YEMEKLER VE KALORILERI";
            // 
            // btnDayList
            // 
            btnDayList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDayList.Location = new Point(276, 393);
            btnDayList.Name = "btnDayList";
            btnDayList.Size = new Size(231, 40);
            btnDayList.TabIndex = 12;
            btnDayList.Text = "GUNLUK LISTELE";
            btnDayList.UseVisualStyleBackColor = true;
            btnDayList.Click += btnDayList_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(btnWeekList);
            tabPage3.Controls.Add(dgvWeekList);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(770, 521);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Haftalık Kıyas Raporu";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(241, 25);
            label5.Name = "label5";
            label5.Size = new Size(263, 24);
            label5.TabIndex = 14;
            label5.Text = "HAFTALIK KIYAS RAPORU";
            // 
            // btnWeekList
            // 
            btnWeekList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnWeekList.Location = new Point(197, 354);
            btnWeekList.Name = "btnWeekList";
            btnWeekList.Size = new Size(361, 63);
            btnWeekList.TabIndex = 1;
            btnWeekList.Text = "HAFTALIK LISTELE";
            btnWeekList.UseVisualStyleBackColor = true;
            btnWeekList.Click += btnWeekList_Click;
            // 
            // dgvWeekList
            // 
            dgvWeekList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWeekList.Location = new Point(130, 93);
            dgvWeekList.Name = "dgvWeekList";
            dgvWeekList.ReadOnly = true;
            dgvWeekList.Size = new Size(482, 181);
            dgvWeekList.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(btnMountList);
            tabPage4.Controls.Add(dgvMountList);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(770, 521);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Aylık Kıyas Raporu";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(261, 46);
            label6.Name = "label6";
            label6.Size = new Size(221, 24);
            label6.TabIndex = 14;
            label6.Text = "AYLIK KIYAS RAPORU";
            // 
            // btnMountList
            // 
            btnMountList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMountList.Location = new Point(196, 356);
            btnMountList.Name = "btnMountList";
            btnMountList.Size = new Size(345, 57);
            btnMountList.TabIndex = 1;
            btnMountList.Text = "AYLIK LISTE";
            btnMountList.UseVisualStyleBackColor = true;
            btnMountList.Click += btnMountList_Click;
            // 
            // dgvMountList
            // 
            dgvMountList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMountList.Location = new Point(123, 99);
            dgvMountList.Name = "dgvMountList";
            dgvMountList.ReadOnly = true;
            dgvMountList.Size = new Size(464, 168);
            dgvMountList.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(btnYemekCesit);
            tabPage5.Controls.Add(dgvYemekKiyas);
            tabPage5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(770, 521);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Yemek Çeşidi Raporu";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientActiveCaption;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(250, 53);
            label7.Name = "label7";
            label7.Size = new Size(243, 24);
            label7.TabIndex = 15;
            label7.Text = "YEMEK ÇEŞİDİ RAPORU";
            // 
            // btnYemekCesit
            // 
            btnYemekCesit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYemekCesit.Location = new Point(223, 350);
            btnYemekCesit.Name = "btnYemekCesit";
            btnYemekCesit.Size = new Size(287, 82);
            btnYemekCesit.TabIndex = 1;
            btnYemekCesit.Text = "GOSTER";
            btnYemekCesit.UseVisualStyleBackColor = true;
            btnYemekCesit.Click += btnYemekCesit_Click;
            // 
            // dgvYemekKiyas
            // 
            dgvYemekKiyas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekKiyas.Location = new Point(163, 120);
            dgvYemekKiyas.Name = "dgvYemekKiyas";
            dgvYemekKiyas.ReadOnly = true;
            dgvYemekKiyas.Size = new Size(404, 169);
            dgvYemekKiyas.TabIndex = 0;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 573);
            Controls.Add(tabControl1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYemekListesi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDayList).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeekList).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMountList).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYemekKiyas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvYemekListesi;
        private Label lblMealDesc;
        private Label lblCalorie;
        private Label lblMealName;
        private ComboBox cmbOgun;
        private Button btnEkleYemek;
        private Label label1;
        private DataGridView dgvDayList;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox cmbTip;
        private Button btnDayList;
        private Label label2;
        private Button btnWeekList;
        private DataGridView dgvWeekList;
        private TabPage tabPage4;
        private Button btnMountList;
        private DataGridView dgvMountList;
        private TabPage tabPage5;
        private Button btnYemekCesit;
        private DataGridView dgvYemekKiyas;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblToplamKalori;
    }
}