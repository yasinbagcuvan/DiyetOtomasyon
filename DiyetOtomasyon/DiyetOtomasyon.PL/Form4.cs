using DiyetOtomasyon.BL.Manager.Concrete;
using DiyetOtomasyon.BL.Models;
using DiyetOtomasyon.DAL.Context;
using DiyetOtomasyon.DAL.Entities;
using DiyetOtomasyon.DAL.Enums;
using DiyetOtomasyon.PL.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
        MealManager mealManager = new MealManager();
        MealModel selectedMeal;
        MealModel cmbMeal;
        MealModel cmbMeal1;

        PersonMealManager personMealManager = new();
        PersonMealModel PersonMealModel = new PersonMealModel();
        PersonMealModel deletePmModel;

        PortionManager portionManager = new PortionManager();
        PortionModel Portion;

        MealTimeManager mealTimeManager = new();
        MealTimeModel selecetedMealTimeModel;
        MealTimeModel selecetedMealTimeModel1;

        PersonManager personManager = new PersonManager();

        CategoryManager categoryManager = new CategoryManager();

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


        private void Form4_Load(object sender, EventArgs e)
        {

            OgunListe();
            YemekListe("Id");
            cmbOgunler.DataSource = mealTimeManager.GetAll();
            ComboAylikOgunListe();
            ComboAylikYemekListe();
            ComboOgunListe();
            ComboTipListe();
            ComboYemekListe();

        }

        private void btnEkleYemek_Click(object sender, EventArgs e)
        {
            if (cmbOgun.SelectedText == null || cmbTip.SelectedText == null || selectedMeal == null)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PersonMealModel.MealId = selectedMeal.Id;
                MealTimeModel mealTime = (MealTimeModel)cmbOgun.SelectedItem;
                PersonMealModel.MealTimeId = mealTime.Id;
                PersonMealModel.PersonId = Program.LoginUserId;
                Portion = (PortionModel)cmbTip.SelectedItem;
                YemekListe("Id");
                PersonMealModel.PortionId = Portion.Id;
                personMealManager.Add(PersonMealModel);

                MessageBox.Show($"{selectedMeal.MealName} {mealTime.Name} öğününe {Portion.Size} porsiyon eklenmiştir  ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OgunListeGetir();
            }

        }


        private void btnDayList_Click(object sender, EventArgs e)
        {
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
            lblToplamKalori.Text = "Toplam Kalori : " + calSum.ToString();
            dgvDayList.DataSource = dayList.ToList();
        }

        private void btnWeekList_Click(object sender, EventArgs e)
        {

            selecetedMealTimeModel = (MealTimeModel)cmbOgunler.SelectedItem;
            if (mealTimeManager.GetAll().Where(m => m.Name.ToLower() == selecetedMealTimeModel.Name.ToLower()).Any())
            {
                var weekListOgun =
                            (from pm in personMealManager.GetAll()
                             join p in personManager.GetAll() on pm.PersonId equals p.Id
                             join m in mealManager.GetAll() on pm.MealId equals m.Id
                             join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                             join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                             join c in categoryManager.GetAll() on m.CategoryId equals c.Id
                             where mt.Name == selecetedMealTimeModel.Name
                             where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 7
                             group pm by new
                             {
                                 p.FirstName,
                                 p.LastName,
                                 mt.Name,
                                 p.Id,
                                 pm.CreatedDate
                             }
                             into gcs
                             select new
                             {
                                 ID = gcs.Key.Id,
                                 KisiAdiSoyadi = gcs.Key.FirstName + " " + gcs.Key.LastName,
                                 OgunAdi = gcs.Key.Name,
                                 Tarih = gcs.Key.CreatedDate
                             }
                             );
                dgvWeekList.DataSource = weekListOgun.ToList();
                var Sayac = weekListOgun.Count(x => x.ID == Program.Person.Id);
                lblToplamOgun.Text = "Toplam Oğün Sayınız : " + Sayac.ToString();
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Show();

        }


        private void dgvYemekListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedMeal = (MealModel)dgvYemekListesi.SelectedRows[0].DataBoundItem;
            lblMealName.Text = "Yemek : " + " " + selectedMeal.MealName;
            lblCalorie.Text = "Kalori : " + " " + selectedMeal.Calorie.ToString();
            lblMealDesc.Text = "Açıklama : " + " " + selectedMeal.Description;
        }

        private void btnYemekSorgu_Click(object sender, EventArgs e)
        {
            cmbMeal = (MealModel)cmbYemekler.SelectedItem;
            if (mealManager.GetAll().Where(m => m.MealName.ToLower() == cmbMeal.MealName.ToLower()).Any())
            {
                var weekListYemek =
                            (from pm in personMealManager.GetAll()
                             join p in personManager.GetAll() on pm.PersonId equals p.Id
                             join m in mealManager.GetAll() on pm.MealId equals m.Id
                             join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                             join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                             join c in categoryManager.GetAll() on m.CategoryId equals c.Id
                             where m.MealName == cmbMeal.MealName
                             where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 7
                             group pm by new
                             {
                                 p.FirstName,
                                 p.LastName,
                                 pm.CreatedDate,
                                 m.MealName,
                                 p.Id
                             }
                             into gcs
                             select new
                             {
                                 ID = gcs.Key.Id,
                                 KisiAdiSoyadi = gcs.Key.FirstName + " " + gcs.Key.LastName,
                                 YemekAdi = gcs.Key.MealName,
                                 Tarih = gcs.Key.CreatedDate
                             }
                             );
                dgvWeekList.DataSource = weekListYemek.ToList();
                var Sayac = weekListYemek.Count(x => x.ID == Program.Person.Id);
                lblYemekToplam.Text = "Toplam Yemek Sayınız : " + Sayac.ToString();
            }
        }

        private void btnAylıkOgun_Click(object sender, EventArgs e)
        {
            selecetedMealTimeModel1 = (MealTimeModel)cmbAylıkOgun.SelectedItem;
            if (mealTimeManager.GetAll().Where(m => m.Name.ToLower() == selecetedMealTimeModel1.Name.ToLower()).Any())
            {
                var mountListOgun =
                            (from pm in personMealManager.GetAll()
                             join p in personManager.GetAll() on pm.PersonId equals p.Id
                             join m in mealManager.GetAll() on pm.MealId equals m.Id
                             join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                             join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                             join c in categoryManager.GetAll() on m.CategoryId equals c.Id
                             where mt.Name == selecetedMealTimeModel1.Name
                             where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 30
                             group pm by new
                             {
                                 p.FirstName,
                                 p.LastName,
                                 mt.Name,
                                 p.Id,
                                 pm.CreatedDate
                             }
                             into gcs
                             select new
                             {
                                 ID = gcs.Key.Id,
                                 KisiAdiSoyadi = gcs.Key.FirstName + " " + gcs.Key.LastName,
                                 OgunAdi = gcs.Key.Name,
                                 Tarih = gcs.Key.CreatedDate
                             }
                             );
                dgvMountList.DataSource = mountListOgun.ToList();
                var Sayac = mountListOgun.Count(x => x.ID == Program.Person.Id);
                lblAylıkOgun.Text = "Toplam Oğün Sayınız : " + Sayac.ToString();
            }
        }

        private void btnAylıkYemek_Click(object sender, EventArgs e)
        {
            cmbMeal1 = (MealModel)cmbAylıkYemek.SelectedItem;
            if (mealManager.GetAll().Where(m => m.MealName.ToLower() == cmbMeal1.MealName.ToLower()).Any())
            {
                var mounthListYemek =
                            (from pm in personMealManager.GetAll()
                             join p in personManager.GetAll() on pm.PersonId equals p.Id
                             join m in mealManager.GetAll() on pm.MealId equals m.Id
                             join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                             join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                             join c in categoryManager.GetAll() on m.CategoryId equals c.Id
                             where m.MealName == cmbMeal1.MealName
                             where (DateTime.Now.Day) - (pm.CreatedDate.Day) <= 30
                             group pm by new
                             {
                                 p.FirstName,
                                 p.LastName,
                                 pm.CreatedDate,
                                 m.MealName,
                                 p.Id
                             }
                             into gcs
                             select new
                             {
                                 ID = gcs.Key.Id,
                                 KisiAdiSoyadi = gcs.Key.FirstName + " " + gcs.Key.LastName,
                                 YemekAdi = gcs.Key.MealName,
                                 Tarih = gcs.Key.CreatedDate
                             }
                             );
                dgvMountList.DataSource = mounthListYemek.ToList();
                var Sayac = mounthListYemek.Count(x => x.ID == Program.Person.Id);
                lblAylıkYemek.Text = "Toplam Yemek Sayınız : " + Sayac.ToString();
            }
        }
        private void btnYemekCesit_Click(object sender, EventArgs e)
        {


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
                    m.MealName,
                    pm.CreatedDate
                }
                into gcs
                select new { OgunAdi = gcs.Key.Name, YemekAdi = gcs.Key.MealName, PorsiyonMiktari = gcs.Key.Size, Tarih = gcs.Key.CreatedDate }
                );
            dgvYemekKiyas.DataSource = orderList.ToList();
        }
        public object OgunListeGetir()
        {
            var ogunList =
               (from pm in personMealManager.GetAll()
                join p in personManager.GetAll() on pm.PersonId equals p.Id
                join m in mealManager.GetAll() on pm.MealId equals m.Id
                join mt in mealTimeManager.GetAll() on pm.MealTimeId equals mt.Id
                join pt in portionManager.GetAll() on pm.PortionId equals pt.Id
                where p.Id == Program.LoginUserId
                where pm.Status != Status.Deleted
                where (DateTime.Now.Minute) - (pm.CreatedDate.Minute) <= 30
                orderby pt.Size descending
                group pm by new
                {
                    pm.PersonId,
                    pm.MealId,
                    pt.Size,
                    mt.Name,
                    m.MealName,
                    m.Calorie,
                    pm.CreatedDate
                }
                into gcs
                select new OgunView { YemekAdi = gcs.Key.MealName, PorsiyonMiktari = gcs.Key.Size, HesaplanmışKalori = gcs.Key.Calorie * gcs.Key.Size, OgunAdi = gcs.Key.Name, Tarih = gcs.Key.CreatedDate, PersonMealCreatedId = gcs.Key.PersonId + "_" + gcs.Key.MealId + "_" + gcs.Key.CreatedDate }
                );

            dgvOgunListem.DataSource = ogunList.ToList();
            dgvOgunListem.Columns["PersonMealCreatedId"].Visible = false;

            return dgvOgunListem.DataSource;
        }

        private void dgvOgunListem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var x = (OgunView)dgvOgunListem.SelectedRows[0].DataBoundItem;
            var xy = x.PersonMealCreatedId.Split('_');
            int PersonId = int.Parse(xy[0]);
            int MealId = int.Parse(xy[1]);
            DateTime CreatedId = Convert.ToDateTime(xy[2]);
            deletePmModel = personMealManager.Search((pm => pm.PersonId == PersonId && pm.CreatedDate == CreatedId && pm.MealId == MealId)).FirstOrDefault();
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (deletePmModel is not null)
            {
                personMealManager.Delete(deletePmModel);
                OgunListeGetir();
            }
            else
            {
                MessageBox.Show("LÜTFEN BİR ÖĞÜN SEÇİNİZ ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void YemekListe(params string[] kolonlar)
        {
            dgvYemekListesi.DataSource = mealManager.GetAll();
            foreach (var item in kolonlar)
            {
                dgvYemekListesi.Columns[item].Visible = false;
            }
        }


        private void OgunListe(params string[] kolonlar)
        {
            dgvOgunListem.DataSource = OgunListeGetir();
        }

        private void ComboOgunListe(params string[] kolonlar)
        {
            cmbOgun.DataSource = mealTimeManager.GetAll();
        }

        private void ComboTipListe(params string[] kolonlar)
        {
            cmbTip.DataSource = portionManager.GetAll();
        }

        private void ComboAylikOgunListe(params string[] kolonlar)
        {
            cmbAylıkOgun.DataSource = mealTimeManager.GetAll();
        }

        private void ComboYemekListe(params string[] kolonlar)
        {
            cmbYemekler.DataSource = mealManager.GetAll();
        }

        private void ComboAylikYemekListe(params string[] kolonlar)
        {
            cmbAylıkYemek.DataSource = mealManager.GetAll();
        }
    }
}
