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

       
        public Person SystemUser;
        public static int QuestionCounter { get; set; }

        private List<string> InputDataValidationList;


        public MainWindow()
        {
            InitializeComponent();
      
            simpleDataRadioButton.Checked = true;
            EnableBasicData();

            genderTextBox.MaxLength = 1;
            weightTextBox.MaxLength = 3;
            heightTextBox.MaxLength = 3;
            ageTextBox.MaxLength = 3;
            ektoRadioButton.Checked = true;

            dietGeneratorGroupBox.Enabled = false;


       

            SystemUser = new Person();
            SystemUser.diet = new Diet();
            QuestionCounter = 0;
        }


        private void genderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == 'M' || e.KeyChar == 'K' || e.KeyChar =='m' || e.KeyChar =='k' || e.KeyChar == (char)Keys.Back);
        }


        private void EnableBasicData()
        {
            
            dataGroupBox.Enabled = true;
            weightTextBox.Enabled = true;
            heightTextBox.Enabled = false;
            ageTextBox.Enabled = false;
            activityGroupBox.Enabled = false;
            physiqueGroupBox.Enabled = false;
        }


        private void EnableDetailsData()
        {

            dataGroupBox.Enabled = true;
            weightTextBox.Enabled = true;
            heightTextBox.Enabled = true;
            ageTextBox.Enabled = true;
            activityGroupBox.Enabled = true;
            physiqueGroupBox.Enabled = true;
          

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (genderTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"Określ płeć!");
                return;
            }

            if (weightTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"Podaj wagę!");
                return;
            }

            SystemUser.Weight = Convert.ToDecimal(weightTextBox.Text);
            SystemUser.Gender = genderTextBox.Text.ToUpper() == "M" ? TypeOfGender.Male : TypeOfGender.Female;
 
            ICalculator calc;
     

            if (detailsDataRadioButton.Checked)
            {
                if (!ValidateInput())
                {
                    string warnings = InputDataValidationList.Aggregate((current, warning) => current + warning);

                    MessageBox.Show(@"Napotkano następujące błędy:" + Environment.NewLine + Environment.NewLine + warnings);
                    return;
                }
                
                SystemUser.Weight = Convert.ToDecimal(weightTextBox.Text);
                SystemUser.Height = Convert.ToDecimal(heightTextBox.Text);
                SystemUser.Age = Convert.ToInt32(ageTextBox.Text);

                if (ektoRadioButton.Checked) SystemUser.TypeOfPhysique = TypeOfPhysique.Ekto;
                else if(mezoRadioButton.Checked) SystemUser.TypeOfPhysique = TypeOfPhysique.Mezo;
                else SystemUser.TypeOfPhysique = TypeOfPhysique.Endo;

                SystemUser.WeeklyStrenghtActivity = Convert.ToInt32(strenghtActivityTextBox.Text);
                SystemUser.WeeklyAeroActivity = Convert.ToInt32(aeroActivityTextBox.Text);
             
                calc = new DetailCalculator();
        
            }
            else
            {
          
                calc = new BasicCalculator();
        
            }


            calc.GetKcalValue(SystemUser);
            calc.SetLabel(neededKcalLabel, SystemUser);

            dietGeneratorGroupBox.Enabled = true;
            fiveMealsRadioButton.Checked = true;
            maintainWeightRadioButton.Checked = true;

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
            QuestionCounter = 0;
            SystemUser.diet.ChoosenProducts.Clear();
            
            List<Question> QuestionList = new List<Question>();
            IEnumerable<categories> categoriesList;
            IEnumerable<products> productsList;
            IEnumerable<meals> mealsConsumptionTime;

            using (var dbConnection = new Entities())
            {
                categoriesList = (from b in dbConnection.categories select b).ToList();
                productsList = (from c in dbConnection.products select c).ToList();
                mealsConsumptionTime = (from d in dbConnection.meals select d).ToList();
            }
    
            foreach (var category in categoriesList)
            {
                var currentCategoryProducts = from c in productsList where c.id_category == category.id_category select c;
                QuestionList.Add(new Question(category.id_category, category.nameCategory, currentCategoryProducts.ToList()));
            }

            QuestionWindow questionWindow = new QuestionWindow(QuestionList, SystemUser, mealsConsumptionTime.ToList())
            {
                StartPosition = FormStartPosition.CenterParent
            };
            questionWindow.ShowDialog();


        
            //Tooooooo musisz dodac do 2 buttona tez
            CalculateKcalAndPrepareDiet();
      
            SystemUser.diet.GenerateDiet();
            // SystemUser.diet.Meals =;


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

        private bool ValidateInput()
        {
            InputDataValidationList = new List<string>();
            
    
            if(heightTextBox.Text==string.Empty) InputDataValidationList.Add(@"Podaj wzrost." + Environment.NewLine);
            if(ageTextBox.Text==string.Empty) InputDataValidationList.Add(@"Podaj wiek." + Environment.NewLine);
            if(strenghtActivityTextBox.Text==string.Empty) InputDataValidationList.Add(@"Podaj czas treningu siłowego." + Environment.NewLine);
            if(aeroActivityTextBox.Text==string.Empty) InputDataValidationList.Add(@"Podaj czas treningu aerobowego." + Environment.NewLine);


            return InputDataValidationList.Count <= 0;

        }


        private void AddKcalDifferenceBasedOnDietType()
        {
            if (gainWeightRadioButton.Checked)
            {
                SystemUser.TDEEKcalChange = DietKcalFactories.IncreaseWeightAdditionalKCAL[SystemUser.TypeOfPhysique];
            }
            else if (reduceWeightRadioButton.Checked)
            {
                SystemUser.TDEEKcalChange = DietKcalFactories.LooseWeightMinusKCAL[SystemUser.TypeOfPhysique];
            }

            SystemUser.TDEEWithDietTypeIncluded = SystemUser.CalculatedTDEE + SystemUser.TDEEKcalChange;
        }

   
        private void CalculateKcalAndPrepareDiet()
        {
            SystemUser.diet.AmountOfMeals = threeMealsRadioButton.Checked ? 3 : fourMealsRadioButton.Checked ? 4 : 5;
            SystemUser.diet.TypeofDiet = maintainWeightRadioButton.Checked ? TypeOfDiet.ToMaintainWeight : gainWeightRadioButton.Checked ? TypeOfDiet.ToGainWeight : TypeOfDiet.ToLoseWeight;

            AddKcalDifferenceBasedOnDietType(); // określa pole systemuser.IncreaseWeightAdditionalKCAL w zaleznosci od diety i budowy ciała
            DietMakroComponentsAmount makroComponents = new DietMakroComponentsAmount(SystemUser);
            SystemUser.diet.Meals = makroComponents.GetMealsDictionary();
        }

    }
}
