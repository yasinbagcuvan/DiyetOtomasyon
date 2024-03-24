using DiyetOtomasyon.BL.Manager.Concrete;
using DiyetOtomasyon.BL.Models;

namespace DiyetOtomasyon.PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.MainForm = this;
        }
    }
}
