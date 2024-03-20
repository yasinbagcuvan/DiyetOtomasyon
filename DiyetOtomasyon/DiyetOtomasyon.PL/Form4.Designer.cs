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
            txtAdet = new TextBox();
            dgvDayList = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cmbTip = new ComboBox();
            tabPage2 = new TabPage();
            label2 = new Label();
            btnDayList = new Button();
            tabPage3 = new TabPage();
            btnWeekList = new Button();
            dgvWeekList = new DataGridView();
            tabPage4 = new TabPage();
            btnMountList = new Button();
            dgvMountList = new DataGridView();
            tabPage5 = new TabPage();
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
            dgvYemekListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekListesi.Size = new Size(750, 121);
            dgvYemekListesi.TabIndex = 0;
            dgvYemekListesi.CellContentClick += dataGridView1_CellContentClick;
            dgvYemekListesi.MouseClick += dgvYemekListesi_MouseClick;
            // 
            // lblMealDesc
            // 
            lblMealDesc.AutoSize = true;
            lblMealDesc.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblMealDesc.Location = new Point(8, 256);
            lblMealDesc.Name = "lblMealDesc";
            lblMealDesc.Size = new Size(103, 25);
            lblMealDesc.TabIndex = 3;
            lblMealDesc.Text = "Açıklama :";
            // 
            // lblCalorie
            // 
            lblCalorie.AutoSize = true;
            lblCalorie.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblCalorie.Location = new Point(8, 218);
            lblCalorie.Name = "lblCalorie";
            lblCalorie.Size = new Size(78, 25);
            lblCalorie.TabIndex = 4;
            lblCalorie.Text = "Kalori : ";
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblMealName.Location = new Point(8, 182);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(85, 25);
            lblMealName.TabIndex = 5;
            lblMealName.Text = "Yemek : ";
            // 
            // cmbOgun
            // 
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(6, 293);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(121, 23);
            cmbOgun.TabIndex = 6;
            // 
            // btnEkleYemek
            // 
            btnEkleYemek.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkleYemek.Location = new Point(6, 377);
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
            // txtAdet
            // 
            txtAdet.Location = new Point(135, 328);
            txtAdet.Name = "txtAdet";
            txtAdet.PlaceholderText = "Miktar Yazınız";
            txtAdet.Size = new Size(100, 23);
            txtAdet.TabIndex = 10;
            txtAdet.KeyPress += txtAdet_KeyPress;
            // 
            // dgvDayList
            // 
            dgvDayList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDayList.Location = new Point(58, 100);
            dgvDayList.Name = "dgvDayList";
            dgvDayList.Size = new Size(1155, 226);
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
            tabControl1.Size = new Size(1378, 572);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbTip);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvYemekListesi);
            tabPage1.Controls.Add(txtAdet);
            tabPage1.Controls.Add(lblMealDesc);
            tabPage1.Controls.Add(lblCalorie);
            tabPage1.Controls.Add(lblMealName);
            tabPage1.Controls.Add(btnEkleYemek);
            tabPage1.Controls.Add(cmbOgun);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1370, 544);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Oğün İşleme";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // cmbTip
            // 
            cmbTip.FormattingEnabled = true;
            cmbTip.Location = new Point(8, 328);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(121, 23);
            cmbTip.TabIndex = 11;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnDayList);
            tabPage2.Controls.Add(dgvDayList);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1370, 544);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Günlük Yemek Sorgulama";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(334, 36);
            label2.Name = "label2";
            label2.Size = new Size(458, 24);
            label2.TabIndex = 13;
            label2.Text = "GUNLUK YENILEN YEMEKLER VE KALORILERI";
            // 
            // btnDayList
            // 
            btnDayList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDayList.Location = new Point(498, 384);
            btnDayList.Name = "btnDayList";
            btnDayList.Size = new Size(231, 40);
            btnDayList.TabIndex = 12;
            btnDayList.Text = "GUNLUK LISTELE";
            btnDayList.UseVisualStyleBackColor = true;
            btnDayList.Click += btnDayList_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnWeekList);
            tabPage3.Controls.Add(dgvWeekList);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1370, 544);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Haftalık Kıyas Raporu";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnWeekList
            // 
            btnWeekList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnWeekList.Location = new Point(469, 355);
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
            dgvWeekList.Location = new Point(127, 65);
            dgvWeekList.Name = "dgvWeekList";
            dgvWeekList.Size = new Size(1050, 172);
            dgvWeekList.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnMountList);
            tabPage4.Controls.Add(dgvMountList);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1370, 544);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Aylık Kıyas Raporu";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnMountList
            // 
            btnMountList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMountList.Location = new Point(464, 356);
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
            dgvMountList.Location = new Point(121, 102);
            dgvMountList.Name = "dgvMountList";
            dgvMountList.Size = new Size(1032, 167);
            dgvMountList.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btnYemekCesit);
            tabPage5.Controls.Add(dgvYemekKiyas);
            tabPage5.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1370, 544);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Yemek Çeşidi Raporu";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnYemekCesit
            // 
            btnYemekCesit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYemekCesit.Location = new Point(44, 353);
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
            dgvYemekKiyas.Location = new Point(34, 46);
            dgvYemekKiyas.Name = "dgvYemekKiyas";
            dgvYemekKiyas.Size = new Size(1280, 207);
            dgvYemekKiyas.TabIndex = 0;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 596);
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
            ((System.ComponentModel.ISupportInitialize)dgvWeekList).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMountList).EndInit();
            tabPage5.ResumeLayout(false);
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
        private TextBox txtAdet;
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
    }
}