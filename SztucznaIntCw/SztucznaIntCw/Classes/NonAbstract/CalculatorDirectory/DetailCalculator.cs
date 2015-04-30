using SztucznaIntCw.Classes.Abstract;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.NonAbstract.CalculatorDirectory
{
    class DetailCalculator : Calculator
    {

        private const int MaleAdditionalValue = 5;
        private const int FemaleAdditionalValue = -161;
        private int selectedAdditionalValue;

        public override void GetKcalValue(IPerson person)
        {
            selectedAdditionalValue = person.Gender == TypeOfGender.Male ? MaleAdditionalValue : FemaleAdditionalValue;



        }

        //TDEE = BMR + TEA + TEF + NEAT [kcal]

        private int GetBmr(IPerson person)
        {
            return (int) (((9.99*person.Weight) + (6.25*person.Height) - (4.92*person.Age)) + selectedAdditionalValue);
        }

       
    }
}
