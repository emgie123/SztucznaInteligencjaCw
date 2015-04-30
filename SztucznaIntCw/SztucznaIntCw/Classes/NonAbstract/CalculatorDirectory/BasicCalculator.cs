using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.NonAbstract.CalculatorDirectory
{
    class BasicCalculator : Calculator
    {
        private const int  MaleAverageDailyKCAL = 2500;
        private const int  FemaleAverageDailyKCAL = 2000;
        public override void GetKcalValue(IPerson person)
        {
            person.TDEE = person.Gender == TypeOfGender.Male ? MaleAverageDailyKCAL : FemaleAverageDailyKCAL;
        }
    }
}
