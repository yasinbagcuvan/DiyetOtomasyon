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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            tabPage5 = new TabPage();
            label7 = new Label();
            btnYemekCesit = new Button();
            dgvYemekKiyas = new DataGridView();
            tabPage4 = new TabPage();
            lblAylıkYemek = new Label();
            label13 = new Label();
            cmbAylıkYemek = new ComboBox();
            btnAylıkYemek = new Button();
            lblAylıkOgun = new Label();
            label11 = new Label();
            cmbAylıkOgun = new ComboBox();
            btnAylıkOgun = new Button();
            label6 = new Label();
            dgvMountList = new DataGridView();
            tabPage3 = new TabPage();
            lblYemekToplam = new Label();
            label10 = new Label();
            cmbYemekler = new ComboBox();
            btnYemekSorgu = new Button();
            lblToplamOgun = new Label();
            label8 = new Label();
            cmbOgunler = new ComboBox();
            label5 = new Label();
            btnWeekList = new Button();
            dgvWeekList = new DataGridView();
            tabPage2 = new TabPage();
            lblToplamKalori = new Label();
            label2 = new Label();
            btnDayList = new Button();
            dgvDayList = new DataGridView();
            tabPage1 = new TabPage();
            btnOgunSil = new Button();
            label9 = new Label();
            dgvOgunListem = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            cmbTip = new ComboBox();
            label1 = new Label();
            dgvYemekListesi = new DataGridView();
            lblMealDesc = new Label();
            lblCalorie = new Label();
            lblMealName = new Label();
            btnEkleYemek = new Button();
            cmbOgun = new ComboBox();
            tabControl1 = new TabControl();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYemekKiyas).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMountList).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeekList).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDayList).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgunListem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYemekListesi).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = (Image)resources.GetObject("tabPage5.BackgroundImage");
            tabPage5.BackgroundImageLayout = ImageLayout.Stretch;
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
            btnYemekCesit.Location = new Point(223, 373);
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
            dgvYemekKiyas.Location = new Point(59, 107);
            dgvYemekKiyas.Name = "dgvYemekKiyas";
            dgvYemekKiyas.ReadOnly = true;
            dgvYemekKiyas.Size = new Size(650, 212);
            dgvYemekKiyas.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(lblAylıkYemek);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(cmbAylıkYemek);
            tabPage4.Controls.Add(btnAylıkYemek);
            tabPage4.Controls.Add(lblAylıkOgun);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(cmbAylıkOgun);
            tabPage4.Controls.Add(btnAylıkOgun);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(dgvMountList);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(770, 521);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Aylık Kıyas Raporu";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblAylıkYemek
            // 
            lblAylıkYemek.AutoSize = true;
            lblAylıkYemek.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAylıkYemek.Location = new Point(472, 419);
            lblAylıkYemek.Name = "lblAylıkYemek";
            lblAylıkYemek.Size = new Size(175, 20);
            lblAylıkYemek.TabIndex = 25;
            lblAylıkYemek.Text = "Toplam Yemek Sayınız : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(472, 370);
            label13.Name = "label13";
            label13.Size = new Size(106, 20);
            label13.TabIndex = 24;
            label13.Text = "Yemek Seçiniz";
            // 
            // cmbAylıkYemek
            // 
            cmbAylıkYemek.FormattingEnabled = true;
            cmbAylıkYemek.Location = new Point(596, 367);
            cmbAylıkYemek.Name = "cmbAylıkYemek";
            cmbAylıkYemek.Size = new Size(121, 23);
            cmbAylıkYemek.TabIndex = 23;
            // 
            // btnAylıkYemek
            // 
            btnAylıkYemek.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnAylıkYemek.Location = new Point(472, 458);
            btnAylıkYemek.Name = "btnAylıkYemek";
            btnAylıkYemek.Size = new Size(267, 38);
            btnAylıkYemek.TabIndex = 22;
            btnAylıkYemek.Text = "AYLIK ÖĞÜN ÖĞREN";
            btnAylıkYemek.UseVisualStyleBackColor = true;
            btnAylıkYemek.Click += btnAylıkYemek_Click;
            // 
            // lblAylıkOgun
            // 
            lblAylıkOgun.AutoSize = true;
            lblAylıkOgun.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAylıkOgun.Location = new Point(6, 419);
            lblAylıkOgun.Name = "lblAylıkOgun";
            lblAylıkOgun.Size = new Size(167, 20);
            lblAylıkOgun.TabIndex = 21;
            lblAylıkOgun.Text = "Toplam Oğün Sayınız : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(6, 370);
            label11.Name = "label11";
            label11.Size = new Size(98, 20);
            label11.TabIndex = 20;
            label11.Text = "Oğün Seçiniz";
            // 
            // cmbAylıkOgun
            // 
            cmbAylıkOgun.FormattingEnabled = true;
            cmbAylıkOgun.Location = new Point(130, 367);
            cmbAylıkOgun.Name = "cmbAylıkOgun";
            cmbAylıkOgun.Size = new Size(121, 23);
            cmbAylıkOgun.TabIndex = 19;
            // 
            // btnAylıkOgun
            // 
            btnAylıkOgun.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnAylıkOgun.Location = new Point(6, 458);
            btnAylıkOgun.Name = "btnAylıkOgun";
            btnAylıkOgun.Size = new Size(267, 38);
            btnAylıkOgun.TabIndex = 18;
            btnAylıkOgun.Text = "AYLIK ÖĞÜN ÖĞREN";
            btnAylıkOgun.UseVisualStyleBackColor = true;
            btnAylıkOgun.Click += btnAylıkOgun_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(257, 30);
            label6.Name = "label6";
            label6.Size = new Size(221, 24);
            label6.TabIndex = 14;
            label6.Text = "AYLIK KIYAS RAPORU";
            // 
            // dgvMountList
            // 
            dgvMountList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMountList.Location = new Point(103, 91);
            dgvMountList.Name = "dgvMountList";
            dgvMountList.ReadOnly = true;
            dgvMountList.Size = new Size(544, 168);
            dgvMountList.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(lblYemekToplam);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(cmbYemekler);
            tabPage3.Controls.Add(btnYemekSorgu);
            tabPage3.Controls.Add(lblToplamOgun);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(cmbOgunler);
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
            // lblYemekToplam
            // 
            lblYemekToplam.AutoSize = true;
            lblYemekToplam.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYemekToplam.Location = new Point(479, 427);
            lblYemekToplam.Name = "lblYemekToplam";
            lblYemekToplam.Size = new Size(175, 20);
            lblYemekToplam.TabIndex = 21;
            lblYemekToplam.Text = "Toplam Yemek Sayınız : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(479, 378);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 20;
            label10.Text = "Yemek Seçiniz";
            // 
            // cmbYemekler
            // 
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(603, 375);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(121, 23);
            cmbYemekler.TabIndex = 19;
            // 
            // btnYemekSorgu
            // 
            btnYemekSorgu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnYemekSorgu.Location = new Point(479, 466);
            btnYemekSorgu.Name = "btnYemekSorgu";
            btnYemekSorgu.Size = new Size(267, 38);
            btnYemekSorgu.TabIndex = 18;
            btnYemekSorgu.Text = "HAFTALIK YEMEK ÖĞREN";
            btnYemekSorgu.UseVisualStyleBackColor = true;
            btnYemekSorgu.Click += btnYemekSorgu_Click;
            // 
            // lblToplamOgun
            // 
            lblToplamOgun.AutoSize = true;
            lblToplamOgun.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamOgun.Location = new Point(6, 427);
            lblToplamOgun.Name = "lblToplamOgun";
            lblToplamOgun.Size = new Size(167, 20);
            lblToplamOgun.TabIndex = 17;
            lblToplamOgun.Text = "Toplam Oğün Sayınız : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(6, 378);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 16;
            label8.Text = "Oğün Seçiniz";
            // 
            // cmbOgunler
            // 
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(130, 375);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(121, 23);
            cmbOgunler.TabIndex = 15;
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
            btnWeekList.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnWeekList.Location = new Point(6, 466);
            btnWeekList.Name = "btnWeekList";
            btnWeekList.Size = new Size(267, 38);
            btnWeekList.TabIndex = 1;
            btnWeekList.Text = "HAFTALIK ÖĞÜN ÖĞREN";
            btnWeekList.UseVisualStyleBackColor = true;
            btnWeekList.Click += btnWeekList_Click;
            // 
            // dgvWeekList
            // 
            dgvWeekList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWeekList.Location = new Point(82, 89);
            dgvWeekList.Name = "dgvWeekList";
            dgvWeekList.ReadOnly = true;
            dgvWeekList.Size = new Size(581, 181);
            dgvWeekList.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
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
            // dgvDayList
            // 
            dgvDayList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDayList.Location = new Point(6, 100);
            dgvDayList.Name = "dgvDayList";
            dgvDayList.ReadOnly = true;
            dgvDayList.Size = new Size(758, 226);
            dgvDayList.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(btnOgunSil);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(dgvOgunListem);
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
            // 
            // btnOgunSil
            // 
            btnOgunSil.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunSil.Location = new Point(623, 174);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(122, 38);
            btnOgunSil.TabIndex = 15;
            btnOgunSil.Text = "OĞÜN SİL";
            btnOgunSil.UseVisualStyleBackColor = true;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientActiveCaption;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(7, 3);
            label9.Name = "label9";
            label9.Size = new Size(213, 24);
            label9.TabIndex = 13;
            label9.Text = "ANLIK ÖĞÜN LISTEM";
            // 
            // dgvOgunListem
            // 
            dgvOgunListem.AccessibleRole = AccessibleRole.Row;
            dgvOgunListem.AllowUserToResizeColumns = false;
            dgvOgunListem.AllowUserToResizeRows = false;
            dgvOgunListem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunListem.Location = new Point(7, 30);
            dgvOgunListem.Name = "dgvOgunListem";
            dgvOgunListem.ReadOnly = true;
            dgvOgunListem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgunListem.Size = new Size(738, 138);
            dgvOgunListem.TabIndex = 14;
            dgvOgunListem.CellMouseClick += dgvOgunListem_CellMouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
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
            label3.BackColor = Color.White;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(6, 183);
            label1.Name = "label1";
            label1.Size = new Size(161, 24);
            label1.TabIndex = 8;
            label1.Text = "YEMEK LISTESI";
            // 
            // dgvYemekListesi
            // 
            dgvYemekListesi.AccessibleRole = AccessibleRole.Row;
            dgvYemekListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekListesi.Location = new Point(7, 218);
            dgvYemekListesi.Name = "dgvYemekListesi";
            dgvYemekListesi.ReadOnly = true;
            dgvYemekListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekListesi.Size = new Size(738, 182);
            dgvYemekListesi.TabIndex = 0;
            dgvYemekListesi.CellMouseClick += dgvYemekListesi_CellMouseClick;
            // 
            // lblMealDesc
            // 
            lblMealDesc.AutoSize = true;
            lblMealDesc.BackColor = Color.Red;
            lblMealDesc.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblMealDesc.ForeColor = SystemColors.Control;
            lblMealDesc.Location = new Point(20, 477);
            lblMealDesc.Name = "lblMealDesc";
            lblMealDesc.Size = new Size(103, 25);
            lblMealDesc.TabIndex = 3;
            lblMealDesc.Text = "Açıklama :";
            // 
            // lblCalorie
            // 
            lblCalorie.AutoSize = true;
            lblCalorie.BackColor = Color.Red;
            lblCalorie.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblCalorie.ForeColor = SystemColors.Menu;
            lblCalorie.Location = new Point(20, 439);
            lblCalorie.Name = "lblCalorie";
            lblCalorie.Size = new Size(78, 25);
            lblCalorie.TabIndex = 4;
            lblCalorie.Text = "Kalori : ";
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.BackColor = Color.Red;
            lblMealName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblMealName.ForeColor = SystemColors.Control;
            lblMealName.Location = new Point(20, 403);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(85, 25);
            lblMealName.TabIndex = 5;
            lblMealName.Text = "Yemek : ";
            // 
            // btnEkleYemek
            // 
            btnEkleYemek.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkleYemek.Location = new Point(623, 418);
            btnEkleYemek.Name = "btnEkleYemek";
            btnEkleYemek.Size = new Size(122, 84);
            btnEkleYemek.TabIndex = 7;
            btnEkleYemek.Text = "YEMEK EKLE";
            btnEkleYemek.UseVisualStyleBackColor = true;
            btnEkleYemek.Click += btnEkleYemek_Click;
            // 
            // cmbOgun
            // 
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(416, 420);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(121, 23);
            cmbOgun.TabIndex = 6;
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
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 573);
            Controls.Add(tabControl1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Paneli";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYemekKiyas).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMountList).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeekList).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDayList).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgunListem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYemekListesi).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage5;
        private Label label7;
        private Button btnYemekCesit;
        private DataGridView dgvYemekKiyas;
        private TabPage tabPage4;
        private Label lblAylıkYemek;
        private Label label13;
        private ComboBox cmbAylıkYemek;
        private Button btnAylıkYemek;
        private Label lblAylıkOgun;
        private Label label11;
        private ComboBox cmbAylıkOgun;
        private Button btnAylıkOgun;
        private Label label6;
        private DataGridView dgvMountList;
        private TabPage tabPage3;
        private Label lblYemekToplam;
        private Label label10;
        private ComboBox cmbYemekler;
        private Button btnYemekSorgu;
        private Label lblToplamOgun;
        private Label label8;
        private ComboBox cmbOgunler;
        private Label label5;
        private Button btnWeekList;
        private DataGridView dgvWeekList;
        private TabPage tabPage2;
        private Label lblToplamKalori;
        private Label label2;
        private Button btnDayList;
        private DataGridView dgvDayList;
        private TabPage tabPage1;
        private Label label9;
        private DataGridView dgvOgunListem;
        private Label label4;
        private Label label3;
        private ComboBox cmbTip;
        private Label label1;
        private DataGridView dgvYemekListesi;
        private Label lblMealDesc;
        private Label lblCalorie;
        private Label lblMealName;
        private Button btnEkleYemek;
        private ComboBox cmbOgun;
        private TabControl tabControl1;
        private Button btnOgunSil;
    }
}