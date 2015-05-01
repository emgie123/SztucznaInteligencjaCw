
using System.Collections.Generic;
using System.Windows.Forms;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Classes.NonAbstract;

namespace SztucznaIntCw.Classes
{
    public class Diet
    {

        public List<IProduct> _choosenProducts; 

        public Dictionary<int, IMeal> Meals { get; set; }

        //todo: Oprogramować logikę dotyczącą generowania planu diety (w tym celu należy na podstawie 
        // otrzymanego słownika wyciągnąć schemat danego posiłka (ile gramów danego składnika)
    }
}
