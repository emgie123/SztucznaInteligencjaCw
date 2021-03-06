﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SztucznaIntCw.Classes;
using SztucznaIntCw.Classes.NonAbstract;
using SztucznaIntCw.DBModel;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Utilities;

namespace SztucznaIntCw
{
    public partial class QuestionWindow : Form
    {
        private Dictionary<Label, TextBox> categoryValue;
        private List<CheckBox> categorySelect;

        private List<Product> injectedProducts;
        private List<Question> questions;
        private Person systemUser;

        private List<meals> injectedMealsConsumptionTime;
 
        public QuestionWindow()
        {
          
            InitializeComponent();
       
        }

        public QuestionWindow(List<Question> questions, Person person, List<meals> consumptionTimeList)
        {
            InitializeComponent();

            systemUser = person;
            this.questions = questions;
            this.injectedMealsConsumptionTime = consumptionTimeList;

            injectedProducts = questions[MainWindow.QuestionCounter].Products;

            this.richTextBox1.Text = questions[MainWindow.QuestionCounter].Content;
            this.label2.Text = questions[MainWindow.QuestionCounter].Number.ToString();

            categoryValue = new Dictionary<Label, TextBox>();
            categorySelect = new List<CheckBox>();

            int xCoordinate = 5;
            int yCoordinate = 5;


            foreach (var product in injectedProducts)
            {
                categoryValue.Add(new Label() {Location = new Point(xCoordinate, yCoordinate), 
                    Text = product.Name}, new TextBox(){Location = new Point(xCoordinate + 200, yCoordinate), MaxLength = 2, Text = "50"});
                categorySelect.Add(new CheckBox() { Location = new Point(xCoordinate + 320, yCoordinate), Checked = true });

                categoryValue.Values.Last().KeyPress += (sender, e) => e.Handled = ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != (char)Keys.Back);
                yCoordinate += 25;

                //this.panel1.MaximumSize = new Size(415, 201); Nie wiem czemu ale to nie działa (chciałbym wywalić poziomy scroll).
                this.panel1.Controls.Add(categorySelect.Last());
                this.panel1.Controls.Add(categoryValue.Last().Key);
                this.panel1.Controls.Add(categoryValue.Last().Value);
            }
           
        }

        private void NextCategory_Click(object sender, EventArgs e)
        {
            int categorySelectCounter = 0;

            foreach (var categoryItem in categoryValue)
            {
                if (!categorySelect[categorySelectCounter].Checked)
                {
                    //injectedProducts.RemoveAt(categorySelectCounter);
                    categorySelectCounter++;
                    continue;
                }

                var eatingTimesForCurrentProduct = (from c in injectedMealsConsumptionTime
                    where c.id_product == injectedProducts[categorySelectCounter].ID
                    select c).ToList();
                
                systemUser.diet.ChoosenProducts.Add(new Product()
                {
                    ID = injectedProducts[categorySelectCounter].ID,
                    Carbs = injectedProducts[categorySelectCounter].Carbs,
                    Protein = injectedProducts[categorySelectCounter].Protein,
                    CategoryName = injectedProducts[categorySelectCounter].CategoryName,
                    MacroElement = injectedProducts[categorySelectCounter].MacroElement,
                    Fat = injectedProducts[categorySelectCounter].Fat,
                    Kcal = injectedProducts[categorySelectCounter].Kcal,
                    Name = injectedProducts[categorySelectCounter].Name,
                    Rating = int.Parse(categoryItem.Value.Text),
                });

                if(eatingTimesForCurrentProduct.Count != 0)
                {
                    systemUser.diet.ChoosenProducts.Last().ConsumptionTime[(int)FoodConsumptionTime.FirstMeal] =
                    eatingTimesForCurrentProduct[0].first_meal;
                    systemUser.diet.ChoosenProducts.Last().ConsumptionTime[(int)FoodConsumptionTime.SecondMeal] =
                        eatingTimesForCurrentProduct[0].second_meal;
                    systemUser.diet.ChoosenProducts.Last().ConsumptionTime[(int)FoodConsumptionTime.ThirdMeal] =
                        eatingTimesForCurrentProduct[0].third_meal;
                    systemUser.diet.ChoosenProducts.Last().ConsumptionTime[(int)FoodConsumptionTime.FourthMeal] =
                        eatingTimesForCurrentProduct[0].fourth_meal;
                    systemUser.diet.ChoosenProducts.Last().ConsumptionTime[(int)FoodConsumptionTime.FifthMeal] =
                        eatingTimesForCurrentProduct[0].fifth_meal;
                }
                
                
                categorySelectCounter++;
            }

            MainWindow.QuestionCounter++;
            if (MainWindow.QuestionCounter < questions.Count)
            {
                QuestionWindow nextQuestionWindow = new QuestionWindow(questions, systemUser, injectedMealsConsumptionTime)
                {
                    StartPosition = FormStartPosition.CenterParent
                };

                this.Hide();
                nextQuestionWindow.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
            

        }

    }
}
