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
            weightTextBox.Enabled = false;
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
                
                SystemUser.Weight = Convert.ToSingle(weightTextBox.Text);
                SystemUser.Height = Convert.ToSingle(heightTextBox.Text);
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
            leaveCurrentWeightRadioButton.Checked = true;

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

            //TODO
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

        private void  AssignMealsDictionaryToPerson(IPerson person,int mealsCount)
        {

            Dictionary<int, IMeal> mealsDictionary = new Dictionary<int, IMeal>();

            for (int i = 0; i < mealsCount; i++)
            {
                mealsDictionary.Add(i,new Meal());
            }



            person.diet.Meals = mealsDictionary;
           
        }


        private bool ValidateInput()
        {
            InputDataValidationList = new List<string>();
            
            if(weightTextBox.Text==string.Empty) InputDataValidationList.Add(@"Podaj wagę." + Environment.NewLine );
            if(heightTextBox.Text==string.Empty) InputDataValidationList.Add(@"Podaj wzrost." + Environment.NewLine);
            if(ageTextBox.Text==string.Empty) InputDataValidationList.Add(@"Podaj wiek." + Environment.NewLine);
            if(strenghtActivityTextBox.Text==string.Empty) InputDataValidationList.Add(@"Podaj czas treningu siłowego." + Environment.NewLine);
            if(aeroActivityTextBox.Text==string.Empty) InputDataValidationList.Add(@"Podaj czas treningu aerobowego." + Environment.NewLine);


            return InputDataValidationList.Count <= 0;

        }



    }
}
