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
            lblEmail1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEmail1.Location = new Point(35, 52);
            lblEmail1.Name = "lblEmail1";
            lblEmail1.Size = new Size(61, 21);
            lblEmail1.TabIndex = 0;
            lblEmail1.Text = "Email :";
            // 
            // btnGiris1
            // 
            btnGiris1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris1.Location = new Point(12, 197);
            btnGiris1.Name = "btnGiris1";
            btnGiris1.Size = new Size(161, 47);
            btnGiris1.TabIndex = 1;
            btnGiris1.Text = "GIRIS YAP";
            btnGiris1.UseVisualStyleBackColor = true;
            btnGiris1.Click += btnGiris1_Click;
            // 
            // lblPass1
            // 
            lblPass1.AutoSize = true;
            lblPass1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPass1.Location = new Point(35, 96);
            lblPass1.Name = "lblPass1";
            lblPass1.Size = new Size(53, 21);
            lblPass1.TabIndex = 2;
            lblPass1.Text = "Şifre :";
            // 
            // txtEmail1
            // 
            txtEmail1.Location = new Point(106, 54);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(100, 23);
            txtEmail1.TabIndex = 3;
            // 
            // txtPass1
            // 
            txtPass1.Location = new Point(106, 96);
            txtPass1.Name = "txtPass1";
            txtPass1.PasswordChar = '*';
            txtPass1.Size = new Size(100, 23);
            txtPass1.TabIndex = 4;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDon.Location = new Point(205, 197);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(116, 47);
            btnGeriDon.TabIndex = 5;
            btnGeriDon.Text = "ÇIKIS";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 280);
            Controls.Add(btnGeriDon);
            Controls.Add(txtPass1);
            Controls.Add(txtEmail1);
            Controls.Add(lblPass1);
            Controls.Add(btnGiris1);
            Controls.Add(lblEmail1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
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