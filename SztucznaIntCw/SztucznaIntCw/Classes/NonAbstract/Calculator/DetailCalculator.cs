using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.NonAbstract.Calculator
{
    class DetailCalculator : Abstract.Calculator
    {
        public override IPerson GetKcalValue(IPerson person)
        {
            throw new System.NotImplementedException();
        }
    }
}
