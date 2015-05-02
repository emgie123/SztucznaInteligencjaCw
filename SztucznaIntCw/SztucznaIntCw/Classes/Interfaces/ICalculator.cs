using System.Windows.Forms;

namespace SztucznaIntCw.Classes.Interfaces
{
    interface ICalculator
    {
        void GetKcalValue(IPerson person);
        void SetLabel(Label label, IPerson person);
    }
}
