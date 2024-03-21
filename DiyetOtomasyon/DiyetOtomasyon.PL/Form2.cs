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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetOtomasyon.PL
{
    public partial class Form2 : Form
    {
        //DiyetDbContext db = new DiyetDbContext();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            PersonModel personModel = new PersonModel();
            PersonManager personManager = new PersonManager();
            personModel.FirstName = txtAd.Text;
            personModel.LastName = txtSoyad.Text;
            personModel.Email = txtEmail.Text;
            personModel.Password = txtPass.Text;

            if (txtEmail.Text == "admin" && txtPass.Text == "admin1")
            {
                var tempUser = personManager.FindUser(txtEmail.Text, txtPass.Text);
                if (tempUser != null)
                {
                    MessageBox.Show("Admin Zaten Kayıtlı", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtEmail.Text = "";
                }
                else
                {
                    personManager.Add(personModel);
                    MessageBox.Show("Admin Kaydı Başarılı", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SifreKontrol(txtPass.Text);
                if (!txtEmail.Text.EndsWith(".com") || !EmailControl(txtEmail.Text))
                {
                    MessageBox.Show("Lütfen Email formatında bir mail giriniz!", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = "";
                }
                else
                {
                    var tempUser = personManager.FindUser(txtEmail.Text, txtPass.Text);
                    if (tempUser != null)
                    {
                        MessageBox.Show("Zaten Kayıtlı", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtEmail.Text = "";
                    }
                    else
                    {
                        personManager.Add(personModel);
                        MessageBox.Show("Kayıt Başarılı", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        this.Dispose();
                    }
                }
            }
        }

        public void SifreKontrol(string sifre)
        {
            if ((txtPass.Text.Length < 5) || (txtPass.Text.Length >= 10))
            {
                txtPass.Text = "";
                MessageBox.Show("Şifre En az 6 en Fazla 10 haneli olmalıdır", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(sifre, "[A-Z]"))
            {
                MessageBox.Show("Şifre En az bir büyük harf içermeli", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(sifre, "[a-z]"))
            {
                MessageBox.Show("Şifre En az bir küçük harf içermeli", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(sifre, "[0-9]"))
            {
                MessageBox.Show("Şifre En az bir rakam içermeli", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

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
    }
}
