using DiyetOtomasyon.BL.Manager.Concrete;
using DiyetOtomasyon.BL.Models;
using DiyetOtomasyon.DAL.Context;
using DiyetOtomasyon.DAL.Entities;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form5 : Form
    {
        MealManager mealManager = new MealManager();
        PortionManager portionManager = new PortionManager();
        MealTimeManager timeManager = new MealTimeManager();
        PersonManager personManager = new PersonManager();
        DiyetDbContext db = new DiyetDbContext();
        MealModel selectedMeal;
        PortionModel selectedPortion;
        PortionModel portion = new PortionModel();
        MealTimeModel selecetedMealTime;
        CategoryModel selectedCategory;
        CategoryManager categoryManager = new CategoryManager();
        Person selecetedPersonDB;
        Form _refForm;
        Form _mainForm;

        public Form5()
        {
            _mainForm = Program.MainForm;

            //Olaki buraya gelen forma ulaşmak istersem 
            _refForm = Program.ActiveForm;
            Program.ActiveForm = this;
            _mainForm.Hide();
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            RefreshDgvAdminYemek();
            RefreshDgvPorsiyon();
            RefreshDgvOgun();
            RefreshDgvKategori();
            RefreshDgvPersons();
            RefreshKategori();
        }
        private void txtYemekCalorie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                txtYemekCalorie.Text = "";
            }
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            if (!mealManager.GetAll().Where(m => m.MealName.ToLower() == txtYemekAdi.Text.ToLower()).Any())
            {
                if (txtYemekAdi.Text == "" || txtYemekCalorie.Text == "" || cmbKategori.SelectedItem == null)
                {
                    msgBosAlanDoldur();
                    selectedMeal = null;
                }
                else
                {
                    MealModel meal = new MealModel();
                    meal.Calorie = short.Parse(txtYemekCalorie.Text);
                    meal.MealName = txtYemekAdi.Text;
                    meal.Description = txtYemekAciklama.Text;
                    KeyValuePair<int, string> selectedCategory = (KeyValuePair<int, string>)cmbKategori.SelectedItem;
                    meal.CategoryId = selectedCategory.Key;
                    mealManager.Add(meal);
                    msgAddedSuccess("Yemek");
                    MealTextReset();
                    RefreshDgvAdminYemek();
                    selectedMeal = null;
                }
            }
            else
            {
                msgAlreadyUsed("YEMEK");
                selectedMeal = null;
            }
        }

        private void btnYemekSil_Click(object sender, EventArgs e)
        {
            if (selectedMeal == null)
            {
                msgForRemove("YEMEK");
                return;
            }
            else
            {
                mealManager.Remove(selectedMeal);
                msgRemoveSuccessed("Yemek");
                MealTextReset();
                RefreshDgvAdminYemek();
                selectedMeal = null;
            }
        }
        private void dgvAdminYemek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMeal = (MealModel)dgvAdminYemek.SelectedRows[0].DataBoundItem;
            txtYemekCalorie.Text = selectedMeal.Calorie.ToString();
            txtYemekAdi.Text = selectedMeal.MealName;
            txtYemekAciklama.Text = selectedMeal.Description;
        }

        private void btnYemekGuncelle_Click(object sender, EventArgs e)
        {
            if (!mealManager.GetAll().Where(m => m.MealName.ToLower() == txtYemekAdi.Text.ToLower()).Any())
            {
                if (selectedMeal == null)
                {
                    msgUpdateForModel("YEMEK");
                    MealTextReset();
                }
                else
                {
                    selectedMeal.Calorie = short.Parse(txtYemekCalorie.Text);
                    selectedMeal.MealName = txtYemekAdi.Text;
                    selectedMeal.Description = txtYemekAciklama.Text;
                    mealManager.Update(selectedMeal);
                    msgUpdateSuccessed("Yemek");
                    MealTextReset();
                    RefreshDgvAdminYemek();
                    selectedMeal = null;
                }
            }
            else
            {
                msgAlreadyUsed("YEMEK");
                selectedMeal = null;
            }
        }

        private void RefreshKategori()
        {
            cmbKategori.DataSource = categoryManager.GetAll().Select(c => new KeyValuePair<int, string>(key: c.Id, value: c.CategoryName)).ToList();
            cmbKategori.DisplayMember = "value";
            cmbKategori.ValueMember = "key";
        }
        private void btnPorsiyonEkle_Click(object sender, EventArgs e)
        {
            if (!portionManager.GetAll().Where(m => m.Size.ToString() == txtPorsiyonAdet.Text.ToString()).Any())
            {
                if (txtPorsiyonAdet.Text == "")
                {
                    msgBosAlanDoldur();
                    txtPorsiyonAdet.Text = "";
                }
                else
                {
                    portion.Size = short.Parse(txtPorsiyonAdet.Text);
                    portionManager.Add(portion);
                    msgAddedSuccess("Porsiyon");
                    txtPorsiyonAdet.Text = "";
                    RefreshDgvPorsiyon();
                    selectedPortion = null;
                }
            }
            else
            {
                msgAlreadyUsed("PORSİYON");
                selectedPortion = null;
            }
        }

        private void btnPorsiyonSil_Click(object sender, EventArgs e)
        {
            if (selectedPortion == null)
            {
                msgForRemove("PORSİYON");
                txtPorsiyonAdet.Text = "";
            }
            else
            {
                portionManager.Remove(selectedPortion);
                msgRemoveSuccessed("Porsiyon");
                txtPorsiyonAdet.Text = "";
                RefreshDgvPorsiyon();
                selectedPortion = null;
            }
        }

        private void btnPorsiyonGuncelle_Click(object sender, EventArgs e)
        {
            if (!portionManager.GetAll().Where(m => m.Size.ToString() == (txtPorsiyonAdet.Text).ToString()).Any())
            {
                if (selectedPortion == null)
                {
                    msgUpdateForModel("PORSİYON");
                    txtPorsiyonAdet.Text = "";
                }
                else
                {
                    selectedPortion.Size = int.Parse(txtPorsiyonAdet.Text);
                    portionManager.Update(selectedPortion);
                    msgUpdateSuccessed("Porsiyon");
                    txtPorsiyonAdet.Text = "";
                    RefreshDgvPorsiyon();
                    selectedPortion = null;
                }
            }
            else
            {
                msgAlreadyUsed("PORSİYON");
                selectedPortion = null;
            }

        }
        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            if (!timeManager.GetAll().Where(m => m.Name.ToLower() == txtOgunAdi.Text.ToLower()).Any())
            {
                if (txtOgunAdi.Text == "")
                {
                    msgBosAlanDoldur();
                    txtOgunAdi.Text = "";
                }
                else
                {
                    MealTimeModel mealTimeModel = new MealTimeModel();
                    mealTimeModel.Name = txtOgunAdi.Text;
                    timeManager.Add(mealTimeModel);
                    msgAddedSuccess("Öğün");
                    txtOgunAdi.Text = "";
                    RefreshDgvOgun();
                    selecetedMealTime = null;
                }
            }
            else
            {
                msgAlreadyUsed("OGUN");
                selecetedMealTime = null;
            }
        }
        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (selecetedMealTime == null)
            {
                msgForRemove("ÖĞÜN");
                txtOgunAdi.Text = "";
            }

            else
            {
                timeManager.Remove(selecetedMealTime);
                msgRemoveSuccessed("Öğün");
                txtOgunAdi.Text = "";
                RefreshDgvOgun();
                selecetedMealTime = null;
            }

        }

        private void btnOgnGunc_Click(object sender, EventArgs e)
        {
            if (!timeManager.GetAll().Where(m => m.Name.ToLower() == txtOgunAdi.Text.ToLower()).Any())
            {
                if (selecetedMealTime == null)
                {
                    msgUpdateForModel("OGUN");
                    txtOgunAdi.Text = "";
                    return;
                }
                else
                {
                    selecetedMealTime.Name = txtOgunAdi.Text;
                    timeManager.Update(selecetedMealTime);
                    msgUpdateSuccessed("Öğün");
                    txtOgunAdi.Text = "";
                    RefreshDgvOgun();
                    selecetedMealTime = null;
                }
            }
            else
            {
                msgAlreadyUsed("OGUN");

                selecetedMealTime = null;
            }

        }
        private void btnEkleCat_Click(object sender, EventArgs e)
        {
            if (!categoryManager.GetAll().Where(m => m.CategoryName.ToLower() == txtKatAdi.Text.ToLower()).Any())
            {
                if (txtKatAdi.Text == "")
                {
                    msgBosAlanDoldur();
                    txtKatAdi.Text = "";
                }

                else
                {
                    CategoryModel categoryModel = new CategoryModel();
                    categoryModel.CategoryName = txtKatAdi.Text;
                    categoryManager.Add(categoryModel);
                    msgAddedSuccess("Kategori");
                    txtKatAdi.Text = "";
                    RefreshKategori();
                    RefreshDgvKategori();
                    selectedCategory = null;
                }
            }
            else
            {
                msgAlreadyUsed("KATEGORİ");
                selectedCategory = null;
            }

        }

        private void btnSilKat_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null)
            {
                msgForRemove("KATEGORİ");
            }
            else
            {
                categoryManager.Remove(selectedCategory);
                msgRemoveSuccessed("Kategori");
                txtKatAdi.Text = "";
                RefreshDgvKategori();
                selectedCategory = null;
                cmbKategori.DataSource = categoryManager.GetAll();
            }
        }

        private void btnGunCat_Click(object sender, EventArgs e)
        {
            if (!categoryManager.GetAll().Where(m => m.CategoryName.ToLower() == txtKatAdi.Text.ToLower()).Any())
            {
                if (selectedCategory == null)
                {
                    msgUpdateForModel("KATEGORİ");
                    txtOgunAdi.Text = "";
                }
                else
                {
                    selectedCategory.CategoryName = txtKatAdi.Text;
                    categoryManager.Update(selectedCategory);
                    msgUpdateSuccessed("Kategori");
                    txtOgunAdi.Text = "";
                    RefreshDgvKategori();
                    selectedCategory = null;
                    cmbKategori.DataSource = categoryManager.GetAll();
                }
            }
            else
            {
                msgAlreadyUsed("KATEGORİ");
                selectedCategory = null;
            }
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void dgvPorsiyon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedPortion = (PortionModel)dgvPorsiyon.SelectedRows[0].DataBoundItem;
            txtPorsiyonAdet.Text = selectedPortion.Size.ToString();

        }

        private void dgvOgun_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selecetedMealTime = (MealTimeModel)dgvOgun.SelectedRows[0].DataBoundItem;
            txtOgunAdi.Text = selecetedMealTime.Name;
        }

        private void dgvKategoriList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedCategory = (CategoryModel)dgvKategoriList.SelectedRows[0].DataBoundItem;
            txtKatAdi.Text = selectedCategory.CategoryName;
        }

        private void btnPersonSil_Click(object sender, EventArgs e)
        {
            if (selecetedPersonDB == null)
            {
                msgForRemove("KULLANICI");
            }
            else
            {
                db.Remove(selecetedPersonDB);
                msgRemoveSuccessed("Kullanıcı");
                txtKatAdi.Text = "";
                RefreshDgvPersons();
                selecetedPersonDB = null;
            }
        }

        private void dgvPersons_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selecetedPersonDB = (Person)dgvPersons.SelectedRows[0].DataBoundItem;
            txtAdi.Text = selecetedPersonDB.FirstName;
            txtSoyadi.Text = selecetedPersonDB.LastName;
            txtMail.Text = selecetedPersonDB.Email;
            txtPass.Text = selecetedPersonDB.Password;
        }

        private void btnKullanıcıGunc_Click(object sender, EventArgs e)
        {
            if (!db.Persons.ToList().Where(m => m.Email.ToLower() == txtMail.Text.ToLower()).Any())
            {
                if (selecetedPersonDB == null)
                {
                    msgUpdateForModel("KULLANICI");
                }
                else
                {
                    selecetedPersonDB.Email = txtMail.Text;
                    selecetedPersonDB.LastName = txtSoyadi.Text;
                    selecetedPersonDB.FirstName = txtAdi.Text;
                    selecetedPersonDB.Password = txtPass.Text;

                    db.Persons.Update(selecetedPersonDB);
                    msgUpdateSuccessed("Kullanıcı");

                    txtAdi.Text = "";
                    txtSoyadi.Text = "";
                    txtMail.Text = "";
                    txtPass.Text = "";
                    RefreshDgvPersons();
                    selecetedPersonDB = null;
                }
            }
            else
            {
                msgAlreadyUsed("EMAİL ADRESLİ KULLANICI");
                selecetedPersonDB = null;
            }
        }

        private void MealTextReset()
        {
            txtYemekAdi.Text = "";
            txtYemekCalorie.Text = "";
            txtYemekAciklama.Text = "";
        }

        private void msgBosAlanDoldur()
        {
            MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgAlreadyUsed(string model)
        {
            MessageBox.Show($"ZATEN BÖYLE BİR {model} VAR", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgForRemove(string model)
        {
            MessageBox.Show($"SİLMEK İÇİN BİR {model} SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgRemoveSuccessed(string model)
        {
            MessageBox.Show($"{model} Silinmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void msgUpdateSuccessed(string model)
        {
            MessageBox.Show($"{model} Güncellenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshDgvAdminYemek()
        {
            dgvAdminYemek.DataSource = mealManager.GetAll();
        }
        private void RefreshDgvPorsiyon()
        {
            dgvPorsiyon.DataSource = portionManager.GetAll();
        }
        private void RefreshDgvOgun()
        {
            dgvOgun.DataSource = timeManager.GetAll();
        }
        private void RefreshDgvKategori()
        {
            dgvKategoriList.DataSource = db.Categories.ToList();
        }

        private void RefreshDgvPersons()
        {
            dgvPersons.DataSource = db.Persons.ToList();
        }

        private void msgAddedSuccess(string model)
        {
            MessageBox.Show($"{model} Eklenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void msgUpdateForModel(string model)
        {
            MessageBox.Show($"GUNCELLEMEK İÇİN BİR {model} SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
