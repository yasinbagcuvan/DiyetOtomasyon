using DiyetOtomasyon.BL.Manager.Concrete;
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
        PersonMealModel PersonMealModel = new PersonMealModel();
        PortionModel Portion = new PortionModel();
        PortionManager PortionManager = new PortionManager();



        public Form4()
        {

            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MealManager manager = new MealManager();
            MealTimeManager mealTime = new MealTimeManager();
            PortionManager portionManager = new PortionManager();
            dgvYemekListesi.DataSource = manager.GetAll();
            cmbOgun.DataSource = mealTime.GetAll();
            MessageBox.Show("UserId : " + Program.LoginUserId);
            MessageBox.Show("UserName : " + Program.Person.FirstName);
            cmbTip.DataSource = portionManager.GetAll();

        }

        private void dgvYemekListesi_MouseClick(object sender, MouseEventArgs e)
        {
            selectedMeal = (MealModel)dgvYemekListesi.SelectedRows[0].DataBoundItem;
            lblMealName.Text = "Yemek : " + " " + selectedMeal.MealName;
            lblCalorie.Text = "Kalori : " + " " + selectedMeal.Calorie.ToString();
            lblMealDesc.Text = "Açıklama : " + " " + selectedMeal.Description;
        }

        private void btnEkleYemek_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "" || cmbOgun.SelectedText == null || cmbTip.SelectedText == null)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PersonMealModel.MealId = selectedMeal.Id;
                MealTimeModel mealTime = (MealTimeModel)cmbOgun.SelectedItem;
                PersonMealModel.MealTimeId = mealTime.Id;
                PersonMealModel.PersonId = Program.LoginUserId;

                Portion.Size = int.Parse(txtAdet.Text);
                Portion.Type = cmbTip.SelectedItem.ToString();
                Portion = PortionManager.Add(Portion);

                PersonMealModel.PortionId = Portion.Id;
                manager.Add(PersonMealModel);
            }

        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                txtAdet.Text = "";
            }
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
                            select new { KisiAdi = p.FirstName + " " + p.LastName, YemekAdi = m.MealName, Kalorisi = m.Calorie, OgunAdi = mt.Name, Porsiyon = pt.Size, PorsiyonTipi = pt.Type, ToplamKalori = (int)(m.Calorie * pt.Size), Tarih = pm.CreatedDate });

            dgvDayList.DataSource = dayList.ToList();
        }

        private void btnWeekList_Click(object sender, EventArgs e)
        {
            PersonMealManager personMealManager = new PersonMealManager();
            PersonManager personManager = new PersonManager();
            MealManager mealManager = new MealManager();
            MealTimeManager mealTimeManager = new MealTimeManager();
            PortionManager portionManager = new PortionManager();



            var weekList =
                           (from pm in personMealManager.GetAll()
                            join p in personManager.GetAll() on pm.PersonId equals p.Id
                            join m in mealManager.GetAll() on pm.MealId equals m.Id
                            join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                            join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                            where p.Id == Program.LoginUserId
                            where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 7
                            group pm by new
                            {
                                p.FirstName,
                                p.LastName,
                                mt.Name,
                                m.MealName
                            }
                            into gcs
                            select new { KisiAdi = gcs.Key.FirstName, KisiSoyadi = gcs.Key.LastName, OgunAdi = gcs.Key.Name, YemekAdi = gcs.Key.MealName }
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



            var mounthList =
                           (from pm in personMealManager.GetAll()
                            join p in personManager.GetAll() on pm.PersonId equals p.Id
                            join m in mealManager.GetAll() on pm.MealId equals m.Id
                            join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                            join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                            where p.Id == Program.LoginUserId
                            where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 30
                            group pm by new
                            {
                                p.FirstName,
                                p.LastName,
                                mt.Name,
                                m.MealName
                            }
                            into gcs
                            select new { KisiAdi = gcs.Key.FirstName, KisiSoyadi = gcs.Key.LastName, OgunAdi = gcs.Key.Name, YemekAdi = gcs.Key.MealName }
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


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
