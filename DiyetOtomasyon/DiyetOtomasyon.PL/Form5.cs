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
            Meal meal = new Meal();
            //meal.Calorie = txtYemekCalorie.Text;
        }
    }
}
