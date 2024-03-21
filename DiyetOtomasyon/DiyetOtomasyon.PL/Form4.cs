﻿using DiyetOtomasyon.BL.Manager.Concrete;
using DiyetOtomasyon.BL.Models;
using DiyetOtomasyon.DAL.Context;
using DiyetOtomasyon.DAL.Entities;
using Microsoft.Data.SqlClient;
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
    public partial class Form4 : Form
    {
        DiyetDbContext db = new DiyetDbContext();
        MealModel selectedMeal;
        PersonMealManager manager = new PersonMealManager();
        MealManager mealManager = new MealManager();
        MealTimeManager mealTime = new MealTimeManager();
        PortionManager portionManager = new PortionManager();
        PersonMealModel PersonMealModel = new PersonMealModel();
        PortionModel Portion;
        Form _mainForm;
        Form _refForm;

        public Form4()
        {
            _mainForm = Program.MainForm;

            //Olaki buraya gelen forma ulaşmak istersem 
            _refForm = Program.ActiveForm;
            Program.ActiveForm = this;
            _mainForm.Hide();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        
            dgvYemekListesi.DataSource = mealManager.GetAll();
            cmbOgun.DataSource = mealTime.GetAll();
            MessageBox.Show("UserId : " + Program.LoginUserId);
            MessageBox.Show("UserName : " + Program.Person.FirstName);
            cmbTip.DataSource = portionManager.GetAll();


        }

        private void dgvYemekListesi_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnEkleYemek_Click(object sender, EventArgs e)
        {
            if (/*txtAdet.Text == "" ||*/ cmbOgun.SelectedText == null || cmbTip.SelectedText == null || selectedMeal == null)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PersonMealModel.MealId = selectedMeal.Id;
                MealTimeModel mealTime = (MealTimeModel)cmbOgun.SelectedItem;
                PersonMealModel.MealTimeId = mealTime.Id;
                PersonMealModel.PersonId = Program.LoginUserId;

                //Portion.Size = int.Parse(txtAdet.Text);
                Portion = (PortionModel)cmbTip.SelectedItem;
                //Portion = portionManager.Add(Portion);

                PersonMealModel.PortionId = Portion.Id;
                manager.Add(PersonMealModel);
                dgvYemekListesi.DataSource = mealManager.GetAll();
                MessageBox.Show($"{selectedMeal.MealName} {mealTime.Name} öğününe {Portion.Size} porsiyon eklenmiştir  ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (e.Handled = !char.IsDigit(e.KeyChar))
            //{
            //    txtAdet.Text = "";
            //}
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnDayList_Click(object sender, EventArgs e)
        {
            PersonMealManager personMealManager = new PersonMealManager();
            PersonManager personManager = new PersonManager();
            MealManager mealManager = new MealManager();
            MealTimeManager mealTimeManager = new MealTimeManager();
            PortionManager portionManager = new PortionManager();



            var dayList =
                           (from pm in personMealManager.GetAll()
                            join p in personManager.GetAll() on pm.PersonId equals p.Id
                            join m in mealManager.GetAll() on pm.MealId equals m.Id
                            join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                            join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                            where p.Id == Program.LoginUserId
                            where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 1
                            select new { KisiAdi = p.FirstName + " " + p.LastName, YemekAdi = m.MealName, Kalorisi = m.Calorie, OgunAdi = mt.Name, Porsiyon = pt.Size, ToplamKalori = (int)(m.Calorie * pt.Size), Tarih = pm.CreatedDate }).ToList();
            

            int calSum = dayList.Sum(x => x.ToplamKalori);
            lblToplamKalori.Text = "Toplam Kalori : "+calSum.ToString();
            dgvDayList.DataSource = dayList.ToList();
        }

        private void btnWeekList_Click(object sender, EventArgs e)
        {
            PersonMealManager personMealManager = new PersonMealManager();
            PersonManager personManager = new PersonManager();
            MealManager mealManager = new MealManager();
            MealTimeManager mealTimeManager = new MealTimeManager();
            PortionManager portionManager = new PortionManager();
            CategoryManager categoryManager = new CategoryManager();



            var weekList =
                           (from pm in personMealManager.GetAll()
                            join p in personManager.GetAll() on pm.PersonId equals p.Id
                            join m in mealManager.GetAll() on pm.MealId equals m.Id
                            join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                            join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                            join c in categoryManager.GetAll() on m.CategoryId equals c.Id
                            //where p.Id == Program.LoginUserId
                            where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 7
                            group pm by new
                            {
                                p.FirstName,
                                p.LastName,
                                mt.Name,
                                c.CategoryName
                            }
                            into gcs
                            select new { KisiAdi = gcs.Key.FirstName, KisiSoyadi = gcs.Key.LastName, OgunAdi = gcs.Key.Name, KategoriAdi = gcs.Key.CategoryName }
                            );

            dgvWeekList.DataSource = weekList.ToList();
        }

        private void btnMountList_Click(object sender, EventArgs e)
        {
            PersonMealManager personMealManager = new PersonMealManager();
            PersonManager personManager = new PersonManager();
            MealManager mealManager = new MealManager();
            MealTimeManager mealTimeManager = new MealTimeManager();
            PortionManager portionManager = new PortionManager();
            CategoryManager categoryManager = new CategoryManager();



            var mounthList =
                           (from pm in personMealManager.GetAll()
                            join p in personManager.GetAll() on pm.PersonId equals p.Id
                            join m in mealManager.GetAll() on pm.MealId equals m.Id
                            join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                            join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                            join c in categoryManager.GetAll() on m.CategoryId equals c.Id
                            //where p.Id == Program.LoginUserId
                            where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 30
                            group pm by new
                            {
                                p.FirstName,
                                p.LastName,
                                mt.Name,
                                c.CategoryName
                            }
                            into gcs
                            select new { KisiAdi = gcs.Key.FirstName, KisiSoyadi = gcs.Key.LastName, OgunAdi = gcs.Key.Name, KategoriAdi = gcs.Key.CategoryName }
                            );

            dgvMountList.DataSource = mounthList.ToList();
        }

        private void btnYemekCesit_Click(object sender, EventArgs e)
        {

            PersonMealManager personMealManager = new PersonMealManager();
            PersonManager personManager = new PersonManager();
            MealManager mealManager = new MealManager();
            MealTimeManager mealTimeManager = new MealTimeManager();
            PortionManager portionManager = new PortionManager();

            var orderList =
               (from pm in personMealManager.GetAll()
                join p in personManager.GetAll() on pm.PersonId equals p.Id
                join m in mealManager.GetAll() on pm.MealId equals m.Id
                join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                where p.Id == Program.LoginUserId
                where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 30
                orderby pt.Size descending
                group pm by new
                {
                    pt.Size,
                    mt.Name,
                    m.MealName
                }
                into gcs
                select new { OgunAdi = gcs.Key.Name, YemekAdi = gcs.Key.MealName, PorsiyonMiktari = gcs.Key.Size }
                );
            dgvYemekKiyas.DataSource = orderList.ToList();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Show();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvYemekListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedMeal = (MealModel)dgvYemekListesi.SelectedRows[0].DataBoundItem;
            lblMealName.Text = "Yemek : " + " " + selectedMeal.MealName;
            lblCalorie.Text = "Kalori : " + " " + selectedMeal.Calorie.ToString();
            lblMealDesc.Text = "Açıklama : " + " " + selectedMeal.Description;
        }
    }
}
