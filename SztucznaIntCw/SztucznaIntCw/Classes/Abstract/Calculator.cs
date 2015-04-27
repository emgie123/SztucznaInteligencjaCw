using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SztucznaIntCw.Classes.Interfaces;

namespace SztucznaIntCw.Classes.Abstract
{
    public abstract class Calculator : ICalculator 
    {
        public float GetKcalValue()
        {
            throw new NotImplementedException();
        }
    }
}
