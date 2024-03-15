﻿using DiyetOtomasyon.BL.Manager.Concrete;
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
        public PersonModel person;
        PersonManager PersonManager = new PersonManager();
        public PersonModel LoginUser;

        public Form3(Form mainform = null)
        {
            InitializeComponent();
            _mainform = mainform;

        }

        private void btnGiris1_Click(object sender, EventArgs e)
        {
            string email = txtEmail1.Text;
            string pass = txtPass1.Text;


            if (email == "" || pass == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtEmail1.Text = "";
                txtPass1.Text = "";
            }
            else
            {
                PersonManager personManager = new PersonManager();
                LoginUser = personManager.FindUser(email, pass);
                

                if (LoginUser != null)
                {
                    if (LoginUser.Email == "admin" && LoginUser.Password == "admin1")
                    {
                        Form5 form5 = new Form5();
                        form5.Show();
                        this.Close();
                    }
                    else
                    {
                        Program.LoginUserId = LoginUser.Id;
                        Program.Person = LoginUser;
                        // Kullanıcı bulundu login oldu 
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Close();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail1.Text = "";
                    txtPass1.Text = "";
                }

            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            _mainform.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
