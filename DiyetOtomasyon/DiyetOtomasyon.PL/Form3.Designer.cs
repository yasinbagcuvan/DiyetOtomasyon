namespace DiyetOtomasyon.PL
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            lblEmail1 = new Label();
            btnGiris1 = new Button();
            lblPass1 = new Label();
            txtEmail1 = new TextBox();
            txtPass1 = new TextBox();
            btnGeriDon = new Button();
            SuspendLayout();
            // 
            // lblEmail1
            // 
            lblEmail1.AutoSize = true;
            lblEmail1.BackColor = SystemColors.ControlDark;
            lblEmail1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEmail1.Location = new Point(50, 87);
            lblEmail1.Margin = new Padding(4, 0, 4, 0);
            lblEmail1.Name = "lblEmail1";
            lblEmail1.Size = new Size(90, 32);
            lblEmail1.TabIndex = 0;
            lblEmail1.Text = "Email :";
            // 
            // btnGiris1
            // 
            btnGiris1.BackColor = SystemColors.ControlLight;
            btnGiris1.FlatAppearance.BorderColor = Color.Silver;
            btnGiris1.FlatAppearance.BorderSize = 3;
            btnGiris1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris1.Location = new Point(17, 328);
            btnGiris1.Margin = new Padding(4, 5, 4, 5);
            btnGiris1.Name = "btnGiris1";
            btnGiris1.Size = new Size(230, 78);
            btnGiris1.TabIndex = 1;
            btnGiris1.Text = "GIRIS YAP";
            btnGiris1.UseVisualStyleBackColor = false;
            btnGiris1.Click += btnGiris1_Click;
            // 
            // lblPass1
            // 
            lblPass1.AutoSize = true;
            lblPass1.BackColor = SystemColors.ControlDark;
            lblPass1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPass1.Location = new Point(50, 160);
            lblPass1.Margin = new Padding(4, 0, 4, 0);
            lblPass1.Name = "lblPass1";
            lblPass1.Size = new Size(80, 32);
            lblPass1.TabIndex = 2;
            lblPass1.Text = "Şifre :";
            // 
            // txtEmail1
            // 
            txtEmail1.BackColor = Color.White;
            txtEmail1.BorderStyle = BorderStyle.FixedSingle;
            txtEmail1.Location = new Point(151, 90);
            txtEmail1.Margin = new Padding(4, 5, 4, 5);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(141, 31);
            txtEmail1.TabIndex = 3;
            // 
            // txtPass1
            // 
            txtPass1.BackColor = Color.White;
            txtPass1.BorderStyle = BorderStyle.FixedSingle;
            txtPass1.Location = new Point(151, 160);
            txtPass1.Margin = new Padding(4, 5, 4, 5);
            txtPass1.Name = "txtPass1";
            txtPass1.PasswordChar = '*';
            txtPass1.Size = new Size(141, 31);
            txtPass1.TabIndex = 4;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = SystemColors.ControlLight;
            btnGeriDon.FlatAppearance.BorderColor = Color.Silver;
            btnGeriDon.FlatAppearance.BorderSize = 3;
            btnGeriDon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDon.Location = new Point(293, 328);
            btnGeriDon.Margin = new Padding(4, 5, 4, 5);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(166, 78);
            btnGeriDon.TabIndex = 5;
            btnGeriDon.Text = "ÇIKIS";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(476, 467);
            Controls.Add(btnGeriDon);
            Controls.Add(txtPass1);
            Controls.Add(txtEmail1);
            Controls.Add(lblPass1);
            Controls.Add(btnGiris1);
            Controls.Add(lblEmail1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            FormClosed += Form3_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail1;
        private Button btnGiris1;
        private Label lblPass1;
        private TextBox txtEmail1;
        private TextBox txtPass1;
        private Button btnGeriDon;
    }
}