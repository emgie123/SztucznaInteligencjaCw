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
        decimal Protein { get; set; }
        decimal Carbs { get; set; }
        decimal Fat { get; set; }
        float Kcal { get; set; }
        string CategoryName { get; set; }
        int Rating { get; set; }
        bool IncludeInDiet { get; set; }
        MainSourceOf MacroElement { get; set; }
        bool[] ConsumptionTime { get; set; }


        //  Narazie więcej nie uzupełniałem bo zależy co będzie w modelu klasy siedziało
        }
}
