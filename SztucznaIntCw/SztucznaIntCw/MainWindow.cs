using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SztucznaIntCw.Classes;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Classes.NonAbstract;
using SztucznaIntCw.Classes.NonAbstract.CalculatorDirectory;
using SztucznaIntCw.DBModel;
using SztucznaIntCw.Enums;
using SztucznaIntCw.Utilities;

namespace SztucznaIntCw
{
    public partial class MainWindow : Form
    {

        private TypeOfProvidedData providedDataType;
        public Person SystemUser;
        public static int QuestionCounter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
      
            simpleDataRadioButton.Checked = true;
            EnableBasicData();

            genderTextBox.MaxLength = 1;
            weightTextBox.MaxLength = 3;
            heightTextBox.MaxLength = 3;
            ageTextBox.MaxLength = 3;

            SystemUser = new Person();
            QuestionCounter = 0;
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
            ICalculator calc;

            if (detailsDataRadioButton.Checked)
            {
                calc = new DetailCalculator();
            }
            else
            {
                calc = new BasicCalculator();
            }


            calc.GetKcalValue(SystemUser);

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


        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {//48-57
            e.Handled = (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != (char)Keys.Back;
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != (char)Keys.Back;
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
                 }
            }

            QuestionWindow questionWindow = new QuestionWindow(QuestionList, SystemUser)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            questionWindow.ShowDialog();

            Diet personalDiet = new Diet();
            personalDiet._choosenProducts = SystemUser.PrefferedProducts;
            personalDiet.Meals = new Dictionary<int, IMeal>();


        }

        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != (char)Keys.Back;
        }

        private void aeroActivityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void strenghtActivityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }




    }
}
