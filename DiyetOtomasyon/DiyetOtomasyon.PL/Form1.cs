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

        private void button1_Click(object sender, EventArgs e)
        {
            //MealManager mealManager = new MealManager();
            //MealModel mealModel = new MealModel();
            //mealModel.Name = "Yemek-" + (new Random().Next(100).ToString());
            //mealModel.Description = "ABC";
            //mealModel.Calorie = 123;
            //mealManager.Add(mealModel);

            //MealModel mealModel1 = mealManager.GetById(11);

            //mealModel1.Calorie = (short)(mealModel1.Calorie * 2);
            //mealManager.Update(mealModel1);

            //var a = mealManager.GetAll();
            //mealManager.Remove(mealModel1);

            //MealModel mealModel = new MealModel();
            //mealModel.Name = "Yemek 123";
            //mealModel.Calorie = 542;
            //mealModel.Description = "YSDFSAAS";

            //mealManager.Add(mealModel);

            //MealModel mealmodel1 = mealManager.GetById(15);

            //mealmodel1.Name = "Yemek123";
            //mealManager.Update(mealmodel1);

        }

        private void lblHosgeldiniz_Click(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();



        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
