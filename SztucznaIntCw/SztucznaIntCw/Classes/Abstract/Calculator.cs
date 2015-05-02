using System.Windows.Forms;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.Abstract
{
    public abstract class Calculator : ICalculator
    {
        public abstract void GetKcalValue(IPerson person);
        public abstract void SetLabel(Label label,IPerson person);
       
    }
}
