using System.Windows.Forms;
using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.NonAbstract.CalculatorDirectory
{
    class BasicCalculator : Calculator
    {
        private const int  MaleAverageDailyKCAL = 2500;
        private const int  FemaleAverageDailyKCAL = 2000;

        private string BasicPatternt = @"Twoje zapotrzebowanie wynosi {0}";

        public override void GetKcalValue(IPerson person)
        {
            person.CalculatedTDEE = person.Gender == TypeOfGender.Male ? MaleAverageDailyKCAL : FemaleAverageDailyKCAL;
        }

        public override void SetLabel(Label label,IPerson person)
        {

            label.Text = string.Format(BasicPatternt, person.CalculatedTDEE);
        }
    }
}
