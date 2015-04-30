using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw.Classes.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        float Protein { get; set; }
        float Carbs { get; set; }
        float Fat { get; set; }
        float Kcal { get; set; }
        string CategoryName { get; set; }
        int Rating { get; set; }
        bool IncludeInDiet { get; set; }
        MainSourceOf MacroElement { get; set; }
        //  Narazie więcej nie uzupełniałem bo zależy co będzie w modelu klasy siedziało
    }
}
