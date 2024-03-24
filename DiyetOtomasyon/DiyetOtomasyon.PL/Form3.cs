using DiyetOtomasyon.BL.Manager.Concrete;
using DiyetOtomasyon.BL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetOtomasyon.PL
{
    public partial class Form3 : Form
    {
        private readonly Form _mainform;
        public PersonModel LoginUser;

        public Form3()
        {
            InitializeComponent();
            _mainform = Program.MainForm;
            Program.ActiveForm = this;

        }

        private void btnGiris1_Click(object sender, EventArgs e)
        {
            string email = txtEmail1.Text;
            string pass = txtPass1.Text;

            if (email == "" || pass == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailPassReset();
            }
            else
            {
                if (email == "admin" && pass == "admin1")
                {
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Dispose();
                }
                else
                {
                    PersonManager personManager = new PersonManager();
                    LoginUser = personManager.FindUser(email, Program.sha256_hash(pass));


                    if (LoginUser != null)
                    {
                        Program.LoginUserId = LoginUser.Id;
                        Program.Person = LoginUser;
                        // Kullanıcı bulundu login oldu 
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EmailPassReset();
                    }
                }
                

            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainform.Show();
        }

        private void EmailPassReset()
        {
            txtEmail1.Text = "";
            txtPass1.Text = "";
        }
    }
}
