using DiyetOtomasyon.BL.Manager.Concrete;
using DiyetOtomasyon.BL.Models;
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
    public partial class Form5 : Form
    {
        MealManager mealManager = new MealManager();
        PortionManager portionManager = new PortionManager();
        MealTimeManager timeManager = new MealTimeManager();
        MealModel selectedMeal;
        PortionModel selectedPortion;
        MealTimeModel selecetedMealTime;
        CategoryModel selectedCategory;
        CategoryManager categoryManager = new CategoryManager();
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

            dgvAdminYemek.DataSource = mealManager.GetAll();
            dgvPorsiyon.DataSource = portionManager.GetAll();
            dgvOgun.DataSource = timeManager.GetAll();
            dgvKategoriList.DataSource = categoryManager.GetAll();
            RefreshKategori();
        }
        private void txtPorsiyonAdet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPorsiyonAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                txtPorsiyonAdet.Text = "";
            }
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
            if (!mealManager.GetAll().Where(m => m.MealName == txtYemekAdi.Text).Any())
            {
                if (txtYemekAdi.Text == "" || txtYemekCalorie.Text == "" || cmbKategori.SelectedItem == null)
                {
                    MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    MealModel meal = new MealModel();
                    meal.Calorie = short.Parse(txtYemekCalorie.Text);
                    meal.MealName = txtYemekAdi.Text;
                    meal.Description = txtYemekAciklama.Text;
                    KeyValuePair<int, string> selectedCategory = (KeyValuePair<int, string>)cmbKategori.SelectedItem;
                    meal.CategoryId = selectedCategory.Key;
                    //var meals = mealManager.GetAllWithIncludes(cmbKategori.SelectedItem.ToString()).Single();
                    //meal.Category.CategoryName = meals.Category.CategoryName;
                    mealManager.Add(meal);
                    MessageBox.Show("Yemek Eklenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtYemekAdi.Text = "";
                    txtYemekCalorie.Text = "";
                    txtYemekAciklama.Text = "";
                    dgvAdminYemek.DataSource = mealManager.GetAll();
                    selectedMeal = null;
                }
            }
            else
            {
                MessageBox.Show("ZATEN BÖYLE BİR YEMEK VAR", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYemekSil_Click(object sender, EventArgs e)
        {

            //foreach (var item in mealManager.GetAll())
            //{
            //    if (item.Id != selectedMeal.Id)
            //    {
            //        MessageBox.Show(" BÖYLE BİR YEMEK BULUNAMADI", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
            if (selectedMeal == null)
            {
                MessageBox.Show("SİLMEK İÇİN BİR YEMEK SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtYemekAdi.Text == "" || txtYemekCalorie.Text == "")
            {
                MessageBox.Show("YEMEK ADI VEYA KALORI BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                mealManager.Remove(selectedMeal);
                MessageBox.Show("Yemek Silinmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtYemekAdi.Text = "";
                txtYemekCalorie.Text = "";
                txtYemekAciklama.Text = "";
                dgvAdminYemek.DataSource = mealManager.GetAll();
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
            if (selectedMeal == null)
            {
                MessageBox.Show("GUNCELLEMEK İÇİN BİR YEMEK SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtYemekAdi.Text == "" || txtYemekCalorie.Text == "")
            {
                MessageBox.Show("YEMEK ADI VEYA KALORI BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                selectedMeal.Calorie = short.Parse(txtYemekCalorie.Text);
                selectedMeal.MealName = txtYemekAdi.Text;
                selectedMeal.Description = txtYemekAciklama.Text;
                mealManager.Update(selectedMeal);
                MessageBox.Show("Yemek Güncellenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtYemekAdi.Text = "";
                txtYemekCalorie.Text = "";
                txtYemekAciklama.Text = "";
                dgvAdminYemek.DataSource = mealManager.GetAll();
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
            foreach (var item in portionManager.GetAll())
            {
                if (item.Type == txtPosiyonTipi.Text)
                {
                    MessageBox.Show("ZATEN BÖYLE BİR PORSİYON TİPİ VAR", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (txtPorsiyonAdet.Text == "" || txtPosiyonTipi.Text == "")
            {
                MessageBox.Show("PORSIYON TIPI VEYA ADETI BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                PortionModel portion = new PortionModel();
                portion.Size = short.Parse(txtPorsiyonAdet.Text);
                portion.Type = txtPosiyonTipi.Text;

                portionManager.Add(portion);
                MessageBox.Show("Porsiyon Eklenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPorsiyonAdet.Text = "";
                txtPosiyonTipi.Text = "";
                dgvPorsiyon.DataSource = portionManager.GetAll();
                selectedPortion = null;

            }
        }

        private void btnPorsiyonSil_Click(object sender, EventArgs e)
        {
            if (selectedPortion == null)
            {
                MessageBox.Show("SİLMEK İÇİN BİR PORSİYON SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPosiyonTipi.Text == "" || txtPorsiyonAdet.Text == "")
            {
                MessageBox.Show("PORSIYON TIPI VEYA ADETI BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                portionManager.Remove(selectedPortion);
                MessageBox.Show("Porsiyon Silinmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPorsiyonAdet.Text = "";
                txtPosiyonTipi.Text = "";
                dgvPorsiyon.DataSource = portionManager.GetAll();
                selectedPortion = null;
            }
        }

        private void btnPorsiyonGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedPortion == null)
            {
                MessageBox.Show("GUNCELLEMEK İÇİN BİR PORSİYON SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPosiyonTipi.Text == "" || txtPorsiyonAdet.Text == "")
            {
                MessageBox.Show("PORSIYON TIPI VEYA ADETI BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                selectedPortion.Size = short.Parse(txtPorsiyonAdet.Text);
                selectedPortion.Type = txtPosiyonTipi.Text;

                portionManager.Update(selectedPortion);
                MessageBox.Show("Porsiyon Güncellenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPorsiyonAdet.Text = "";
                txtPosiyonTipi.Text = "";

                dgvPorsiyon.DataSource = portionManager.GetAll();
                selectedPortion = null;
            }
        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            foreach (var item in timeManager.GetAll())
            {
                if (item.Name.ToLower() == txtOgunAdi.Text.ToLower())
                {
                    MessageBox.Show("ZATEN BÖYLE BİR OGUN VAR", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (txtOgunAdi.Text == "")
            {
                MessageBox.Show("OGUN  BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MealTimeModel mealTimeModel = new MealTimeModel();
                mealTimeModel.Name = txtPorsiyonAdet.Text;


                timeManager.Add(mealTimeModel);
                MessageBox.Show("Ogün Eklenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOgunAdi.Text = "";
                dgvOgun.DataSource = timeManager.GetAll();
                selecetedMealTime = null;
            }
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (selecetedMealTime == null)
            {
                MessageBox.Show("SİLMEK İÇİN BİR OGUN SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtOgunAdi.Text == "")
            {
                MessageBox.Show("OGUN  BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                timeManager.Remove(selecetedMealTime);
                MessageBox.Show("Ogun Silinmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOgunAdi.Text = "";
                dgvOgun.DataSource = timeManager.GetAll();
                selecetedMealTime = null;
            }
        }

        private void btnOgnGunc_Click(object sender, EventArgs e)
        {
            if (selecetedMealTime == null)
            {
                MessageBox.Show("GUNCELLEMEK İÇİN BİR OGUN SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtOgunAdi.Text == "")
            {
                MessageBox.Show("OGUN  BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                selecetedMealTime.Name = txtOgunAdi.Text;

                timeManager.Update(selecetedMealTime);
                MessageBox.Show("Ogun Güncellenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOgunAdi.Text = "";
                dgvOgun.DataSource = timeManager.GetAll();
                selecetedMealTime = null;
            }
        }

        private void btnEkleCat_Click(object sender, EventArgs e)
        {
            foreach (var item in categoryManager.GetAll())
            {
                if (item.CategoryName == txtKatAdi.Text)
                {
                    MessageBox.Show("ZATEN BÖYLE BİR KATEGORİ VAR", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (txtKatAdi.Text == "")
            {
                MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                CategoryModel categoryModel = new CategoryModel();

                categoryModel.CategoryName = txtKatAdi.Text;

                categoryManager.Add(categoryModel);
                MessageBox.Show("Kategori Eklenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKatAdi.Text = "";
                RefreshKategori();
                dgvKategoriList.DataSource = categoryManager.GetAll();
                selectedCategory = null;
            }
        }

        private void btnSilKat_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null)
            {
                MessageBox.Show("SİLMEK İÇİN BİR KATEGORI SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtKatAdi.Text == "")
            {
                MessageBox.Show("KATEGORI  BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                categoryManager.Remove(selectedCategory);
                MessageBox.Show("Kategori Silinmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKatAdi.Text = "";
                dgvKategoriList.DataSource = categoryManager.GetAll();
                selectedCategory = null;
                cmbKategori.DataSource = categoryManager.GetAll();
            }
        }

        private void btnGunCat_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null)
            {
                MessageBox.Show("GUNCELLEMEK İÇİN BİR KATEGORI SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtKatAdi.Text == "")
            {
                MessageBox.Show("KATEGORI ADI  BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                selectedCategory.CategoryName = txtKatAdi.Text;

                categoryManager.Update(selectedCategory);
                MessageBox.Show("Kategori Güncellenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOgunAdi.Text = "";
                dgvKategoriList.DataSource = categoryManager.GetAll();
                selectedCategory = null;
                cmbKategori.DataSource = categoryManager.GetAll();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }
    }
}
