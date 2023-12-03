using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MorozAD.Sprint6.Task0.V13.Lib
{
    public class DataService : ISprint6Task0V13
    {
        public double Calculate(int x)
        {
            double y = (Math.Pow(x, 3)) / (Math.Pow(x, 2) - 1);
            return Math.Round(y, 3);
        }
    }
}
