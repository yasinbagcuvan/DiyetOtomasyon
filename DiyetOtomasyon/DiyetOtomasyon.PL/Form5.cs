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
        MealModel selectedMeal;
        public Form5()
        {
            dgvAdminYemek.DataSource = mealManager.GetAll();
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
            MealModel meal = new MealModel();
            meal.Calorie = short.Parse(txtYemekCalorie.Text);
            meal.MealName = txtYemekAdi.Text;
            meal.Description = txtYemekAciklama.Text;


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
                mealManager.Add(meal);
                MessageBox.Show("Yemek Eklenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtYemekAdi.Text = "";
                txtYemekCalorie.Text = "";
                txtYemekAciklama.Text = "";
                selectedMeal = null;
            }

        }

        private void btnYemekSil_Click(object sender, EventArgs e)
        {

            txtYemekCalorie.Text = selectedMeal.Calorie.ToString();
            txtYemekAdi.Text=selectedMeal.MealName;
             txtYemekAciklama.Text=selectedMeal.Description ;


            foreach (var item in mealManager.GetAll())
            {
                if (item.Id != selectedMeal.Id)
                {
                    MessageBox.Show(" BÖYLE BİR YEMEK BULUNAMADI", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                dgvAdminYemek.Refresh();
                selectedMeal = null;
            }
        }

        private void dgvAdminYemek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMeal = (MealModel)dgvAdminYemek.SelectedRows[0].DataBoundItem;
        }

        private void btnYemekGuncelle_Click(object sender, EventArgs e)
        {

            txtYemekCalorie.Text = selectedMeal.Calorie.ToString();
            txtYemekAdi.Text = selectedMeal.MealName;
            txtYemekAciklama.Text = selectedMeal.Description;

            selectedMeal.Calorie = short.Parse(txtYemekCalorie.Text);
            selectedMeal.MealName = txtYemekAdi.Text;
            selectedMeal.Description = txtYemekAciklama.Text;
 

            foreach (var item in mealManager.GetAll())
            {
                if (item.Id != selectedMeal.Id)
                {
                    MessageBox.Show(" BÖYLE BİR YEMEK BULUNAMADI", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (txtYemekAdi.Text == "" || txtYemekCalorie.Text == "" || selectedMeal == null)
            {
                MessageBox.Show("YEMEK ADI VEYA KALORI BOŞ OLAMAZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                mealManager.Update(selectedMeal);
                MessageBox.Show("Yemek Güncellenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtYemekAdi.Text = "";
                txtYemekCalorie.Text = "";
                txtYemekAciklama.Text = "";
                dgvAdminYemek.Refresh();
                selectedMeal = null;
            }
        }
    }
}
