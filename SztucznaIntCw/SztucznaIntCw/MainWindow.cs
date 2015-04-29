using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using SztucznaIntCw.Classes;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.DBModel;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Utilities;

namespace SztucznaIntCw
{
    public partial class MainWindow : Form
    {

        private TypeOfProvidedData providedDataType;

        public MainWindow()
        {
            InitializeComponent();
            genderTextBox.MaxLength = 1;
            simpleDataRadioButton.Checked = true;
            EnableBasicData();
            weightTextBox.MaxLength = 3;
            heightTextBox.MaxLength = 3;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void genderTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(genderTextBox.Text != string.Empty && e.KeyCode == Keys.Enter)) return;

            if (providedDataType != TypeOfProvidedData.Detail) return;
        }

        private void genderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == 'M' || e.KeyChar == 'K' || e.KeyChar =='m' || e.KeyChar =='k' || e.KeyChar == (char)Keys.Back);
        }


        private void EnableBasicData()
        {
            
            dataGroupBox.Enabled = true;
            weightTextBox.Enabled = false;
            heightTextBox.Enabled = false;
            activityGroupBox.Enabled = false;
            physiqueGroupBox.Enabled = false;
        }


        private void EnableDetailsData()
        {

            dataGroupBox.Enabled = true;
            weightTextBox.Enabled = true;
            heightTextBox.Enabled = true;
            activityGroupBox.Enabled = true;
            physiqueGroupBox.Enabled = true;
         
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           // ICalculator calc = new 
  
           // neededKcalLabel.Text = @"Twoje zapotrzebowanie wynosi 1943 kcal, BMI: 20.3";

        }

        private void simpleDataRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnableBasicData();
           
        }

        private void detailsDataRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnableDetailsData();
        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {//48-57
            e.Handled = (e.KeyChar<48 || e.KeyChar>57);
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar < 48 || e.KeyChar > 57);
        }

        private void GenerateDefaultDiet_Click(object sender, EventArgs e)
        {
            //  Pobieramy z bazy wszystkie produkty
            //  Na ich podstawie generujemy dietę zgodną z zaznaczonym radiobuttonem
            //  Wyświetlamy grubej świni przykładową dietę redukcyjną (nie chcemy grubasów w naszym kraju) :D
        }

        private void GeneratePersonalizedDiet_Click(object sender, EventArgs e)
        {
            List<Question> QuestionList = new List<Question>();
            IEnumerable<categories> categoriesList;
            IEnumerable<products> productsList;

            using (var dbConnection = new Entities())
            {
                categoriesList = (from b in dbConnection.categories select b).ToList();
                
            }

            using (var dbConnection = new Entities())
            {      
                foreach (var category in categoriesList)
                {
                    productsList = from c in dbConnection.products where c.id_category == category.id_category select c;
                    QuestionList.Add(new Question(category.id_category, category.nameCategory, productsList.ToList()));
                    //QuestionList.Add(new Question(category.id_category, category.nameCategory, productsList));
                }
            }
            QuestionWindow questionWindow = new QuestionWindow(QuestionList[0]);
            questionWindow.Show();
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
