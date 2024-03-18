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
            MealManager mealManager = new MealManager();
            //MealModel mealModel = new MealModel();
            //mealModel.Name = "Yemek-"+ (new Random().Next(100).ToString());
            //mealModel.Description = "ABC";
            //mealModel.Calorie = 123;
            //mealManager.Add(mealModel);


            MealModel mealModel1 = mealManager.GetById(11);

            //mealModel1.Calorie = (short)(mealModel1.Calorie*2);
            //mealManager.Update(mealModel1);

            var a =  mealManager.GetAll();
            mealManager.Remove(mealModel1);

            
        }
    }
}
