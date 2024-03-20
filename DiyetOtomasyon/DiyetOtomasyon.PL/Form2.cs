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
using System.Text;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            PersonModel personModel = new PersonModel();
            PersonManager personManager = new PersonManager();
            personModel.FirstName = txtAd.Text;
            personModel.LastName = txtSoyad.Text;
            personModel.Email = txtEmail.Text;
            personModel.Password = txtPass.Text;
            SifreKontrol();

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtEmail.Text = "";
                txtPass.Text = "";

            }

            else
            {
                var tempUser = personManager.FindUser(txtEmail.Text,txtPass.Text);
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

        public void SifreKontrol()
        {
            if (txtPass.Text.Length <= 5)
            {
                txtPass.Text = "";
                MessageBox.Show("Şifre En az 6 haneli olmalıdır", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
