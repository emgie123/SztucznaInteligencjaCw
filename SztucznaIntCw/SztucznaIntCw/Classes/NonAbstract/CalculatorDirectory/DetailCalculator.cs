using System;
using System.Windows.Forms;
using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.NonAbstract.CalculatorDirectory
{
    public class DetailCalculator : Calculator
    {

        private const int MaleAdditionalValue = 5;
        private const int FemaleAdditionalValue = -161;
        private int _selectedAdditionalValue;

        private string DetailPattern = @"Twoje zapotrzebowanie wynosi {0} KCAL .{1} BMI: {2} - {3}.";

        public override void GetKcalValue(IPerson person)
        {
            _selectedAdditionalValue = person.Gender == TypeOfGender.Male ? MaleAdditionalValue : FemaleAdditionalValue;

            var BMR = GetBMR(person);
            var TEA = GetTEA(person, BMR);
            var NEAT = GetNEAT(person);

            var TDEE = BMR + TEA + NEAT;
            TDEE = TDEE + GetTEF(person, TDEE);
            person.CalculatedTDEE = (int)TDEE;
            AssignBMI(person);

        }

        public override void SetLabel(Label label,IPerson person)
        {
            label.Text = String.Format(DetailPattern, person.CalculatedTDEE,Environment.NewLine, person.BMI, ResolveBMIResult(person.BMI));
        }

        //CalculatedTDEE = BMR + TEA + TEF + NEAT [kcal]

        //podstawowa przemiana materii
        private int GetBMR(IPerson person)
        {
            return (int) (((9.99m*person.Weight) + (6.25m*person.Height) - (4.92m*person.Age)) + _selectedAdditionalValue);
        }

        //kalorie spalone podczas aktywności fizycznej
        private decimal GetTEA(IPerson person, int BMR)
        {
            var averageDailyStrenghtActivity = person.WeeklyStrenghtActivity/7m;
            var averageDailyAeroActivity = person.WeeklyAeroActivity/7m;
           

            var strenghtKcal = averageDailyStrenghtActivity == 0 ? 0 :  CalculatorFactories.TeaStrenghtActivityFactory[person.TypeOfPhysique](averageDailyStrenghtActivity,BMR);
            var aeroKcal = averageDailyAeroActivity ==0? 0 :CalculatorFactories.TeaAeroActivityFactory[person.TypeOfPhysique](averageDailyAeroActivity);

            return Math.Round(strenghtKcal + aeroKcal,MidpointRounding.AwayFromZero);

        }

        //termogeneza nie wynikająca z ćwiczeń
        private decimal GetNEAT(IPerson person)
        {
            return CalculatorFactories.NEATValueFactory[person.TypeOfPhysique]();
        }


        //termogeneza poposiłkowa
        private decimal GetTEF(IPerson person, decimal TDEE)
        {
            return Math.Round(CalculatorFactories.TEFValueFactory[person.TypeOfPhysique](TDEE),MidpointRounding.AwayFromZero);
        }

        private void AssignBMI(IPerson person)
        {
            var heightInMeters = person.Height/100;
            person.BMI = Math.Round(person.Weight / (heightInMeters * heightInMeters), 1);
        }

        private string ResolveBMIResult(decimal bmi)
        {
            if (bmi < 18.5m)
            {
                return "niedowaga";
            }
            else if (bmi >= 18.5m && bmi < 25)
            {
                return "waga prawidłowa";
            }
            else
            {
                return "nadwaga";
            }
        }
       
    }
}
