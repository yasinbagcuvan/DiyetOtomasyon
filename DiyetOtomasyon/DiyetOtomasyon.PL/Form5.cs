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


        public Form5()
        {
            InitializeComponent();
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
            foreach (var item in mealManager.GetAll())
            {
                if (item.MealName == txtYemekAdi.Text)
                {
                    MessageBox.Show("ZATEN BÖYLE BİR YEMEK VAR", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (txtYemekAdi.Text == "" || txtYemekCalorie.Text == "")
            {
                MessageBox.Show("YEMEK ADI VEYA KALORI BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MealModel meal = new MealModel();
                meal.Calorie = short.Parse(txtYemekCalorie.Text);
                meal.MealName = txtYemekAdi.Text;
                meal.Description = txtYemekAciklama.Text;
                mealManager.Add(meal);
                MessageBox.Show("Yemek Eklenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtYemekAdi.Text = "";
                txtYemekCalorie.Text = "";
                txtYemekAciklama.Text = "";
                dgvAdminYemek.DataSource = mealManager.GetAll();
                selectedMeal = null;
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

        private void Form5_Load(object sender, EventArgs e)
        {
            dgvAdminYemek.DataSource = mealManager.GetAll();
            dgvPorsiyon.DataSource = portionManager.GetAll();
            dgvOgun.DataSource = timeManager.GetAll();
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
    }
}
