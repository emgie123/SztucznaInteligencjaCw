using Microsoft.VisualStudio.TestTools.UnitTesting;
using SztucznaIntCw.Classes;
using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.NonAbstract;
using SztucznaIntCw.Classes.NonAbstract.CalculatorDirectory;
using SztucznaIntCw.Enums;

namespace TestProject
{
    [TestClass]
    public class Wyniki
    {
        private MacroElements _amountOfMacroElements;
        private Person _sampleUser;
        private DetailCalculator calc;

        private void CalculateMacroElements(TypeOfPhysique physique,TypeOfDiet diet)
        {
            _sampleUser.TypeOfPhysique = physique;
            _sampleUser.diet.TypeofDiet = diet;

            _amountOfMacroElements = 
                DietKcalFactories.MacroElementsDependingOnDietType[_sampleUser.diet.TypeofDiet][_sampleUser.TypeOfPhysique]
                (_sampleUser.TDEEWithDietTypeIncluded, _sampleUser.Weight);
        }
        [TestMethod]
        public void IloscGram()
        {
            _sampleUser = new Person()
            {
                Weight = 70,
                TypeOfPhysique = TypeOfPhysique.Ekto,
                diet = new Diet()
            };
            //================================Utrzymanie wagi=============================
            _sampleUser.TDEEWithDietTypeIncluded = 2500;
            //ektomorfik
            CalculateMacroElements(TypeOfPhysique.Ekto, TypeOfDiet.ToMaintainWeight);

            Assert.AreEqual(_amountOfMacroElements.Proteins, 94);
            Assert.AreEqual(_amountOfMacroElements.Fats, 69);
            Assert.AreEqual(_amountOfMacroElements.Carbohydrates, 375);

            //mezomorfik
            CalculateMacroElements(TypeOfPhysique.Mezo, TypeOfDiet.ToMaintainWeight);

            Assert.AreEqual(_amountOfMacroElements.Proteins, 106);
            Assert.AreEqual(_amountOfMacroElements.Fats, 78);
            Assert.AreEqual(_amountOfMacroElements.Carbohydrates, 344);

            //endomorfik
            CalculateMacroElements(TypeOfPhysique.Endo, TypeOfDiet.ToMaintainWeight);

            Assert.AreEqual(_amountOfMacroElements.Proteins, 144);
            Assert.AreEqual(_amountOfMacroElements.Fats, 89);
            Assert.AreEqual(_amountOfMacroElements.Carbohydrates, 281);

            //================================Dieta masowa=============================
            _sampleUser.TDEEWithDietTypeIncluded = 2900;
            //ektomorfik
            CalculateMacroElements(TypeOfPhysique.Ekto, TypeOfDiet.ToGainWeight);

            Assert.AreEqual(_amountOfMacroElements.Proteins, 147);
            Assert.AreEqual(_amountOfMacroElements.Fats, 70);
            Assert.AreEqual(_amountOfMacroElements.Carbohydrates, 421);

            _sampleUser.TDEEWithDietTypeIncluded = 2800;
            //mezomorfik
            CalculateMacroElements(TypeOfPhysique.Mezo, TypeOfDiet.ToGainWeight);

            Assert.AreEqual(_amountOfMacroElements.Proteins, 161);
            Assert.AreEqual(_amountOfMacroElements.Fats, 84);
            Assert.AreEqual(_amountOfMacroElements.Carbohydrates, 350);

            _sampleUser.TDEEWithDietTypeIncluded = 2700;
            //endomorfik
            CalculateMacroElements(TypeOfPhysique.Endo, TypeOfDiet.ToGainWeight);

            Assert.AreEqual(_amountOfMacroElements.Proteins, 175);
            Assert.AreEqual(_amountOfMacroElements.Fats, 91);
            Assert.AreEqual(_amountOfMacroElements.Carbohydrates, 295);

            //================================Dieta redukcyjna=============================
            _sampleUser.TDEEWithDietTypeIncluded = 2300;
            //ektomorfik
            CalculateMacroElements(TypeOfPhysique.Ekto, TypeOfDiet.ToReduceWeight);

            Assert.AreEqual(_amountOfMacroElements.Proteins, 147);
            Assert.AreEqual(_amountOfMacroElements.Fats, 56);
            Assert.AreEqual(_amountOfMacroElements.Carbohydrates, 302);

            _sampleUser.TDEEWithDietTypeIncluded = 2200;
            //mezomorfik
            CalculateMacroElements(TypeOfPhysique.Mezo, TypeOfDiet.ToReduceWeight);

            Assert.AreEqual(_amountOfMacroElements.Proteins, 161);
            Assert.AreEqual(_amountOfMacroElements.Fats, 70);
            Assert.AreEqual(_amountOfMacroElements.Carbohydrates, 232);

            _sampleUser.TDEEWithDietTypeIncluded = 2100;
            //endomorfik
            CalculateMacroElements(TypeOfPhysique.Endo, TypeOfDiet.ToReduceWeight);

            Assert.AreEqual(_amountOfMacroElements.Proteins, 168);
            Assert.AreEqual(_amountOfMacroElements.Fats, 70);
            Assert.AreEqual(_amountOfMacroElements.Carbohydrates, 200);
        }


        private void CalculateKcal(TypeOfGender gender, TypeOfPhysique physique, int age, int height, int weight)
        {
            _sampleUser.Gender = gender;
            _sampleUser.TypeOfPhysique = physique;
            _sampleUser.Age = age;
            _sampleUser.Height = height;
            _sampleUser.Weight = weight;

            calc.GetKcalValue(_sampleUser);
        }

        [TestMethod]
        public void IloscKcal()
        {
            calc = new DetailCalculator();
            _sampleUser = new Person()
            {
                WeeklyAeroActivity = 60,
                WeeklyStrenghtActivity = 90
            };

            //ektomorfik
            CalculateKcal(TypeOfGender.Male, TypeOfPhysique.Ekto, 24, 180, 75);
            Assert.AreEqual(_sampleUser.CalculatedTDEE, 2801);

            CalculateKcal(TypeOfGender.Female, TypeOfPhysique.Ekto, 24, 170, 60);
            Assert.AreEqual(_sampleUser.CalculatedTDEE, 2354);

            //mezmorofik
            CalculateKcal(TypeOfGender.Male, TypeOfPhysique.Mezo, 24, 180, 75);
            Assert.AreEqual(_sampleUser.CalculatedTDEE, 2576);

            CalculateKcal(TypeOfGender.Female, TypeOfPhysique.Mezo, 24, 170, 60);
            Assert.AreEqual(_sampleUser.CalculatedTDEE, 2144);

            //endomorfik
            CalculateKcal(TypeOfGender.Male, TypeOfPhysique.Endo, 24, 180, 75);
            Assert.AreEqual(_sampleUser.CalculatedTDEE, 2315);

            CalculateKcal(TypeOfGender.Female, TypeOfPhysique.Endo, 24, 170, 60);
            Assert.AreEqual(_sampleUser.CalculatedTDEE, 1897);
           
        }
    }
}
