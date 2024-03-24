using DiyetOtomasyon.BL.Manager.Concrete;
using DiyetOtomasyon.BL.Models;
using DiyetOtomasyon.DAL.Context;
using DiyetOtomasyon.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetOtomasyon.PL
{
    public partial class Form2 : Form
    {
        //DiyetDbContext db = new DiyetDbContext();
        PersonModel personModel = new PersonModel();
        PersonManager personManager = new PersonManager();
        string _errorMessage = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {

            UserInfoFromTexts();
            if (txtEmail.Text == "admin" && txtPass.Text == "admin1")
            {
                KullaniciKayitliMi("Admin");
            }
            else
            {
                if (SifreKontrol(txtPass.Text))
                {
                    TextBoslukKontrol();
                    if (!txtEmail.Text.EndsWith(".com") || !EmailControl(txtEmail.Text))
                    {
                        MessageBox.Show("Lütfen Email formatında bir mail giriniz!", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = "";
                    }
                    else
                    {
                        KullaniciKayitliMi("Kullanıcı");
                    }
                }
                else
                {
                    MessageBox.Show(_errorMessage, "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _errorMessage = string.Empty;
                }
            
               
            }
        }

        public bool SifreKontrol(string sifre)
        {
            bool result = true;
            if ((txtPass.Text.Length < 5) || (txtPass.Text.Length > 10))
            {
                txtPass.Text = "";
                ErrorMessageForPass("6 en fazla 10 hane");
                result = false;
            }
            if (!Regex.IsMatch(sifre, "[A-Z]"))
            {
                ErrorMessageForPass("bir büyük harf");
                result = false;
            }
             if (!Regex.IsMatch(sifre, "[a-z]"))
            {
                ErrorMessageForPass("bir küçük harf");
                result = false;
            }
             if (!Regex.IsMatch(sifre, "[0-9]"))
            {
                ErrorMessageForPass("bir rakam");
                result = false;
            }
            return result;
        }

        //public bool SifreKontrol(string sifre)
        //{
        //    bool result = true;
        //    if ((txtPass.Text.Length < 5) || (txtPass.Text.Length > 10))
        //    {
        //        txtPass.Text = "";
        //        ErrorMessageForPass("6 en fazla 10 hane");
        //        result = false;
        //    }
        //    else if (!Regex.IsMatch(sifre, "[A-Z]"))
        //    {
        //        ErrorMessageForPass("bir büyük harf");
        //        result= false;
        //    }
        //    else if (!Regex.IsMatch(sifre, "[a-z]"))
        //    {
        //        ErrorMessageForPass("bir küçük harf");
        //        result = false;
        //    }
        //    else if (!Regex.IsMatch(sifre, "[0-9]"))
        //    {
        //        ErrorMessageForPass("bir rakam");
        //        result = false;
        //    }
        //    return result;
        //}

        public bool EmailControl(string Email)
        {
            try
            {
                var mailAdress = new MailAddress(Email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }

        private void KullaniciKayitliMi(string UserOrAdmin)
        {
            var tempUser = personManager.FindUser(txtEmail.Text);
            if (tempUser != null)
            {
                MessageBox.Show($"{UserOrAdmin} Zaten Kayıtlı", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
            }
            else
            {
                personModel.Password = Program.sha256_hash(personModel.Password);
                personManager.Add(personModel);
                MessageBox.Show($"{UserOrAdmin} Kayıdı Başarılı", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
        }

        private void UserInfoFromTexts()
        {
            personModel.FirstName = txtAd.Text;
            personModel.LastName = txtSoyad.Text;
            personModel.Email = txtEmail.Text;
            personModel.Password = txtPass.Text;
        }

        private void ErrorMessageForPass(string HataTürü)
        {
             _errorMessage += $"Şifre En az {HataTürü} içermeli\n";
            
        }

        private void TextBoslukKontrol()
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        
    }
}
