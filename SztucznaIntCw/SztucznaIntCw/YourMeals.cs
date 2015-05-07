using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Classes.NonAbstract;

namespace SztucznaIntCw
{
    public partial class YourMeals : Form
    {
        private string MealTemplate = "{0}\t\t{1} gram\n";
        private string ProteinContent = "\nBiałka: {0}/{1} gram\n";
        private string CarbContent = "Węglowodany: {0}/{1} gram\n";
        private string FatContent = "Tłuszcze: {0}/{1} gram\n";
        public YourMeals()
        {
            InitializeComponent();
        }

        public YourMeals(Person person)
        {
            InitializeComponent();

            RichTextBox[] textBoxs =
            {
                this.FirstMealTextBox,
                this.SecondMealTextBox,
                this.ThirdMealTextBox,
                this.FourthMealTextBox,
                this.FifthMealTextBox
            };
            for (int i = 0; i < person.diet.Meals.Count; i++)
            {
                decimal proteins = 0, carbs = 0, fats = 0;
                foreach (var product in person.diet.Meals[i].MealProducts)
                {
                    proteins += (product.Value * product.Key.Protein) / 100;
                    carbs += (product.Value * product.Key.Carbs) / 100;
                    fats += (product.Value * product.Key.Fat) / 100;
                    textBoxs[i].AppendText(string.Format(MealTemplate, product.Key.Name, Math.Round(product.Value, 2).ToString()));
                }
                textBoxs[i].AppendText(string.Format(ProteinContent, Math.Round(proteins, 2), person.diet.Meals[i].TotalGramsOfProteins));
                textBoxs[i].AppendText(string.Format(CarbContent, Math.Round(carbs, 2), person.diet.Meals[i].TotalGramsOfCarbs));
                textBoxs[i].AppendText(string.Format(FatContent, Math.Round(fats, 2), person.diet.Meals[i].TotalGramsOfFats));
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
