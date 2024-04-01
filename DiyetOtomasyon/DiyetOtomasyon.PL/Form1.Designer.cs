namespace DiyetOtomasyon.PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblHosgeldiniz = new Label();
            btnGiris = new Button();
            btnKayit = new Button();
            SuspendLayout();
            // 
            // lblHosgeldiniz
            // 
            lblHosgeldiniz.AutoSize = true;
            lblHosgeldiniz.BackColor = SystemColors.GradientInactiveCaption;
            lblHosgeldiniz.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHosgeldiniz.ForeColor = SystemColors.MenuHighlight;
            lblHosgeldiniz.Location = new Point(151, 35);
            lblHosgeldiniz.Name = "lblHosgeldiniz";
            lblHosgeldiniz.Size = new Size(442, 29);
            lblHosgeldiniz.TabIndex = 0;
            lblHosgeldiniz.Text = "DIYET UYGULAMASINA HOSGELDINIZ";
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(276, 151);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(232, 52);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayit
            // 
            btnKayit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayit.Location = new Point(276, 247);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(232, 52);
            btnKayit.TabIndex = 2;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKayit);
            Controls.Add(btnGiris);
            Controls.Add(lblHosgeldiniz);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHosgeldiniz;
        private Button btnGiris;
        private Button btnKayit;
    }
}
