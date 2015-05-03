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
                foreach (var meal in person.diet.Meals[i].MealProducts)
                {
                    textBoxs[i].AppendText(string.Format(MealTemplate, meal.Key.Name, Math.Round(meal.Value, 2).ToString()));
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
