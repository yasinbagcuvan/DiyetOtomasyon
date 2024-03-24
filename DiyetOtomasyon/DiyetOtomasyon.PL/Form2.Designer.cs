namespace DiyetOtomasyon.PL
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblAd = new Label();
            lblSoyad = new Label();
            lblEposta = new Label();
            lblPass = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btnKayitEkle = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAd.Location = new Point(43, 72);
            lblAd.Margin = new Padding(4, 0, 4, 0);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(101, 32);
            lblAd.TabIndex = 0;
            lblAd.Text = "Adınız :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoyad.Location = new Point(43, 132);
            lblSoyad.Margin = new Padding(4, 0, 4, 0);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(138, 32);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyadınız :";
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEposta.Location = new Point(43, 195);
            lblEposta.Margin = new Padding(4, 0, 4, 0);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(97, 32);
            lblEposta.TabIndex = 2;
            lblEposta.Text = "Email : ";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPass.Location = new Point(43, 262);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(80, 32);
            lblPass.TabIndex = 3;
            lblPass.Text = "Şifre :";
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Window;
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Location = new Point(184, 68);
            txtAd.Margin = new Padding(4, 5, 4, 5);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(141, 31);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Location = new Point(184, 128);
            txtSoyad.Margin = new Padding(4, 5, 4, 5);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(141, 31);
            txtSoyad.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(184, 192);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(184, 258);
            txtPass.Margin = new Padding(4, 5, 4, 5);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(141, 31);
            txtPass.TabIndex = 7;
            // 
            // btnKayitEkle
            // 
            btnKayitEkle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitEkle.Location = new Point(43, 352);
            btnKayitEkle.Margin = new Padding(4, 5, 4, 5);
            btnKayitEkle.Name = "btnKayitEkle";
            btnKayitEkle.Size = new Size(284, 57);
            btnKayitEkle.TabIndex = 8;
            btnKayitEkle.Text = "KAYIT OL";
            btnKayitEkle.UseVisualStyleBackColor = true;
            btnKayitEkle.Click += btnKayitEkle_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(444, 501);
            Controls.Add(btnKayitEkle);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblPass);
            Controls.Add(lblEposta);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblEposta;
        private Label lblPass;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnKayitEkle;
    }
}